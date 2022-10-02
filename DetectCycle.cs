
class Graph
{
    private readonly int V;
    private readonly List<List<int>> adj;
    public Graph(int V)
    {
        this.V = V;
        adj = new List<List<int>>(V);
        for (int i = 0; i < V; i++)
        {
            adj.Add(new List<int>());
        }
    }
    private bool IsCycle(int i, bool[] visited,bool[] recstack)
    {
        if (recstack[i])
            return true;
        if (visited[i])
            return false;
        visited[i] = true;
        recstack[i] = true;
        List<int> Children = adj[i];
        foreach (var C in Children)
            if (IsCycle(C, visited, recstack))
                return true;
        recstack[i] = false;
        return false;
    }
    private void AddEdge(int sou,int dest)
    {
        adj[sou].Add(dest);
    }
    private bool IsCyclic()
    {
        bool[]visited = new bool[V];
        bool[] recstack = new bool[V];
        for (int i = 0; i < V; i++)
            if (IsCycle(i, visited, recstack))
                return true;
        return false;
    }
    public static void Main(string[] args)
    {
        Graph graph = new Graph(4);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 0);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 3);
        if (graph.IsCyclic())
            Console.WriteLine("Graph Contains Cycle");
        else
            Console.WriteLine("Graph Doesnt Contains Cycle");
    }
}
