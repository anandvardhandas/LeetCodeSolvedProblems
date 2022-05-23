public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        int ans = 0;
		int i = 0;
		int j = 0;
		while(i < nums1.Length && j < nums2.Length){
			if(nums1[i] <= nums2[j]){
				if(i <= j){
					ans = Math.Max(ans, j - i);
				}
				j++;
			}
			else{
				i++;
			}
		}
		return ans;
	}
}