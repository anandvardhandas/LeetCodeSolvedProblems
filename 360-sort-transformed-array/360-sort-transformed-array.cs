public class Solution {
    public int[] SortTransformedArray(int[] nums, int a, int b, int c) {
        int l = 0, r = nums.Length-1;
        int[] result = new int[nums.Length];
        int index = a >= 0 ? nums.Length-1 : 0;
        int count = 0;
        while(count < nums.Length){
            int left = Transform(a, b, c, nums[l]);
            int right = Transform(a, b, c, nums[r]);
            
            if(a >= 0){
                 if(left > right){
                    result[index--] = left;
                    l++;
                 }
                 else{
                    result[index--] = right;
                    r--;
                 }
            }
            else{
                if(left > right){
                    result[index++] = right;
                    r--;
                 }
                 else{
                    result[index++] = left;
                    l++;
                 }
            }
            
            count++;
        }
        
        return result;
    }
    
    private int Transform(int a, int b, int c, int x){
        return a * x * x + b * x + c;
    }
}