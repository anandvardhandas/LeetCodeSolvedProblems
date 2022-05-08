public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length > nums2.Length){
            return FindMedianSortedArrays(nums2, nums1); // make sure nums1 is always the smaller one
        }
        
        int len1 = nums1.Length, len2 = nums2.Length;
        
        int low = 0, hi = len1;
        
        while(low <= hi){
            int cut1 = low + (hi-low)/2;
            int cut2 = (len1+len2+1)/2 - cut1;
            
            int left1 = cut1 == 0 ? int.MinValue : nums1[cut1-1];
            int left2 = cut2 == 0 ? int.MinValue : nums2[cut2-1];
            int right1 = cut1 == len1 ? int.MaxValue : nums1[cut1];
            int right2 = cut2 == len2 ? int.MaxValue : nums2[cut2];
            
            if(left1 <= right2 && left2 <= right1){
                if((len1+len2)%2 == 0){
                    return (Math.Max(left1,left2) + Math.Min(right1,right2))/2.0;
                }
                else{
                    return Math.Max(left1,left2);
                }
            }
            else if(left1 > right2){
                hi = cut1-1;
            }
            else{
                low = cut1+1;
            }
        }
        
        return 0.0;
    }
}