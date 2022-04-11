public class Solution {
    public int MinProductSum(int[] nums1, int[] nums2) {
        /*
            5,3,4,2
            
            4,2,2,5
            
            2,2,4,5
            2,3,4,5
            5,4,3,2
            
            10+8+12+10 = 40
            
            1,2,4,5,7
            8,6,4,3,2
            8+12+16+15+14 = 65
        
        */
        
        Array.Sort(nums1);
        Array.Sort(nums2);
        
        int len = nums1.Length;
        int i = 0, j = len-1;
        
        int total = 0;
        while(i < len && j >= 0){
            total += nums1[i] * nums2[j];
            i++;
            j--;
        }
        
        return total;
    }
}