namespace Algorithm_Graph
{
    class Graph1
    {
        static void AddEdge(LinkedList<int>[] arr, int U, int V)
        {
            arr[U].AddLast(V);
            arr[V].AddLast(U);
        }
        static void PrintGraph(LinkedList<int>[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\nArray list of vertex" + i);
                Console.Write("Head");
                foreach (int item in arr[i])
                {
                    Console.Write("->" + item);
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            int V = 5;
            LinkedList<int>[] arr = new LinkedList<int>[V];
            for (int i = 0; i < V; i++)
            {
                arr[i] = new LinkedList<int>();
            }
            AddEdge(arr, 0, 1);
            AddEdge(arr, 0, 4);
            AddEdge(arr, 1, 2);
            AddEdge(arr, 1, 3);
            AddEdge(arr, 1, 4);
            AddEdge(arr, 2, 3);
            AddEdge(arr, 3, 4);
            PrintGraph(arr);
            Console.ReadKey();
        }
    }
}