public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int len = nums.Length;
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0; i < len; i++){
            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i], 1);
            }
            else{
                map[nums[i]]++;
            }
        }
        
        //using bucket sort algorithm
        //create bucket of size n as max frequency of any number can be is n
        List<int>[] bucket = new List<int>[len+1];
        foreach(var item in map){
            var lst = bucket[item.Value];
            if(lst == null){
                lst = new List<int>() { item.Key };
            }
            else{
                lst.Add(item.Key);
            }
            
            bucket[item.Value] = lst;
        }
        
        List<int> result = new List<int>();
        int count = 0, j = len;
        while(count < k){
            while(bucket[j] == null){
                j--;
            }
            
            List<int> temp = bucket[j];
            foreach(int item in temp){
                result.Add(item);
                count++;
                if(count == k)
                    break;
            }
            
            j--;
        }
        
        return result.ToArray();
    }
}

