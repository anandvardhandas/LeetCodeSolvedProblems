public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        IList<IList<int>> result = new List<IList<int>>();
        Helper(n, result, new List<int>(), k, 1);
        return result;
    }
    
    private void Helper(int n, IList<IList<int>> result, IList<int> temp, int k, int index){
        if(temp.Count == k){
            result.Add(new List<int>(temp));
            return;
        }
        
        if(index == n+1){
            return;
        }
        
        for(int i = index; i <= n; i++){
            temp.Add(i);
            Helper(n, result, temp, k, i+1);
            temp.RemoveAt(temp.Count-1);
        }
    }
}