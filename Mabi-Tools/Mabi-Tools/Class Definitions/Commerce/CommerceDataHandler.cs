using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Mabi_Tools.Classes
{
    /// <summary>
    /// A static class to contain methods for loading, saving, and processing data to and from disk
    /// </summary>
    public static class CommerceDataHandler
    {
        /// <summary>
        /// The character that separates data on each line of a text/csv file
        /// </summary>
        public static readonly char MAIN_TEXT_SEPARATOR = ',';
        /// <summary>
        /// The character to be used that separates small subentries within each main entry of a line from a text/csv file
        /// </summary>
        public static readonly char SECONDARY_TEXT_SEPARATOR = ';';

        /// <summary>
        /// Loads the data for Cities and the goods associated with each from the disk. Currently assumes a csv/text file format with data separated by MAIN_TEXT_SEPARATOR
        /// and secondary values separated by SECONDARY_TEXT_SEPARATOR
        /// </summary>
        /// <param name="filePath">The location of the file on disk</param>
        /// <returns>Dictionary that contains every city and the goods under each city</returns>
        public static Dictionary<String, City> loadCommerceData(String filePath)
        {
            Dictionary<String, City> cityData = new Dictionary<string, City>();
            //CityNames = File.ReadAllLines(citiesFile).ToList();
            //We will handle file not found exception on the outside
            String[] rawData = File.ReadAllLines(filePath);
            foreach (String s in rawData)
            {
                //Separate the individual good strings and process
                String[] goodStrings = s.Split(MAIN_TEXT_SEPARATOR);
                List<Good> cityGoods = convertStringArrayToGoods(goodStrings);
                //Now add the data to the Dictionary
                cityData[goodStrings[0]] = new City(goodStrings[0], cityGoods);
                cityGoods = null;
            }
            return cityData;
        }
        /// <summary>
        /// Converts a supplied string to a list of Good Objects. Currently the only method that utilizes SECONDARY_TEXT_SEPARATOR.
        /// </summary>
        /// <param name="input">An array of strings where the MAIN_TEXT_SEPARATOR has already been processed</param>
        /// <returns>A list of Goods</returns>
        public static List<Good> convertStringArrayToGoods(String[] input)
        {
            //Currently, I am operating under the assumption the first item in the input string array is the city name - therefore I will skip over it
            List<Good> returnList = new List<Good>();
            for (int i = 1; i < input.Length; i++)
            {
                //Split the strings further
                String[] goodSplit = input[i].Split(SECONDARY_TEXT_SEPARATOR);
                try
                {
                    //Add the new good to the array
                    returnList.Add(new Good(goodSplit[0], Int32.Parse(goodSplit[1]), Int32.Parse(goodSplit[2])));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error Processing Data For City '" + input[0] + " and Good '" + goodSplit[0] + "' : \n" + ex.Message, "Format Error");
                }
            }
            return returnList;
        }

        /// <summary>
        /// Loads the data from disk for the Transport Objects. Assumes a csv/text file with values separated by MAIN_TEXT_SEPARATOR
        /// </summary>
        /// <param name="filePath">Location of the file on disk</param>
        /// <returns></returns>
        public static Dictionary<String, Transport> loadTransportData(String filePath)
        {
            Dictionary<String, Transport> TransportData = new Dictionary<String, Transport>();
            //Moving this variable out for Error Reporting
            String name = "";
            //Will be expanded upon later - for now only need name of transports
            try
            {
                string[] rawdata = File.ReadAllLines(filePath);
                foreach (String s in rawdata)
                {
                    String[] split = s.Split(MAIN_TEXT_SEPARATOR);
                    name = split[0];
                    //Current ordering assumes number of slots comes first and weight second
                    Transport temp = new Transport(name, Int32.Parse(split[1]), Int32.Parse(split[2]));
                    TransportData[name] = temp;
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Error formatting Transport Data for '" + name + "' : \n" + fex.Message, "Error");
            }
            return TransportData;

        }

        //I need a function that saves in the order of a checklist box - since you can't reorder a dictionary's keys - let the checklist box determine the saving order

        /// <summary>
        /// Saves the CityData Dictionary to disk in csv/text format. A checklistbox is supplied to enforce the order keys are saved for UI purposes.
        /// </summary>
        /// <remarks>
        /// Since the only order to dictionary keys are determined by the order they are added,I decided the best way to maintain the order of cities 
        /// by the user's choice is to restructure the data so that when the Dictionary is next loaded, the order is how the user arranged them, and not the order they were created.
        /// Also, While I could create a list of strings from the checkboxes content and pass that, I feel that it's faster to simply pass a refernce and take directly from it instead
        /// </remarks>
        /// <param name="filePath">Location of file on disk</param>
        /// <param name="CityData">City Data to be saved</param>
        /// <param name="orderList">A checklist box to enforce order that keys are saved</param>
        public static void saveCommerceDataOrdered(String filePath, Dictionary<String, City> CityData, CheckedListBox orderList)
        {
            //I don't want to keep old data - overwrite the file
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < orderList.Items.Count; i++)
                {
                    if (CityData[orderList.Items[i].ToString()] == null)
                    {
                        continue;
                    }
                    sw.WriteLine(CityData[orderList.Items[i].ToString()].ToString());
                }
            }
        }

        /// <summary>
        /// Saves the TransportData object to disk in csv/text format. A checklistbox is supplied to enforce the order keys are saved for UI purposes
        /// </summary>
        /// <param name="filePath">Location of file on disk</param>
        /// <param name="TransportData"></param>
        /// <param name="orderList"></param>
        public static void saveTransportDataOrdered(String filePath, Dictionary<String, Transport> TransportData, CheckedListBox orderList)
        {
            //We don't want to keep old data - overwrite the file
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < orderList.Items.Count; i++)
                {
                    if (TransportData[orderList.Items[i].ToString()] == null)
                    {
                        continue;
                    }
                    sw.WriteLine(TransportData[orderList.Items[i].ToString()].ToString());
                }
            }
        }


        /// <summary>
        /// Takes each list of TimeSpans in a supplied Dictionary and returns the average of each one
        /// </summary>
        /// <param name="TimeData">A dictionary of times to take an avearage of</param>
        /// <returns>A Dictionary of Average time for each key</returns>
        //Compresses the time statistics into an average so that we may load it into the graph
        public static Dictionary<String, TimeSpan> compressTimeData(Dictionary<String, List<TimeSpan>> TimeData)
        {
            Dictionary<String, TimeSpan> avgTime = new Dictionary<String, TimeSpan>();
            foreach (KeyValuePair<String, List<TimeSpan>> kvp in TimeData)
            {
                avgTime[kvp.Key] = new TimeSpan(kvp.Value.Sum(t => t.Ticks) / kvp.Value.Count);
            }
            return avgTime;
        }

        /// <summary>
        /// Loads the data from disk for the TimeData. Assumes a csv/text file with values separated by MAIN_TEXT_SEPARATOR
        /// </summary>
        /// <remarks>
        /// The reason why I return a multi-level dictioanry inestead of averaging the time here is primarily for the Time Tracker editor
        /// </remarks>
        /// <param name="filePath">Location of file on disk</param>
        /// <returns>A multi-level dictionary containing every single line of time data</returns>
        public static Dictionary<String, Dictionary<String, List<TimeSpan>>> loadTimeData(String filePath)
        {
            Dictionary<String, Dictionary<String, List<TimeSpan>>> timeData = new Dictionary<String, Dictionary<String, List<TimeSpan>>>();

            String[] rawLines = File.ReadAllLines(filePath);
            //Each line of data should be structured as 'transport - start - endpoint - lane name - time' (without the quotes)
            for (int i = 0; i < rawLines.Length; i++)
            {
                String transport = "", source = "", destination = "", name = "", time = "";
                try
                {
                    String[] splitline = rawLines[i].Split(MAIN_TEXT_SEPARATOR);
                    transport = splitline[0];
                    source = splitline[1];
                    destination = splitline[2];
                    name = splitline[3];
                    time = splitline[4];

                    if (!timeData.ContainsKey(transport))
                    {
                        timeData[transport] = new Dictionary<String, List<TimeSpan>>();
                    }

                    String key = "";
                    //To avoid flipping the cities around - enforce alphabetical order at both load and save
                    if (source.CompareTo(destination) < 0)
                    {
                        key = destination + MAIN_TEXT_SEPARATOR + source + MAIN_TEXT_SEPARATOR + name;
                        //timeData[destination + MAIN_TEXT_SEPARATOR + source + MAIN_TEXT_SEPARATOR + name].Add(TimeSpan.Parse(time));
                    }
                    else
                    {
                        key = source + MAIN_TEXT_SEPARATOR + destination + MAIN_TEXT_SEPARATOR + name;
                        //timeData[source + MAIN_TEXT_SEPARATOR + destination + MAIN_TEXT_SEPARATOR + name].Add(TimeSpan.Parse(time));
                    }
                    //Check for uninitiated list then add
                    if (!timeData[transport].ContainsKey(key))
                    {
                        timeData[transport][key] = new List<TimeSpan>();
                    }
                    timeData[transport][key].Add(TimeSpan.Parse(time));
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Error converting '" + time + "' into a time at path '" + source + " " + destination + " " + name + " " + transport + "':\n" + fex.Message, "Time Formatting Error");
                }
            }
            return timeData;
        }
        
        /// <summary>
        /// Saves the time data to disk in text/csv format.
        /// </summary>
        /// <param name="filePath">Location of file to save to</param>
        /// <param name="timeData">Multi-Level Dictionary of time data to be saved.</param>
        public static void saveTimeData(String filePath, Dictionary<String, Dictionary<String, List<TimeSpan>>> timeData)
        {
            StringBuilder timeOutput = new StringBuilder();
            //Now go through each individual item and save to a file
            foreach(String transport in timeData.Keys)
            {
                foreach(KeyValuePair<String,List<TimeSpan>> kvpTime in timeData[transport])
                { 
                    for(int i = 0; i < kvpTime.Value.Count; i++)
                    {
                        timeOutput.Append(transport + CommerceDataHandler.MAIN_TEXT_SEPARATOR + kvpTime.Key + CommerceDataHandler.MAIN_TEXT_SEPARATOR + kvpTime.Value[i] + "\n");
                    }
                }
            }
            timeOutput.Remove(timeOutput.Length - 1, 1);
            File.WriteAllText(filePath, timeOutput.ToString());
        }

        public static Dictionary<String, int> loadCMasteryData(String filePath)
        {
            Dictionary<String, int> masteryData = new Dictionary<String, int>();
            String[] masteryLines = File.ReadAllLines(filePath);
            foreach(String s in masteryLines)
            {
                try
                {
                    String[] splitString = s.Split(MAIN_TEXT_SEPARATOR);
                    masteryData[splitString[0]] = int.Parse(splitString[1]);
                }
                catch(Exception ex) when (parsingAndIndexBounds(ex))
                {
                    MessageBox.Show("Error formatting commerce mastery line '" + s + "' : \n" + ex.Message);
                }
            }

            return masteryData;

        }

        private static bool parsingAndIndexBounds(Exception ex)
        {
            return ex is FormatException || ex is IndexOutOfRangeException;
        }

    }
    

}
