public class Solution {
    public int[] FindErrorNums(int[] nums) {
        
        //3,1,2,2
        int n = nums.Length;
        
        int total = n * (n+1)/2;
        int sum = 0;
        for(int i = 0; i < n; i++){
            sum += nums[i];
        }
        
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        foreach(int num in nums){
            if(map.ContainsKey(num)){
                return new int[] { num, num + total-sum };
            }
            else{
                map.Add(num,num);
            }
        }
        
        return null;
    }
}