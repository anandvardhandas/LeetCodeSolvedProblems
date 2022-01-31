public class Trie {
    
    public Node root;
    public Trie() {
        root = new Node();
    }
    
    public void Insert(string word) {
        Node curr = root;
        foreach(char c in word){
            Node item = curr.GetCharNode(c);
            if(item == null){
                curr = curr.SetCharNode(c);
            }
            else{
                curr = item;
            }
        }
        
        curr.SetFlag(true);
    }
    
    public bool Search(string word) {
        Node curr = root;
        foreach(char c in word){
            Node item = curr.GetCharNode(c);
            if(item == null){
                return false;
            }
            else{
                curr = item;
            }
        }
        
        if(curr.Getflag())
            return true;
        
        return false;
    }
    
    public bool StartsWith(string prefix) {
        Node curr = root;
        foreach(char c in prefix){
            Node item = curr.GetCharNode(c);
            if(item == null){
                return false;
            }
            else{
                curr = item;
            }
        }
        
        return true;
    }
}

public class Node{
    
    public Node[] map;
    public bool EndFlag;
    
    public Node(){
        map = new Node[26];
    }
    
    public void SetFlag(bool value){
        this.EndFlag = value;
    }
    
    public bool Getflag(){
        return this.EndFlag;
    }
    
    public Node GetCharNode(char c){
        return this.map[c-97];
    }
    
    public Node SetCharNode(char c){
        this.map[c-97] = new Node();
        return this.map[c-97];
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */