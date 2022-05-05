public class Solution {
    public int KthFactor(int n, int k) {
         for(int i = 1; i < Math.Sqrt(n); ++i) 
                if(n % i== 0 && --k == 0) 
                    return i;                       
            for(int i = (int) Math.Sqrt(n); i >= 1; --i) 
                if(n % (n/i) == 0 && --k == 0) 
                    return n/i;          
            return -1;
        
        /*
            for(int i = 1; i < Math.sqrt(n); ++i) 
                if(n % i== 0 && --k == 0) 
                    return i;                       
            for(int i = (int) Math.sqrt(n); i >= 1; --i) 
                if(n % (n/i) == 0 && --k == 0) 
                    return n/i;          
            return -1;
        */
    }
}