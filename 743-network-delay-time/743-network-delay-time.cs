public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        int[] costs = new int[n+1];
        for(int i = 1; i <= n; i++){
            costs[i] = int.MaxValue;
        }
        
        Dictionary<int,List<Node>> graph = new Dictionary<int,List<Node>>();
        for(int i = 0; i < times.Length; i++){
            int from = times[i][0], to = times[i][1], time = times[i][2];
            Node node = new Node(to, time);
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
        
        PriorityQueue<Node,Node> pq = new PriorityQueue<Node,Node>(Comparer<Node>.Create((x,y) => x.time.CompareTo(y.time)));
        Node firstNode = new Node(k, 0);
        pq.Enqueue(firstNode,firstNode);
        
        costs[k] = 0;
        
        while(pq.Count > 0){
            Node node = pq.Dequeue();
            List<Node> nodes = graph[node.tower];
            foreach(Node item in nodes){
                if(costs[node.tower] + item.time < costs[item.tower]){
                    costs[item.tower] = costs[node.tower] + item.time;
                    pq.Enqueue(item,item);
                }
            }
        }
        
        int maxCost = 0;
        for(int i = 1; i <= n; i++){
            if(costs[i] == int.MaxValue){
                return -1;
            }
            else if(costs[i] > maxCost){
                maxCost = costs[i];
            }
        }
        
        return maxCost;
    }
}

public class Node{
    public int tower;
    public int time;
    
    public Node(int _tower, int _time){
        this.tower = _tower;
        this.time = _time;
    }
}