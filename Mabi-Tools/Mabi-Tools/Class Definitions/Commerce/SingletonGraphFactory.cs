﻿using Mabi_Tools.Forms.Commerce_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabi_Tools.Classes
{
    /// <summary>
    /// An object that follows the Singleton and Fsactory design patterns. Is Designed to construct graphs and save parameters
    /// specifically for Graph construction and no other purpose
    /// </summary>
    class SingletonGraphFactory
    {
        private static SingletonGraphFactory instance = new SingletonGraphFactory();
        public TimeSpan BelvastBoatTime { get; set; }

        private SingletonGraphFactory()
        {
            BelvastBoatTime = new TimeSpan(0, 2, 15);
        }

        private SingletonGraphFactory(TimeSpan belvastBoatTime)
        {
            BelvastBoatTime = belvastBoatTime;
        }

        public static SingletonGraphFactory getFactory()
        {
            return instance;
        }

        public Graph constructGraph(Dictionary<String, TimeSpan> averageTime)
        {
            Graph commerceGraph = new Graph();
            //String[] rawLines = File.ReadAllLines(filename);
            //foreach(String s in )
            foreach (KeyValuePair<String, TimeSpan> kvp in averageTime)
            {
                String[] splitKey = kvp.Key.Split(CommerceDataHandler.MAIN_TEXT_SEPARATOR);
                TimeSpan timeValue = kvp.Value;
                //The key Should be source then destination then name
                //Initialize check for the belvast addition
                if (splitKey[2].Equals("Boat") && (splitKey[0].Equals("Belvast") || splitKey[1].Equals("Belvast")))
                {
                    timeValue += BelvastBoatTime;
                }
                Edge newEdge = new Edge(splitKey[2], splitKey[0], splitKey[1], timeValue);
                commerceGraph.addEdgeC(newEdge);
            }
            return commerceGraph;
        }
    }
}
