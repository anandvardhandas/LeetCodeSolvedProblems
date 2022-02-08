public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        List<int> result = new List<int>();
        int len = arr.Length;
        //reach at the position of x
        int low = 0, hi = len-1, mid = -1;
        while(low <= hi){
            mid = low + (hi-low)/2;
            if(arr[mid] > x)
                hi = mid-1;
            else if(arr[mid] < x)
                low = mid+1;
            else
                break;
        }
        
        if(arr[mid] != x){
            //find the closest number between mid-1, mid and mid+1
            int lowestdiff = int.MaxValue;
            int lowestnumpos = int.MaxValue;
            if(mid > 0 && Math.Abs(arr[mid-1] - x) < lowestdiff){
                lowestdiff = Math.Abs(arr[mid-1] - x);
                lowestnumpos = mid-1;
            }
            
            if(Math.Abs(arr[mid]-x) < lowestdiff){
                lowestdiff = Math.Abs(arr[mid] - x);
                lowestnumpos = mid;
            }
            
            if(mid+1 < len && Math.Abs(arr[mid+1]-x) < lowestdiff){
                lowestdiff = Math.Abs(arr[mid+1] - x);
                lowestnumpos = mid+1;
            }
            
            result.Add(arr[lowestnumpos]);
            mid = lowestnumpos;
        }
        else
            result.Add(arr[mid]);
        
        low = mid-1; 
        hi = mid+1;
        int total = 1;
        
        List<int> right = new List<int>();
        
        while(total < k){
            int ldiff = int.MaxValue;
            if(low >= 0){
                ldiff = Math.Abs(x - arr[low]);
            }
            
            int rdiff = int.MaxValue;
            if(hi < len){
                rdiff = Math.Abs(x - arr[hi]);
            }
            
            if(ldiff <= rdiff){
                result.Add(arr[low]);
                total++;
                
                low--;
            }
            else if(rdiff < ldiff){
                right.Add(arr[hi]);
                total++;
                
                hi++;
            }
        }
        
        result.Reverse();
        
        //append two sorted list
        result.AddRange(right);
        
        return result;
    }
}