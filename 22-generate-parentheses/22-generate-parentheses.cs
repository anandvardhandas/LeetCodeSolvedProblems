public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        Helper(n, result, new List<char>(), 0, 0);
        return result;
    }
    
    private void Helper(int n, IList<string> result, List<char> temp, int open, int closed){
        if(open == closed && open == n){
            result.Add(new string(temp.ToArray()));
            return;
        }
        
        if(open < n){
            temp.Add('(');
            Helper(n, result, temp, open+1, closed);
            temp.RemoveAt(temp.Count-1);
        }
        
        if(closed < open){
            temp.Add(')');
            Helper(n, result, temp, open, closed+1);
            temp.RemoveAt(temp.Count-1);
        }
    }
}