public class Solution {
    public bool IsBipartite(int[][] graph) {
        int n = graph.Length;
        int[] visited = new int[n];
        
        for(int i = 0; i < n; i++){
            if(visited[i] == 0){
                bool result = CheckBiPartite(graph, i, visited, n);
                if(!result)
                    return false;
            }
        }
        
        return true;
        
    }
    
    private bool CheckBiPartite(int[][] graph, int node, int[] visited, int id){
        int n = graph.Length;
        visited[node] = id;
        int[] neighbors = graph[node];
        foreach(int neigh in neighbors){
            if(visited[neigh] == id){
                return false;
            }
            
            if(visited[neigh] == 0){
                int otherid = -1;
                if(id == n+1){
                    otherid = n;
                }
                else{
                    otherid = n+1;
                }
                
                bool result = CheckBiPartite(graph, neigh, visited, otherid);
                if(!result)
                    return false;
            }
        }
        
        return true;
    }
}
