public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
        for(int i = 0; i <= n-1; i++){
            graph.Add(i, new List<int>());
        }
        
        foreach(int[] edge in edges){
            int from = edge[0];
            int to = edge[1];
            graph[from].Add(to);
            graph[to].Add(from);
        }
        
        /*
        foreach(var item in graph){
            Console.WriteLine("------------");
            Console.WriteLine("key" + item.Key);
            foreach(int num in item.Value){
                Console.WriteLine(num);
            }
        }
        */
        
        
        int[] visited = new int[n];
        if(!Helper(graph, 0, visited, -1))
            return false;
        foreach(int item in visited){
            if(item == 0)
                return false;
        }
        
        return true;
    }
    
    private bool Helper(Dictionary<int,List<int>> graph, int node, int[] visited, int parent){
        visited[node] = 1;
        //Console.WriteLine($"node: {node} and parent: {parent}");
        List<int> childs = graph[node];
        foreach(int child in childs){
            // Console.WriteLine($"child: {child}");
            if(child != parent && visited[child] == 1)
                return false;
            
            if(visited[child] == 0){
                bool result = Helper(graph, child, visited, node);
                if(!result)
                    return false;
            }
        }
        
        return true;
        
    }
}