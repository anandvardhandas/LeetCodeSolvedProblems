public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        int n = nums1.Length;
        int count = 0;
        //using hashmap or dictionary
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                int sum = nums3[i]+nums4[j];
                if(map.ContainsKey(sum)){
                    map[sum]++;
                }
                else{
                    map.Add(sum, 1);
                }
            }
        }
        
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                int sum = nums1[i] + nums2[j];
                if(map.ContainsKey(-sum)){
                    count += map[-sum];
                }
            }
        }
        
        
        return count;
    }
}