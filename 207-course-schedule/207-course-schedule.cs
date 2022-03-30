public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int len = prerequisites.Length;
        
        Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
        for(int i = 0; i < len; i++){
            if(graph.ContainsKey(prerequisites[i][0])){
                graph[prerequisites[i][0]].Add(prerequisites[i][1]);
            }
            else{
                graph.Add(prerequisites[i][0], new List<int>() { prerequisites[i][1] });
            }
            
            if(!graph.ContainsKey(prerequisites[i][1])){
                graph.Add(prerequisites[i][1], new List<int>());
            }
        }
        
        
        int[] visited = new int[numCourses];
        
        foreach(var item in graph){
            int node = item.Key;
            if(visited[node] == 0){
                int[] dfsvisited = new int[numCourses];
                if(Helper(graph, visited, dfsvisited, node)){
                    return false;
                }
            }
        }
        
        return true;
    }
    
    
    private bool Helper(Dictionary<int,List<int>> graph, int[] visited, int[] dfsvisited, int node){
        visited[node] = 1;
        dfsvisited[node] = 1;
        
        List<int> neighb = graph[node];
        foreach(int n in neighb){
            if(visited[n] == 1 && dfsvisited[n] == 1)
                return true;
            if(visited[n] == 0){
                bool IsCircle = Helper(graph, visited, dfsvisited, n);
                if(IsCircle)
                    return true;
            }
        }
        
        dfsvisited[node] = 0;
        return false;
    }
}