public class Solution {
    public bool BackspaceCompare(string s, string t) {
        List<char> list1 = new List<char>();
        List<char> list2 = new List<char>();
        
        foreach(char c in s){
            if(c == '#'){
                if(list1.Count > 0){
                    list1.RemoveAt(list1.Count-1);
                }
            }
            else{
                list1.Add(c);
            }
        }
        
        foreach(char c in t){
            if(c == '#'){
                if(list2.Count > 0){
                    list2.RemoveAt(list2.Count-1);
                }
            }
            else{
                list2.Add(c);
            }
        }
        
        int i = list1.Count-1, j = list2.Count-1;
        while(i >= 0 && j >= 0 && list1[i] == list2[j]){
           i--;
            j--;
        }
        return i == -1 && j == -1;
    }
}