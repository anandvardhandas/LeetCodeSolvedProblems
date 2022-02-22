public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int len = nums1.Length;
        
        int total = 0;
        
        for(int i = 0; i < len; i++){
            for(int j = 0; j < len; j++){
                int sum = nums3[i]+nums4[j];
                if(map.ContainsKey(sum)){
                    map[sum]++;
                }
                else{
                    map.Add(sum,1);
                }
            }
        }
        
        for(int i = 0; i < len; i++){
            for(int j = 0; j < len; j++){
                int sum = nums1[i]+nums2[j];
                if(map.ContainsKey(-sum)){
                    total += map[-sum];
                }
            }
        }
        
        return total;
    }
}