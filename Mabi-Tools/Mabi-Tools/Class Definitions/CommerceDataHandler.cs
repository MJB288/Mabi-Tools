using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Mabi_Tools
{
    public static class CommerceDataHandler
    {
        public static readonly char MAIN_TEXT_SEPARATOR = ',';
        public static readonly char SECONDARY_TEXT_SEPARATOR = ';';
        public static Dictionary<String, City> loadCommerceDataText(String citiesFile)
        {
            Dictionary<String, City> cityData = new Dictionary<string, City>();
            //CityNames = File.ReadAllLines(citiesFile).ToList();
            //We will handle file not found exception on the outside
            String[] rawData = File.ReadAllLines(citiesFile);
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

        public static Dictionary<String, Transport> loadTransportDataText(String transportFile)
        {
            Dictionary<String, Transport> TransportData = new Dictionary<String, Transport>();
            //Moving this variable out for Error Reporting
            String name = "";
            //Will be expanded upon later - for now only need name of transports
            try
            {
                string[] rawdata = File.ReadAllLines(transportFile);
                foreach (String s in rawdata)
                {
                    //This could be condensed into one line of code, saving a bit of memory, but for Readability purposes I decided against that
                    /*int graveI = s.IndexOf(MAIN_TEXT_SEPARATOR);
                    int semiI = s.IndexOf(";");
                    name = s.Substring(0, graveI);
                    String slots = s.Substring(graveI + 1, semiI - graveI - 1);
                    String weight = s.Substring(semiI + 1, s.Length - semiI - 1);*/
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

        public static void saveCommerceDataCSV(String filepath, Dictionary<String, City> CityData)
        {
            File.WriteAllLines(filepath, CityData.Select(kv => kv.Value.ToString()));
        }

        //I need a function that saves in the order of a checklist box - since you can't reorder a dictionary's keys - let the checklist box determine the saving order

        public static void saveCommerceDataCSVOrdered(String filepath, Dictionary<String, City> CityData, CheckedListBox orderList)
        {
            //We don't want to keep old data - overwrite the file
            using (StreamWriter sw = new StreamWriter(filepath, false))
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

        public static void saveTransportDataCSVOrdered(String filepath, Dictionary<String, Transport> TransportData, CheckedListBox orderList)
        {
            //We don't want to keep old data - overwrite the file
            using (StreamWriter sw = new StreamWriter(filepath, false))
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

        //Compresses the time statistics into an average so that we may load it into the graph
        public static Dictionary<String, TimeSpan> compressTimeData(Dictionary<String, List<TimeSpan>> TimeData)
        {
            Dictionary<String, TimeSpan> avgTime = new Dictionary<String, TimeSpan>();
            foreach(KeyValuePair<String,List<TimeSpan>> kvp in TimeData)
            {
                avgTime[kvp.Key] = new TimeSpan(kvp.Value.Sum(t => t.Ticks)/kvp.Value.Count);
            }
            return avgTime;
        }

        //A method for writing time data
        public static void saveTimeData(String filepath, Dictionary<String, List<TimeSpan>> TimeData)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool firstTime = true;
            foreach (KeyValuePair<String, List<TimeSpan>> kvp in TimeData)
            {
                //Basically - don't append a newline the first iteration
                if (!firstTime)
                {
                    stringBuilder.Append("\n");
                }
                firstTime = false;
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    stringBuilder.Append(kvp.Key);
                    stringBuilder.Append(MAIN_TEXT_SEPARATOR);
                    stringBuilder.Append(kvp.Value[i]);
                    //Avoid the extra new line at the end of the file
                    if (i != kvp.Value.Count - 1)
                    {
                        stringBuilder.Append("\n");
                    }
                }
            }
            File.WriteAllText(filepath, stringBuilder.ToString());
        }

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

        public static void saveTimeData(String filepath, Dictionary<String, Dictionary<String, List<TimeSpan>>> timeData)
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
        }

    }
    

}
