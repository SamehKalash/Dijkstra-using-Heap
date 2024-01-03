using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Path_Dj
{
     class Dijkstra
    {
        int nodes;
        public List<(int,int)>[] adjList;
        public Dijkstra(List<(int,int)>[] input)
        {
            this.nodes = input.Length;
            adjList = input;
            //adjList = new List<(int,int)>[nodes];
            //for (int i = 0; i < nodes; i++)
            //{
            //    adjList[i] = new List<(int,int)>();
            //}
        }
        public int[] DijkstraAlgo(int TargetNode) 
        {
            int[] distance = new int[nodes];
            for (int i = 0; i < nodes; i++)
                distance[i] = int.MaxValue;

            distance[TargetNode] = 0;

            MinHeap<(int, int)> minHeap = new MinHeap<(int, int)>();
            minHeap.Add((0,TargetNode));

            while (minHeap.Size > 0)
            {
                (int dist, int node) = minHeap.GetMin();

                foreach ((int, int) edge in adjList[node])
                {
                    int newDist = distance[node] + edge.Item2;

                    if (newDist < distance[edge.Item1])
                    {
                        distance[edge.Item1] = newDist;
                        minHeap.Add((newDist, edge.Item1));
                    }
                }
            }
            return distance;
        }

    }
}
