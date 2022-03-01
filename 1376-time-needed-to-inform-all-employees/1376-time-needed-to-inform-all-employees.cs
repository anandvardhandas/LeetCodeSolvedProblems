public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        int len = manager.Length;
        Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
        
        for(int i = 0; i < len; i++){
            graph.Add(i, new List<int>());
        }
        
        for(int i = 0; i < len; i++){
            if(manager[i] == -1)
                continue;
            
            graph[manager[i]].Add(i);
        }
        
        
        return Helper(graph, informTime, headID);
    }
    
    private int Helper(Dictionary<int,List<int>> graph, int[] informTime, int emp){
        
        int maxtime = int.MinValue;
       List<int> subordinates = graph[emp];
        foreach(int subord in subordinates){
            maxtime = Math.Max(maxtime, Helper(graph, informTime, subord));
        }
        
        return maxtime == int.MinValue ? informTime[emp] : maxtime + informTime[emp];
    }
}