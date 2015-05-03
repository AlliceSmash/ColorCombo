using System.Collections.Generic;

namespace ColorCombination
{
    class DirectedGraph
    {
        //total number of vertices
        private int nVertex;
        //total number of edges of this directed graph
        private int nEdge;

        //the following visited, edgeTo are for finding a path, which is not necessary a complete path
        //visited = true when the vertex has been visited 
        private bool[] visited;
        private int[] edgeTo;
        private int startNode = 0;

        //adjacency list, each row r is a list of vertex that r can point to
        public List<int>[] adjacentList;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nvertices"></param>
        public DirectedGraph(int nvertices)
        {
            if (nvertices < 0)
            {
                System.Console.WriteLine(" Please input a positive number fornumber of vertex !");
            }

            nVertex = nvertices;
            adjacentList = new List<int>[nVertex];
            for (int i = 0; i < nVertex; i++)
            {
                adjacentList[i] = new List<int>();
            }
        }

        /// <summary>
        /// Add an edge from vertex (from) to vertex(to) by filling adjacentList
        /// Called by AddEdges
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        private void AddEdge(int from, int to)
        {
            if (from > nVertex || to > nVertex)
            {
                System.Console.WriteLine("Out of bounds when adding edges");
            }
            else
            {
                adjacentList[from].Add(to);
                nEdge++;
            }
        }
        
        /// <summary>
        /// Add edges for the entire graph
        /// </summary>
        /// <param name="chips"></param>
        public void AddEdges(List<MyChip> chips)
        {
            if (chips == null || chips.Count < nVertex)
                return;

            int i, j;
            //here, the last vertex  is the end chip
            //does not point to any other vertex
            for (i = 0; i < nVertex - 1; i++)
            {
                MyChip temp = chips[i];
                for (j = 0; j < nVertex; j++)
                {
                    if (j != i && temp.Right.Equals(chips[j].Left))
                    {
                            AddEdge(i, j);
                    }
                }
            }
        }

        /// <summary>
        /// Called by FindDirectedPath
        /// to find direct path from vertex v to end 
        /// Note:it does not have to use all vertices available
        /// </summary>
        /// <param name="v"></param>
        private void Finddirectpath(int v)
        {
            visited[v] = true;

            foreach (var node in adjacentList[v])
            {
                if (!visited[node])
                {
                    edgeTo[node] = v;
                    Finddirectpath(node);
                }
            }
        }

        /// <summary>
        /// Find a complete path, utilizing the adjacent list of each vertex
        /// </summary>
        /// <returns>a stack of vertex, each vertex is represented by an integer
        /// Top of the stack is the first vertex pointed from the startNode</returns>
        public Stack<int> FindCompletePath()
        {
            //initialize edgeTo, each vertex point to -1, meaning nothing to point to yet
            edgeTo = new int[nVertex];
            for (int t = 0; t < nVertex; t++)
            {
                edgeTo[t] = -1;
            }

            //keep track of what is left to sort
            List<int> listToOrder = new List<int>();
            for (int i = 1; i < nVertex; i++) listToOrder.Add(i);

            //start from the starting point
            FindCompletePath(startNode, listToOrder);

            return GetPath(nVertex - 1);
        }

        /// <summary>
        /// Find complete path from current to any vertex in listToOrder, and update path if necessary
        /// </summary>
        /// <param name="current"></param>
        /// <param name="listToOrder"></param>
        /// <param name="path"></param>
        private void FindCompletePath(int current, List<int> listToOrder)
        {
            foreach (var vertex in adjacentList[current])
            {
                //first check if the next chip is already used or not
                //if it is already used, do nothing, go to the next available chip
                //if it is still available, try to find a complete path starting from it.
                if (listToOrder.Contains(vertex))
                {
                    //current -> vertex
                    edgeTo[vertex] = current;
                    listToOrder.Remove(vertex);

                    if (CompletePathFound(vertex, listToOrder)) return;

                    //if no complete path found from vertex, move it back to the list 
                    listToOrder.Insert(0, vertex);

                    //did not work out, so nothing is point to vertex yet
                    edgeTo[vertex] = -1;
                }
            }
        }

        /// <summary>
        /// Check whether or not a complete path is found from next to the remaining of list
        /// update path if necessary
        /// </summary>
        /// <param name="next"></param>
        /// <param name="remaining"></param>
        /// <returns></returns>
        private bool CompletePathFound(int next, List<int> remaining)
        {
            FindCompletePath(next, remaining);
            return (remaining.Count == 0);
        }

        /// <summary>
        /// Test if vertex v can be linked from the start point
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private bool CanLinkTo(int v)
        {
            if (v > nVertex)
            {
                System.Console.WriteLine(" Out of bounds during CanLinkTo function");
            }

            //since the first vertex is always the start node, it is always true
            if (v == startNode) return true;

            if (edgeTo[v] >= 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Return a path  from start point to vertex v
        /// </summary>
        /// <param name="v"></param>
        /// <returns>Stack of integers</returns>
        public Stack<int> GetPath(int v)
        {
            if (!CanLinkTo(v)) return null;

            Stack<int> path = new Stack<int>();
            for (int x = v; x != startNode; )
            {
                path.Push(x);
                x = edgeTo[x];
            }

            return path;
        }
    }
}
