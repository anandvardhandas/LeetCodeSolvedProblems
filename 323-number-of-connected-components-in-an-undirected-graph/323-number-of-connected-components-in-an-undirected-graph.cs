public class Solution {
    public int CountComponents(int n, int[][] edges) {
        Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
        
        for(int i = 0; i < n; i++){
            graph.Add(i, new List<int>());
        }
        
        for(int i = 0; i < edges.Length; i++){
            int from = edges[i][0];
            int to = edges[i][1];
            graph[from].Add(to);
            graph[to].Add(from);
        }
        
        int[] visited = new int[n];
        
        int result = 0;
        
        for(int i = 0; i < n; i++){
            if(graph.ContainsKey(i)){
                if(visited[i] == 0){
                    result++;
                    Helper(graph, i, visited, -1);
                }
            }
        }
        
        return result;
    }
    
    private void Helper(Dictionary<int,List<int>> graph, int node, int[] visited, int parent){
        visited[node] = 1;
        
        List<int> childs = graph[node];
        foreach(int child in childs){
            if(child != parent && visited[child] == 0){
                Helper(graph, child, visited, node);
            }
        }
    }
}