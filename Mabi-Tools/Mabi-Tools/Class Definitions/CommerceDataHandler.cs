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
        public static readonly char MAIN_TEXT_SEPARATOR = '`';
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
                    String[] split = s.Split('`');
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

    }
    

}
