using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mabi_Tools
{
    public class Vertex
    {
        public String name { get; }
        public List<Edge> Edges { get; }

        public Vertex(String name)
        {
            this.name = name;
            Edges = new List<Edge>();
        }



    }

    public class Edge
    {
        //Keep a name incase I want to do the filter route feature
        public String name { get;  }

        public String Source { get; }

        public String Destination { get; }

        public TimeSpan averageTimeSpan { get; }

        //Keep a refrence to the Vertices
        public Edge(String name, String source, String destination, TimeSpan averageTime)
        {
            this.name = name;
            Source = source;
            Destination = destination;
            averageTimeSpan = averageTime;
        }
    }

    public class Graph 
    {
        public Dictionary<String, Vertex> Vertices { get; }

        public Graph()
        {
            Vertices = new Dictionary<String, Vertex>();
        }

        //Add an edge object, while constructing any unassigned Vertex objects
        public void addEdgeC(Edge newEdge)
        {
            if(newEdge == null)
            {
                return;
            }

            //First check that both Vertices exist
            if (Vertices[newEdge.Source] == null)
            {
                Vertices[newEdge.Source] = new Vertex(newEdge.Source);
            }
            if (Vertices[newEdge.Destination] == null)
            {
                Vertices[newEdge.Destination] = new Vertex(newEdge.Source);
            }
            //Now add the edge and reverse Edge
            Vertices[newEdge.Source].Edges.Add(newEdge);
            Vertices[newEdge.Destination].Edges.Add(new Edge(newEdge.name, newEdge.Destination, newEdge.Source, newEdge.averageTimeSpan));

            
        }

        //This method will initiate Dijkstra's algorithm which has been implemented in recursive form
        //Also we are concerned about all destinations - therefore this algorithm will not require a destination
        public void startDijkstra(String Source)
        {
            //A dictionary to keep track of what vertices have been visited
            Dictionary<String, bool> vVisited = new Dictionary<String, bool>();
            //And then a dictionary to track which vertex was used to reach this one
            Dictionary<String, String> prevVertex = new Dictionary<String, string>();
            Dictionary<String, TimeSpan> shortestDistance = new Dictionary<String, TimeSpan>();
            foreach (String Vertex in Vertices.Keys)
            {
                vVisited[Vertex] = false;
                //I will use a random number in string form for error checking
                prevVertex[Vertex] = "2567821279";
                shortestDistance[Vertex] = new TimeSpan(Int32.MaxValue, Int32.MaxValue, Int32.MaxValue);
            }
            shortestDistance[Source] = new TimeSpan(0, 0, 0);
            Dijkstra(Vertices[Source], vVisited, prevVertex, shortestDistance);

        }

        private void Dijkstra(Vertex cur, Dictionary<String, bool> vVisited, Dictionary<String, String> prevVertex, Dictionary<String, TimeSpan> ShortestDistance)
        {
            vVisited[cur.name] = true;
            foreach(Edge edge in cur.Edges)
            {
                //If neighbor not visited - see if we can update the table
                if (!vVisited[edge.Destination])
                {
                    //Check the distance
                    if(ShortestDistance[cur.name] + edge.averageTimeSpan < ShortestDistance[edge.Destination])
                    {
                        ShortestDistance[edge.Destination] = ShortestDistance[cur.name] + edge.averageTimeSpan;
                        prevVertex[edge.Destination] = cur.name;
                    }
                }
            }

            TimeSpan shortestTime = new TimeSpan(Int32.MaxValue, Int32.MaxValue, Int32.MaxValue);
            String nextDest = "|-1|||||";
            //Now check what the next shortest distance is
            foreach(String vertex in Vertices.Keys)
            {
                if(ShortestDistance[vertex] < shortestTime && !vVisited[vertex])
                {
                    shortestTime = ShortestDistance[vertex];
                    nextDest = vertex;
                }
            }

            //If there are no new destinations - this will trigger and break the recursion
            if (nextDest.Equals("|-1|||||"))
            {
                return;
            }
        }

        public void constructGraphCommerce(String filename)
        {
            //String[] rawLines = File.ReadAllLines(filename);
            //foreach(String s in )
        }

    }


}
