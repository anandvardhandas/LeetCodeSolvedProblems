public class Trie {
    private Node root;
    
    public Trie() {
        root = new Node();
    }
    
    public void Insert(string word) {
        Node curr = root;
        
        foreach(char c in word){
            if(curr.ContainsKey(c)){
                curr = curr.GetKey(c);
            }
            else{
                curr = curr.SetKey(c);
            }
        }
        
        curr.SetFlag();
    }
    
    public bool Search(string word) {
        Node curr = root;
        foreach(char c in word){
            if(curr.ContainsKey(c)){
                curr = curr.GetKey(c);
            }
            else{
                return false;
            }
        }
        
        return curr.GetFlag() == true;
    }
    
    public bool StartsWith(string prefix) {
        Node curr = root;
        foreach(char c in prefix){
            if(curr.ContainsKey(c)){
                curr = curr.GetKey(c);
            }
            else{
                return false;
            }
        }
        
        return curr != null;
    }
}

public class Node{
    Node[] nodes = new Node[26];
    bool flag = false;
    
    public bool ContainsKey(char c){
        return nodes[c-97] != null;
    }
    
    public Node SetKey(char c){
        nodes[c-97] = new Node();
        return nodes[c-97];
    }
    
    public Node GetKey(char c){
        return nodes[c-97];
    }
    
    public void SetFlag(){
        flag = true;
    }
    
    public bool GetFlag(){
        return flag;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */