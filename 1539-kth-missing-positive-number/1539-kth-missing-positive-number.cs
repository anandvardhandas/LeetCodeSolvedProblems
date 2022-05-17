public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int len = arr.Length;
        
        int low = 0, hi = len-1;
        int last = 0;
        while(low <= hi){
            int mid = low+(hi-low)/2;
            int kth = arr[mid]-(mid+1);
            if(kth < k){
                last = mid;
                low = mid+1;
            }
            else{
                hi = mid-1;
            }
        }
        //Console.WriteLine(k - (arr[last]-(last+1)));
        
        return k+low;
    }
}