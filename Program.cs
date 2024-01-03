using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Short_Path_Dj
{

    
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            GraphicsNode.activeForm = mainForm;
            Application.Run(mainForm);


            //    //MinHeap<int> minHeap = new MinHeap<int>();
            //    //minHeap.Add(5);
            //    //minHeap.Add(10);
            //    //minHeap.Add(4);
            //    //minHeap.Add(3);

            //    //Console.WriteLine(minHeap.GetMin());
            //    //Console.WriteLine(minHeap.GetMin());
            //    //Console.WriteLine(minHeap.GetMin());
            //    //Console.WriteLine(minHeap.GetMin());
            //    //Console.WriteLine(minHeap.GetMin());

            //    //MinHeap<Sameh> s = new MinHeap<Sameh>();
            //    //s.Add(new Sameh(5, 'a'));
            //    //s.Add(new Sameh(10, 'u'));
            //    //s.Add(new Sameh(4, 'y'));
            //    //s.Add(new Sameh(3, 'l'));
            //    int nodes = 10;
            //    //Dijkstra graph = new Dijkstra(nodes);


            //    graph.adjList[0].Add((1, 7));
            //    graph.adjList[0].Add((2, 9));
            //    graph.adjList[0].Add((5, 14));
            //    graph.adjList[1].Add((0, 7));
            //    graph.adjList[1].Add((2, 10));
            //    graph.adjList[1].Add((3, 15));
            //    graph.adjList[2].Add((0, 9));
            //    graph.adjList[2].Add((1, 10));
            //    graph.adjList[2].Add((3, 11));
            //    graph.adjList[2].Add((5, 2));
            //    graph.adjList[3].Add((1, 15));
            //    graph.adjList[3].Add((2, 11));
            //    graph.adjList[3].Add((4, 6));
            //    graph.adjList[4].Add((3, 6));
            //    graph.adjList[4].Add((5, 9));
            //    graph.adjList[5].Add((0, 14));
            //    graph.adjList[5].Add((2, 2));
            //    graph.adjList[5].Add((4, 9));




            //    int TargetNode = 0;
            //    int[] distances = graph.DijkstraAlgo(TargetNode);

            //    Console.WriteLine("Distances from source node:");

            //    for (int i = 0; i < nodes; i++)
            //    {
            //        Console.WriteLine($"Node {TargetNode} to Node {i}: {distances[i]}");
            //    }


        }
    }
}
