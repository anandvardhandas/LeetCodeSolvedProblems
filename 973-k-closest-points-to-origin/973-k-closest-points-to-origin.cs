public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<Node,Node> pq = 
            new PriorityQueue<Node,Node>(k, 
        Comparer<Node>.Create((x,y) => y.dist.CompareTo(x.dist)));
        
        foreach(int[] item in points){
            Node node = new Node(item[0],item[1]);
            if(pq.Count < k){
                pq.Enqueue(node,node);
            }
            else{
                Node peeked = pq.Peek();
                if(node.dist < peeked.dist){
                    pq.Dequeue();
                    pq.Enqueue(node,node);
                }
            }
        }
        
        List<int[]> result = new List<int[]>();
        while(pq.Count > 0){
            Node n = pq.Dequeue();
            result.Add(new int[] { n.x, n.y });
        }
        
        return result.ToArray();
    }
    
}

public class Node{
    public int x;
    public int y;
    public double dist;
    public Node(int _x, int _y){
        x = _x;
        y = _y;
        
        dist = Math.Sqrt(x*x + y*y);
    }
}