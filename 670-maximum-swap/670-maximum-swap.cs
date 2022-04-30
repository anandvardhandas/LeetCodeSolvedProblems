public class Solution {
    public int MaximumSwap(int num) {
        if(num <= 9)
            return num;
        
        string numstr = num.ToString();
        char[] nums = numstr.ToCharArray();
        Array.Sort(nums, (x,y) => y.CompareTo(x));
        
        int i = 0;
        while(i<nums.Length){
            if(nums[i] == numstr[i]){
                i++;
            }
            else{
                break;
            }
        }
        char[] result = numstr.ToCharArray();
        if(i < nums.Length){
            //find the last positionn of nums[i] in numstr
            int swapindex = -1;
            for(int j = numstr.Length-1; j >= 0; j--){
                if(numstr[j] == nums[i]){
                    swapindex = j;
                    break;
                }
            }

            //swap i with swapindex in numstr
            char temp = result[i];
            result[i] = result[swapindex];
            result[swapindex] = temp;
        }
        
        return int.Parse(new string(result));
    }
}