public class Solution {
    public int MinMoves(int[] nums) {
        int len = nums.Length;
        //1,5,10
        /*
        2,8,13,15,18
        18,24,29,31,18
        31,37,42,31,31
        42,48,42,42,42
        48,48,48,48,48
        
        */
        
        Array.Sort(nums);
        
        int result = 0;
        
        int i = len-1;
        int diff = 0;
        int totaldiff = 0;
        while(i > 0){
            totaldiff += diff;
            nums[i] += totaldiff;
            nums[0] += diff;
            diff = nums[i] - nums[0];
            result += diff;
            //Console.WriteLine($"diff {diff}");
            //Console.WriteLine($"result {result}");
            i--;
        }
            
        return result;
    }
}