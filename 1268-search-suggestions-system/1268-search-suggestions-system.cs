public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        IList<IList<string>> result = new List<IList<string>>();
        //build trie
        Node root = BuildTrie(products);
        
        //search
        for(int i = 0; i < searchWord.Length; i++){
            result.Add(SearchWord(root, searchWord.Substring(0,i+1)));
        }
        
        return result;
    }
    
    private List<string> SearchWord(Node root, string word){
        List<string> result = new List<string>();
        Node curr = root;
        foreach(char c in word){
            if(curr.children[c-'a'] == null){
                return result;
            }
            else{
                curr = curr.children[c-'a'];
            }
        }
        
        DFS(curr, word, result);
        return result;
    }
    
    private void DFS(Node root, string word, List<string> result){
        if(result.Count == 3){
            return;
        }
        
        if(root.isword){
            result.Add(word);
        }
        
        for(char c = 'a'; c <= 'z'; c++){
            if(root.children[c-'a'] != null){
                DFS(root.children[c-'a'], word+c, result);
            }
        }
    }
    
    private Node BuildTrie(string[] products){
        Node root = new Node();
        
        foreach(string product in products){
            Node curr = root;
            foreach(char c in product){
                if(curr.children[c-'a'] == null){
                    curr.children[c-'a'] = new Node();
                    curr = curr.children[c-'a'];
                }
                else{
                    curr = curr.children[c-'a'];
                }
            }
            
            curr.isword = true;
        }
        
        return root;
    }
}

public class Node{
    public bool isword;
    public Node[] children;
    public Node(){
        children = new Node[26];
    }
}