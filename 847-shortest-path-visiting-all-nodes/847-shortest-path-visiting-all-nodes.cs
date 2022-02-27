public class Solution {
    public int ShortestPathLength(int[][] graph) {
        if (graph.Length == 1)
                return 0;

        var length = graph.Length;
        var finalState = (1 << length) - 1;
        var queue = new Queue<(int, int)>();
        
        for (var i = 0; i < length; i++)
            queue.Enqueue((i, 1 << i));
        
        var visitedMap = new int[length, finalState + 1];
        var shortestPath = 0;
        
        while (queue.Count > 0)
        {
            var size = queue.Count;
            shortestPath++;
            
            for (var i = 0; i < size; i++)
            {
                var (nodeId, mask) = queue.Dequeue();
                
                foreach (var neighbor in graph[nodeId])
                {
                    var newMask = mask | (1 << neighbor);
                    
                    if (visitedMap[neighbor, newMask] == 1)
                        continue;
                    
                    if (newMask == finalState)
                        return shortestPath;
                    
                    visitedMap[neighbor, newMask] = 1;
                    queue.Enqueue((neighbor, newMask));
                }
            }
        }
        return -1;
    }
}