public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        IList<int> result = new List<int>();
        int len = nums.Length;
        int count = 0;
        
        int i = 0;
        
        while(i < len){
            int num = nums[i];
            if(num-1 != i){
                while(true){ // 4,4,2,1
                    int temp = nums[num-1];
                    if(temp == num)
                        break;
                    
                    nums[num-1] = num;
                    num = temp;
                }
            }
            
            i++;
        }
        
        for(int j = 0; j < len; j++){
            if(nums[j]-1 != j)
                result.Add(j+1);
        }
        
        
        return result;
    }
}