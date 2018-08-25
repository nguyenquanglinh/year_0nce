using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToanDijkstra
{
    class Dijkstra
    {
        public Dijkstra() { }

        private static int khoangCachMin(int[] khoangCach, bool[] duongNganNhat, int dinh)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < dinh; ++v)
            
            {
                if (duongNganNhat[v] == false && khoangCach[v] <= min)
                {
                    min = khoangCach[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private static void Print(int[] distance, int verticesCount)
        {
            Console.WriteLine("Vertex    Distance from source");

            for (int i = 0; i < verticesCount; ++i)
                Console.WriteLine("{0}\t  {1}", i, distance[i]);
        }

        public static void DijkstraAlgo(int[,] graph, int dinhBatDau, int dinhDen)
        {
            int[] khoangCach = new int[dinhDen];
            bool[] duongNganNhat = new bool[dinhDen];

            for (int i = 0; i < dinhDen; ++i)
            {
                khoangCach[i] = int.MaxValue;
                duongNganNhat[i] = false;
            }

            khoangCach[dinhBatDau] = 0;

            for (int count = 0; count < dinhDen - 1; ++count)
            {
                int u = khoangCachMin(khoangCach, duongNganNhat, dinhDen);
                duongNganNhat[u] = true;

                for (int v = 0; v < dinhDen; ++v)
                    if (!duongNganNhat[v] && Convert.ToBoolean(graph[u, v]) && khoangCach[u] != int.MaxValue && khoangCach[u] + graph[u, v] < khoangCach[v])
                        khoangCach[v] = khoangCach[u] + graph[u, v];
            }

            Print(khoangCach, dinhDen);
        }


        class Program
        {
            static void Main(string[] args)
            {
                var s = new Dijkstra();
                int[,] graph = new int[,]  {
                         { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
                         { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
                         { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
                         { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
                         { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                         { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
                         { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
                         { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
                         { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
                            };

                DijkstraAlgo(graph, 0, 9);
            }
        }
    }
}