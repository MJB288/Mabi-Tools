/*
 * This file will hold all of the custom class definitions needed for the Mabi-Tools project. May break the classes into separate smaller namespaces under the Mabi_Tools namespace if needed
 *  I don't think I need the mutators in the production code of the Commerce Tool, but to maintain personal consistency I put them in anyway
 */
using System;



namespace Mabi_Tools 
{
    public class Transport
    {
        private String name;
        private int slots, weight;
        //No need for a blank constructor
        public Transport(String name, int slots, int weight)
        {
            this.name = name;
            this.slots = slots;
            this.weight = weight;
        }

        //Accessors

        public String getName()
        {
            return name;
        }

        public int getSlots()
        {
            return slots;
        }

        public int getWeight()
        {
            return weight;
        }

        //Mutators

        public void setName(String newName)
        {
            name = newName;
        }

        public void setSlots(int newSlots)
        {
            slots = newSlots;
        }

        public void setWeight(int newWeight)
        {
            weight = newWeight;
        }
    }

    public class City
    {
        private String name;
        private Good[] goods;
        
        public City(String name, Good[]goods)
        {
            this.goods = new Good[goods.Length];
            this.name = name;
            goods.CopyTo(this.goods,0);
        }

        //Accessors

        public String getName()
        {
            return name;
        }

        public Good[] getGoods()
        {
            return goods;
        }

        //Mutators

        public void setName(String newName)
        {
            name = newName;
        }

        //Assumes array is of same length or less
        public void setGoods(Good[] newGoods)
        {
            newGoods.CopyTo(goods, 0);
        }

        public void setSpecificGood(Good newGood, int index)
        {
            goods[index] = newGood;
        }
    }

    public class Good
    {
        private String name;
        //Slot Capacity - How many of this item can fit into one slot on an object
        private int weight, slotCapacity;

        public Good(String name, int weight, int slotcapacity)
        {
            this.name = name;
            this.weight = weight;
            this.slotCapacity = slotcapacity;
        }

        //Accessors
        public String getName()
        {
            return name;
        }

        public int getWeight()
        {
            return weight;
        }

        public int getSlotCapacity()
        {
            return slotCapacity;
        }

        //Mutators
        public void setName(String newName)
        {
            name = newName;
        }

        public void setWeight(int newWeight)
        {
            weight = newWeight;
        }

        public void setSlotCapacity(int newSlotCapacity)
        {
            slotCapacity = newSlotCapacity;
        }
    }
}
