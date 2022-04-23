public class Solution {
    public int MaxLength(int[] ribbons, int k) {
        /*
         5,7,9
         
         1 & 5 => 3
        
        
        */
        
        Array.Sort(ribbons);
        int len = ribbons.Length;
        //Console.WriteLine(len);
        long total = 0;
        for(int i = 0; i < len; i++){
            total += ribbons[i];
        }
        
        //edge case
        if(total < k)
            return 0;
        
        int l = 1, r = ribbons[len-1];
        
        while(l <= r){
            int mid = l + (r-l)/2;
            //Console.WriteLine(r);
            //Console.WriteLine(mid);
            bool possible = Possible(ribbons, mid, k);
            if(!possible){
                r = mid-1;
            }
            else{
                l = mid + 1;
            }
        }
        
        if(!Possible(ribbons, l, k)){
            return l-1;
        }
        else{
            return l;
        }
    }
    
    private bool Possible(int[] ribbons, int size, int k){
        int total = 0;
        for(int i = 0; i < ribbons.Length; i++){
            total += ribbons[i]/size;
            if(total >= k)
                return true;
        }
        
        return false;
    }
}