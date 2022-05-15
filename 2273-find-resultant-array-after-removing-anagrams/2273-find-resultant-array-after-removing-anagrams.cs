public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        IList<string> result = new List<string>();
        
        Stack<string> st = new Stack<string>();
        foreach(string str in words){
            if(st.Count > 0 && Check(str, st.Peek())){
                continue;
            }
            
            st.Push(str);
        }
        
        Stack<string> st2 = new Stack<string>();
        while(st.Count > 0){
            st2.Push(st.Pop());
        }
        
        while(st2.Count > 0){
            result.Add(st2.Pop());
        }
        
        return result;
    }
    
    private bool Check(string str1, string str2){
        int[] map1 = new int[26];
        int[] map2 = new int[26];
        
        foreach(char c in str1){
            map1[c-'a']++;
        }
        
        foreach(char c in str2){
            map2[c-'a']++;
        }
        
        for(int i = 0; i < 26; i++){
            if(map1[i] != map2[i]){
                return false;
            }
        }
        
        return true;
    }
}