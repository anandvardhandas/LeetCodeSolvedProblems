public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //[1,5,7,0,0,0] [2,3,6]
        //[2,5,7,0,0,0] [2,3,6]
        //[2,2,7,5,0,0]
        //[2,2,3,5,7,0]
        //[2,2,3,5,6,7]
        
        int i = m-1, j = n-1, k = m+n-1;
        
        while(k >= 0){
            if(j < 0)
                break;
            
            if(i >= 0 && j >= 0 && nums1[i] >= nums2[j]){
                nums1[k] = nums1[i];
                k--;
                i--;
            }
            else{
                if(j>=0){
                    nums1[k] = nums2[j];
                    k--;
                    j--;
                }
            }
            
        }
        
        
    }
}