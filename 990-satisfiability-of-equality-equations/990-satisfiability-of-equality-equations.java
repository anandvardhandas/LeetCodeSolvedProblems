public class Solution {
    public bool EquationsPossible(string[] equations) {
        DisjointSet ds = new DisjointSet();
        foreach(string str in equations){
            ds.MakeSet(str[0]);
            ds.MakeSet(str[3]);
            
            if(str[1] == '='){
                ds.Union(str[0], str[3]);
            }
        }
        
        foreach(string str in equations){
            if(str[1] == '=' && ds.FindSet(str[0]) != ds.FindSet(str[3])){
                return false;
            }
            if(str[1] == '!' && ds.FindSet(str[0]) == ds.FindSet(str[3])){
                return false;
            }
        }
        
        return true;
    }
}

public class DisjointSet{
    Dictionary<char, Node> map;
    
    public DisjointSet(){
        map = new Dictionary<char, Node>();
    }
    
    public void MakeSet(char c){
        Node node = new Node();
        node.value = c;
        node.rank = 0;
        node.parent = node;
        if(!map.ContainsKey(c))
            map.Add(c, node);
    }
    
    public Node FindSet(char c){
        return FindSet(map[c]);
    }
    
    public Node FindSet(Node node){
        if(node.parent == node)
            return node;
        
        node.parent = FindSet(node.parent);
        return node.parent;
    }
    
    public void Union(char c1, char c2){
        Node node1 = map[c1];
        Node node2 = map[c2];
        Node parent1 = FindSet(node1);
        Node parent2 = FindSet(node2);
        
        if(parent1.rank >= parent2.rank){
            if(parent1.rank == parent2.rank)
                parent1.rank++;
            
            parent2.parent = parent1;
        }
        else{
            parent1.parent = parent2;
        }
    }
    
    
}

public class Node{
    public char value;
    public Node parent;
    public int rank;
}