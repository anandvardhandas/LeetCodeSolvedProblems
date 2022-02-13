public class Solution {
    public long MinimumRemoval(int[] beans) {
        int len = beans.Length;
        
        Array.Sort(beans);
        //1,4,5,6
        
        long[] prefix = new long[len];
        prefix[0] = beans[0];
        for(int i = 1; i < len; i++){
            prefix[i] = beans[i] + prefix[i-1];
        }
        
        long result = long.MaxValue;
        for(int i = 0; i < len; i++){
            long beanstoremovetomakeequal = 0;
            long prefixval = 0;
            if(i > 0)
                prefixval = prefix[i-1];
            
            beanstoremovetomakeequal = (prefix[len-1] - prefixval) - ((len-i)*(long)beans[i]);
            
            result = Math.Min(result, beanstoremovetomakeequal+prefixval);
        }
        
        return result;
        
    }
}