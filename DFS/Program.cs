using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        Graph g = new Graph(7); // Создаем граф с 7 вершинами

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 5);
        g.AddEdge(2, 6);

        Console.WriteLine("Результат DFS:");
        g.DFS();
        Console.ReadKey();
        
    }
}
class Graph
{
    private int V; // Количество вершин
    private List<int>[] adj; // Список смежности

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    // Рекурсивная функция для поиска в глубину
    private void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");

        foreach (int i in adj[v])
        {
            if (!visited[i])
            {
                DFSUtil(i, visited);
            }
        }
    }

    // Обертка для DFS, вызываемой из программы
    public void DFS()
    {
        bool[] visited = new bool[V];

        for (int i = 0; i < V; ++i)
        {
            if (!visited[i])
            {
                DFSUtil(i, visited);
            }
        }
    }
}

