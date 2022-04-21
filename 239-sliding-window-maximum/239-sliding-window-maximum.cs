public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        List<int> result = new List<int>();
        int len = nums.Length;
        if(k > len)
            return result.ToArray();
        
        SortedDictionary<int,int> map = 
            new SortedDictionary<int,int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
        
        //first create a window of size k
        for(int i = 0; i < k; i++){
            if(map.ContainsKey(nums[i])){
                map[nums[i]]++;
            }
            else{
                map.Add(nums[i], 1);
            }
        }
        
        //get max
         result.Add(map.First().Key);
        //Console.WriteLine(map.First().Key);
        
        // start shifting
        int l = 0, r = k-1;
        
        while(r <= len-2){
            //shift right
            r++;
            if(map.ContainsKey(nums[r])){
                map[nums[r]]++;
            }
            else{
                map.Add(nums[r], 1);
            }
            
            //shift left
            map[nums[l]]--;
            if(map[nums[l]] == 0){
                map.Remove(nums[l]);
            }
            
            l++;
            
            //get max
            result.Add(map.First().Key);
        }
        
        return result.ToArray();
    }
}