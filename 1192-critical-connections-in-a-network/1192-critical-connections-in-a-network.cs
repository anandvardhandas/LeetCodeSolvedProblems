public class Solution {
    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections) {
        IList<IList<int>> result = new List<IList<int>>();
        
        Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
        foreach(IList<int> conn in connections){
            int from = conn[0], to = conn[1];
            if(graph.ContainsKey(from)){
                graph[from].Add(to);
            }
            else{
                graph.Add(from, new List<int>() { to });
            }
            
            if(graph.ContainsKey(to)){
                graph[to].Add(from);
            }
            else{
                graph.Add(to, new List<int>() { from });
            }
        }
        
        
        int[] low = new int[n];
        int[] timeinsert = new int[n];
        int[] visited = new int[n];
        
        for(int i = 0; i < n; i++){
            if(visited[i] == 0){
                Helper(graph, i, -1, 0, timeinsert, low, visited, result);
            }
        }
        
        
        return result;
    }
    
    
    private void Helper(Dictionary<int,List<int>> graph, int node, int parent, int timer, int[] timeinsert, int[] low, int[] visited, 
                        IList<IList<int>> result){
        
        visited[node] = 1;
        low[node] = timer;
        timeinsert[node] = timer;
        timer++;
        
        List<int> childs = graph[node];
        foreach(int child in childs){
            if(child == parent)
                continue;
            
            if(visited[child] == 0){
                Helper(graph, child, node, timer, timeinsert, low, visited, result);
                low[node] = Math.Min(low[node], low[child]);
                
                if(low[child] > timeinsert[node]){
                    //bridge
                    result.Add(new List<int>() { node, child });
                }
            }
            else{
                low[node] = Math.Min(low[node], low[child]);
            }
        }
    }
    
}