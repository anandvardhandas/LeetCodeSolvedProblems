public class Solution {
    public string SimplifyPath(string path) {
        int len = path.Length;
        //replace multiple slashes with single slash
        StringBuilder sb = new StringBuilder();
        sb.Append("/");
        for(int i = 1; i < len; i++){
            if(path[i] == '/' && path[i-1] == '/')
                continue;
            else{
                sb.Append(path[i].ToString());
            }
        }
        
        //Console.WriteLine(sb.ToString());
        
        path = sb.ToString();
        string[] paths = path.Split('/');
        Stack<string> st = new Stack<string>();
        
        for(int i = 0; i < paths.Length; i++){
            if(paths[i] == "." || paths[i] == ""){
                continue;
            }
            else if(paths[i] == ".."){
                if(st.Count > 0)
                    st.Pop();
            }
            else{
                st.Push(paths[i]);
            }
        }
        
        
        StringBuilder sbres = new StringBuilder();
        Stack<string> st2 = new Stack<string>();
        while(st.Count > 0){
            st2.Push(st.Pop());
        }
        
        if(st2.Count == 0)
            return "/";
        
        while(st2.Count > 0){
            sbres.Append("/");
            sbres.Append(st2.Pop());
        }
        
        string result = sbres.ToString();
        return result;
    }
}