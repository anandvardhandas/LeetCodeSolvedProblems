public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        int[] dists = new int[n+1];
        for(int i = 1; i <= n; i++){
            dists[i] = int.MaxValue;
        }
        
        Dictionary<int,List<Node>> graph = new Dictionary<int,List<Node>>();
        for(int i = 0; i < times.Length; i++){
            int from = times[i][0], to = times[i][1], dist = times[i][2];
            Node node = new Node(to, dist);
            if(graph.ContainsKey(from)){
                graph[from].Add(node);
            }
            else{
                graph.Add(from, new List<Node>() { node });
            }
            
            if(!graph.ContainsKey(to)){
                graph.Add(to, new List<Node>());
            }
        }
        
        PriorityQueue<Node,Node> pq = new PriorityQueue<Node,Node>(Comparer<Node>.Create((x,y) => x.dist.CompareTo(y.dist)));
        Node firstNode = new Node(k, 0);
        pq.Enqueue(firstNode,firstNode);
        
        dists[k] = 0;
        
        while(pq.Count > 0){
            Node node = pq.Dequeue();
            List<Node> nodes = graph[node.tower];
            foreach(Node item in nodes){
                if(dists[node.tower] + item.dist < dists[item.tower]){
                    dists[item.tower] = dists[node.tower] + item.dist;
                    pq.Enqueue(item,item);
                }
            }
        }
        
        int max = 0;
        for(int i = 1; i <= n; i++){
            if(dists[i] == int.MaxValue){
                return -1;
            }
            else if(dists[i] > max){
                max = dists[i];
            }
        }
        
        return max;
        
    }
}

public class Node{
    public int tower;
    public int dist;
    
    public Node(int _tower, int _dist){
        this.tower = _tower;
        this.dist = _dist;
    }
}