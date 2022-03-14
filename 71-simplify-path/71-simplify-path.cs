public class Solution {
    public string SimplifyPath(string path) {
        StringBuilder orig = new StringBuilder();
        orig.Append("/");
        for(int i = 1; i < path.Length; i++){
            if((path[i] == '/' && path[i-1] == '/')){
                continue;
            }
            
            orig.Append(path[i].ToString());
        }
        
        path = orig.ToString();
        
        string[] folders = path.Split('/');
        
        StringBuilder result = new StringBuilder();
        
        Stack<string> st = new Stack<string>();
        
        foreach(string fold in folders){
            if(fold == "." || fold == "")
                continue;
            else if(fold == ".."){
                if(st.Count > 0){
                    st.Pop();
                }
            }
            else{
                st.Push(fold);
            }
        }
        
       
        
        Stack<string> reversed = new Stack<string>();
        while(st.Count > 0){
            reversed.Push(st.Pop());
        }
        
        while(reversed.Count > 0){
            result.Append("/");
            result.Append(reversed.Pop());
        }
        
        if(result.ToString() == "")
            result.Append("/");
        
        return result.ToString();
    }
}