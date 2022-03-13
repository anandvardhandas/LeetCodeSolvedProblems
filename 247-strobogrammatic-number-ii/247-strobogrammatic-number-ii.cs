public class Solution {
    public IList<string> FindStrobogrammatic(int n) {
        IList<string> result = new List<string>();
        Helper(result, new char[n], 0, n-1);
        return result;
    }
    
    
    private void Helper(IList<string> result, char[] temp, int low, int hi){
        if(low > hi){
            result.Add(new string(temp));
            return;
        }
        
        if(low == hi){
            temp[low] = '0';
            Helper(result, temp, low+1, hi-1);
            
            temp[low] = '1';
            Helper(result, temp, low+1, hi-1);
            
            temp[low] = '8';
            Helper(result, temp, low+1, hi-1);
            
            return;
        }
        
        
        if(low != 0){
            temp[low] = '0';
            temp[hi] = '0';
            Helper(result, temp, low+1, hi-1);
        }
        
        temp[low] = '1';
        temp[hi] = '1';
        Helper(result, temp, low+1, hi-1);
        
        temp[low] = '8';
        temp[hi] = '8';
        Helper(result, temp, low+1, hi-1);
        
        temp[low] = '6';
        temp[hi] = '9';
        Helper(result, temp, low+1, hi-1);
        
        temp[low] = '9';
        temp[hi] = '6';
        Helper(result, temp, low+1, hi-1);
    }
}