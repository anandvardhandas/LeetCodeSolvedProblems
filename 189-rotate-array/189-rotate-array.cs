public class Solution {
    public void Rotate(int[] nums, int k) {
        int len = nums.Length;
        k = k % len;
        if(k == 0)
            return;
        
        int i = 0;
        int count = 0;
        while(count < len && i < len){
            int curr = i;
            int num = nums[curr];
            do{
                int temp = nums[(curr+k)%len];//saves 4
                nums[(curr+k)%len] = num;//put 1 at 4s place
                num = temp;
                curr = (curr+k)%len;
                count++;
            }
            while(count < len && curr != i);
            i++;
        }
    }
}