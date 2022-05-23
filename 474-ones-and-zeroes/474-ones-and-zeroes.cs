public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
        int len = strs.Length;
        int[,,] dp = new int[m+1,n+1,len+1];
        for(int i = 0; i <= m; i++){
            for(int j = 0; j <= n; j++){
                for(int k = 0; k <= len; k++){
                    dp[i,j,k] = -1;
                }
            }
        }
        
        Dictionary<int,int[]> map = new Dictionary<int,int[]>();
        return Helper(strs, m, n, 0, dp, map);
    }
    
    private int Helper(string[] strs, int m, int n, int index, int[,,] dp, Dictionary<int,int[]> map){
        if(index >= strs.Length){
            return 0;
        }
        
        if(m < 0 || n < 0){
            return 0;
        }
        
        if(dp[m,n,index] != -1){
            return dp[m,n,index];
        }
        
        int len1 = 0, len2 = 0;
        int[] zerosones = null;
        if(map.ContainsKey(index)){
            zerosones = map[index];
        }
        else{
            zerosones = FindOnesZeros(strs[index]);
            map.Add(index, zerosones);
        }
        
        int nzeros = zerosones[0], nones = zerosones[1];
        
        //pick this index
        if(nzeros <= m && nones <= n){
            len1 = 1 + Helper(strs, m-nzeros, n-nones, index+1, dp, map);
        }
        
        //skip this index
        len2 = Helper(strs, m, n, index+1, dp, map);
        
        int maxlen = Math.Max(len1,len2);
        
        dp[m,n,index] = maxlen;
        return maxlen;
    }
    
    
    private int[] FindOnesZeros(string s){
        char[] arr = s.ToCharArray();
        
        Array.Sort(arr);
        int len = s.Length;
        int low = 0, hi = len-1;
        int lastzeropos = -1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(arr[mid] == '1'){
                hi = mid-1;
            }
            else{
                lastzeropos = mid;
                low = mid+1;
            }
        }
        
        int nzeros = lastzeropos == -1 ? 0 : lastzeropos+1;
        int nones = len-nzeros;
        
        return new int[] { nzeros, nones };
    }
}