public class Solution {
    public int ThreeSumMulti(int[] arr, int target) {
        int MOD = 1000000007;
        long result = 0;
        long[] map = new long[101];
        foreach(int num in arr){
            map[num]++;
        }
        
        List<int> list = new List<int>();
        for(int i = 0; i <= 100; i++){
            if(map[i] > 0)
                list.Add(i);
        }
        
        int[] nums = list.ToArray();
        //[1,2,3,4,5]
        
        //step 1 - finding unique combination
        for(int i = 0; i <= nums.Length-3; i++){
            int j = i+1, k = nums.Length-1;
            while(j<k){
                int total = nums[i]+nums[j]+nums[k];
                if(total > target){
                    k--;
                }
                else if(total < target){
                    j++;
                }
                else{
                    result += (map[nums[i]] * map[nums[j]] * map[nums[k]])%MOD;
                    result = result % MOD;
                    j++;
                    k--;
                }
            }
        }
        
        
        //step 2 - finding doubling
        for(int i = 0; i <= 100; i++){
            if(map[i] >= 2){
                int total = i * 2;
                int left = target-total;
                if(left == i)
                    continue;
                if(left >= 0 && left <= 100 && map[left] > 0){
                    result = result + (GetFact2(map[i]) * map[left])%MOD;
                    result = result % MOD;
                }
            }
        }
        
        //step 3 - finding tripling
        if(target % 3 == 0 && map[target/3] >= 3){
            result = result + GetFact3(map[target/3])%MOD;
            result = result % MOD;
        }
        
        return (int)result;
        
    }
    
    private long GetFact2(long num){
        return (num * (num-1))/2;
    }
    
    private long GetFact3(long num){
        return (num * (num-1) * (num-2))/6;
    }
}