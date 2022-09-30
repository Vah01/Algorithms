Graph g = new Graph(4);

g.AddEdge(0, 1);
g.AddEdge(0, 2);
g.AddEdge(1, 2);
g.AddEdge(2, 0);
g.AddEdge(2, 3);
g.AddEdge(3, 3);

Console.Write("BFS starting from vertex 2: \n");

g.BFS(2);
class Graph
{
    private int _v;
    LinkedList<int>[] _adj;
    public Graph(int v)
    {
        _adj = new LinkedList<int>[v];
        for (int i = 0; i < _adj.Length; i++)
        {
            _adj[i] = new LinkedList<int>();
        }
        _v = v;
    }
    public void AddEdge(int v, int w)
    {
        _adj[v].AddLast(w);
    }
    public void BFS(int s)
    {
        bool[] visited = new bool[_v];

        for (int i = 0; i < _v; i++)
            visited[i] = false;

        LinkedList<int> Queue = new LinkedList<int>();
        visited[s] = true;
        Queue.AddLast(s);

        while (Queue.Any())
        {
            s = Queue.First();
            Console.Write(s + " ");
            Queue.RemoveFirst();
            LinkedList<int> list = _adj[s];

            foreach(var val in list)
            {
                if (visited[val] == false)
                {
                    visited[val] = true;
                    Queue.AddLast(val);
                }
            }
        }
    }
}