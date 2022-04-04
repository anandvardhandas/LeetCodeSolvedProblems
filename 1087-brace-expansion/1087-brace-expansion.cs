public class Solution {
    public string[] Expand(string s) {
        
        int len = s.Length;
        
        List<List<char>> list = new List<List<char>>();
        
        List<char> temp = new List<char>();
        
        for(int i = 0; i < len; i++){
            if(s[i] == '}'){
                temp.Sort();
                list.Add(new List<char>(temp));
                temp = new List<char>();
            }
            else if(s[i] == '{'){
                if(temp.Count > 0){
                    temp.Sort();
                    list.Add(new List<char>(temp));
                    temp = new List<char>();
                }
            }
            else if(s[i] != ','){
                temp.Add(s[i]);
            }
        }
        
        if(temp.Count > 0){
            temp.Sort();
            list.Add(new List<char>(temp));
        }
        
        if(list.Count == 1 && temp.Count > 0){
            return new string[] { s };
        }
        
        List<string> result = new List<string>();
        Helper(result, list, new List<char>(), 0);
        return result.ToArray();
    }
    
    private void Helper(List<string> result, List<List<char>> list, List<char> temp, int index){
        if(index == list.Count){
            result.Add(new string(temp.ToArray()));
            return;
        }
        
        List<char> currlist = list[index];
        foreach(char c in currlist){
            temp.Add(c);
            Helper(result, list, temp, index+1);
            temp.RemoveAt(temp.Count-1);
        }
    }
}