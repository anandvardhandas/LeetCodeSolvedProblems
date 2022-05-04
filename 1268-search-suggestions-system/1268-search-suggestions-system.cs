public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Node root = BuildTrie(products);
        IList<IList<string>> result = new List<IList<string>>();
        
        for(int i = 0; i < searchWord.Length; i++){
            List<string> res = FindWordsWithPrefix(root, searchWord.Substring(0,i+1));
            result.Add(res);
        }
        
        return result;
    }
    
    private List<string> FindWordsWithPrefix(Node root, string prefix){
        //Console.WriteLine($"started searching for {prefix}");
        List<string> result = new List<string>();
        Node curr = root;
        foreach(char c in prefix){
            if(curr.children[c-'a'] == null){
                return result;
            }
            else{
                curr = curr.children[c-'a'];
            }
        }
        
        DFS(curr, result, prefix);
        return result;
    }
    
    private void DFS(Node root, List<string> result, string prefix){
        Node curr = root;
        if(result.Count >= 3){
            return;
        }
        
        if(curr.isword){
            result.Add(prefix);
        }
        
        for(char c = 'a'; c <= 'z'; c++){
            if(curr.children[c-'a'] != null){
                DFS(curr.children[c-'a'], result, prefix+c);
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
        isword = false;
        children = new Node[26];
    }
}