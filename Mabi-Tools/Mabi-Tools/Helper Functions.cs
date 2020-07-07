using System;
using System.Collections.Generic;
using System.IO;

namespace Mabi_Tools
{
    /*public static class CommerceDataLoader
    {
        private static readonly char MAIN_TEXT_SEPARATOR = '`';
        private static readonly char SECONDARY_TEXT_SEPARATOR = ';';
        public static void loadCommerceData(String citiesFile)
        {
            frmCommerce.CityData = new Dictionary<string, City>();
            try
            {
                //CityNames = File.ReadAllLines(citiesFile).ToList();
                String[] rawData = File.ReadAllLines(citiesFile);
                foreach (String s in rawData)
                {
                    //Separate the individual good strings and process
                    String[] goodStrings = s.Split(MAIN_TEXT_SEPARATOR);
                    Good[] cityGoods = convertStringArrayToGoods(goodStrings);
                    //Now add the data to the Dictionary
                    CityData[goodStrings[0]] = new City(goodStrings[0], cityGoods);
                }
            }
            catch (FileNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error while loading City data : \n" + ex.Message, "Error");
                this.Close();
            }
        }
        public static Good[] convertStringArrayToGoods(String[] input)
        {
            //Currently, I am operating under the assumption the first item in the string array is the city name - therefore I will skip over it
            Good[] returnArray = new Good[input.Length - 1];
            for (int i = 1; i < input.Length; i++)
            {
                //Split the strings further
                String[] goodSplit = input[i].Split(SECONDARY_TEXT_SEPARATOR);
                try
                {
                    //Add the new good to the array
                    returnArray[i - 1] = new Good(goodSplit[0], Int32.Parse(goodSplit[1]), Int32.Parse(goodSplit[2]));
                }
                catch (FormatException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error Processing Data For City '" + input[0] + " and Good '" + goodSplit[0] + "' : \n" + ex.Message, "Format Error");
                }
            }
            return returnArray;
        }
    }*/
}
