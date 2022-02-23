/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null)
            return null;
        
        Dictionary<Node,Node> visited = new Dictionary<Node,Node>();
        return Helper(node, visited);
    }
    
    
    private Node Helper(Node node, Dictionary<Node,Node> visited){
        if(visited.ContainsKey(node)){
            return visited[node];
        }
        
        Node node2 = new Node(node.val);
        node2.neighbors = new List<Node>();
        
        visited.Add(node, node2);
        
        foreach(Node n in node.neighbors){
            node2.neighbors.Add(Helper(n, visited));
        }
        
        return node2;
    }
    
    
}