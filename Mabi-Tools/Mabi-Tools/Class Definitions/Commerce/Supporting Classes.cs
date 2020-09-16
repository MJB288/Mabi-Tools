/*
 * This file will hold all of the custom class definitions needed for the Mabi-Tools project. May break the classes into separate smaller namespaces under the Mabi_Tools namespace if needed
 *  I don't think I need the mutators in the production code of the Commerce Tool, but to maintain personal consistency I put them in anyway
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Mabi_Tools.Classes
{
    [Serializable()]
    public class Transport
    {
        public String name { get; set; }
        public int slots { get; set; }
        public int weight { get; set; }

        //No need for a blank constructor
        public Transport(String name, int slots, int weight)
        {
            this.name = name;
            this.slots = slots;
            this.weight = weight;
        }

        override public String ToString()
        {
            return this.name + CommerceDataHandler.MAIN_TEXT_SEPARATOR + this.slots + CommerceDataHandler.MAIN_TEXT_SEPARATOR + this.weight;
        }
    }

    public class City 
    {
        public String name { get; set;  }
        public List<Good> goods { get; set; }
        
        public City(String name, List<Good> goods)
        {
            this.goods = goods;
            this.name = name;
        }

        //This constructor is for the city editor tool
        public City(String name)
        {
            this.name = name;
            goods = new List<Good>();
        }

        //This is primarily for saving to a file - not to be a default toString method
        override public String ToString()
        {
            StringBuilder CityString = new StringBuilder(this.name);
            foreach (Good good in goods)
            {
                CityString.Append(CommerceDataHandler.MAIN_TEXT_SEPARATOR + good.ToString());
            }
            return CityString.ToString() ;
        }

        
    }

    public class Good
    {
        public String name { get; set; }
        //Slot Capacity - How many of this item can fit into one slot on an object
        public int weight { get; set; }
        public int slotCapacity { get; set; }

        public Good(String name, int weight, int slotcapacity)
        {
            this.name = name;
            this.weight = weight;
            this.slotCapacity = slotcapacity;
        }

        override public String ToString()
        {
            return this.name + CommerceDataHandler.SECONDARY_TEXT_SEPARATOR + this.weight + CommerceDataHandler.SECONDARY_TEXT_SEPARATOR + this.slotCapacity;
        }

    }
}
