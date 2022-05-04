public class Solution {
    public int MaxOperations(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int operations = 0;
        for(int i = 0; i < nums.Length; i++){
            int num = nums[i];
            if(map.ContainsKey(k-num)){
                if(map[k-num] > 0){
                    map[k-num]--;
                    operations++;
                    
                    if(map[k-num] == 0){
                        map.Remove(k-num);
                    }
                }
            }
            else{
                if(map.ContainsKey(num)){
                    map[num]++;
                }
                else{
                    map.Add(num,1);
                }
            }
        }
        
        return operations;
    }
}