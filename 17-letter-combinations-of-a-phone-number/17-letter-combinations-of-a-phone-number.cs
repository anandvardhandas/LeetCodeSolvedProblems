public class Solution {
    private Dictionary<int,string> map = new Dictionary<int,string>();
    public IList<string> LetterCombinations(string digits) {
        map.Add(2,"abc");
        map.Add(3,"def");
        map.Add(4,"ghi");
        map.Add(5,"jkl");
        map.Add(6,"mno");
        map.Add(7,"pqrs");
        map.Add(8,"tuv");
        map.Add(9,"wxyz");
        
        IList<string> result = new List<string>();
        if(digits.Length == 0)
            return result;
        
        Helper(digits, result, new List<char>(), 0);
        return result;
    }
    
    private void Helper(string s, IList<string> result, List<char> temp, int index){
        if(index == s.Length){
            result.Add(new string(temp.ToArray()));
            return;
        }
        
        string str = map[int.Parse(s[index].ToString())];
        for(int i = 0; i < str.Length; i++){
            temp.Add(str[i]);
            Helper(s, result, temp, index+1);
            temp.RemoveAt(temp.Count-1);
        }
    }
}