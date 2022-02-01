public class Solution {
    public int EarliestAcq(int[][] logs, int n) {
        DisJointSet ds = new DisJointSet(n);
        
        for(int i = 0; i < n; i++){
            ds.MakeSet(i);
        }
        
        Array.Sort(logs, (x,y) => x[0].CompareTo(y[0]));
        
        for(int i = 0; i < logs.Length; i++){
            ds.Union(logs[i][1], logs[i][2]);
            if(ds.GetTotalSet() == 1)
                return logs[i][0];
        }
        
        return -1;
    }
}

public class DisJointSet{
    private Dictionary<int,Node> map;
    private int totalSet;
    public DisJointSet(int _totalSet){
        this.map = new Dictionary<int,Node>();
        this.totalSet = _totalSet;
    }
    
    public void MakeSet(int _data){
        if(!map.ContainsKey(_data)){
            Node node = new Node();
            node.data = _data;
            node.rank = 0;
            node.parent = node;
            this.map.Add(_data, node);
        }
    }
    
    public Node FindSet(int data){
        return this.FindSet(map[data]);
    }
    
    public Node FindSet(Node node){
        if(node.parent == node)
            return node;
        node.parent = FindSet(node.parent);
        return node.parent;
    }
    
    public void Union(int data1, int data2){
        Node node1 = map[data1];
        Node node2 = map[data2];
        Node parent1 = FindSet(node1);
        Node parent2 = FindSet(node2);
        if(parent1 == parent2)
            return;
        
        if(parent1.rank >= parent2.rank){
            if(parent1.rank == parent2.rank){
                parent1.rank++;
            }
            
            parent2.parent = parent1;
        }
        else{
            parent1.parent = parent2;
        }
        
        this.totalSet--;
    }
    
    public int GetTotalSet(){
        return this.totalSet;
    }
}

public class Node{
    public int data;
    public int rank;
    public Node parent;
}