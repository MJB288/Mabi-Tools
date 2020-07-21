using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabi_Tools
{
    class SingletonGraphFactory
    {
        private static SingletonGraphFactory instance = new SingletonGraphFactory();

        private SingletonGraphFactory()
        {

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
                //The key Should be source then destination then name
                Edge newEdge = new Edge(splitKey[2], splitKey[0], splitKey[1], kvp.Value);
                commerceGraph.addEdgeC(newEdge);
            }
            return commerceGraph;
        }
    }
}
