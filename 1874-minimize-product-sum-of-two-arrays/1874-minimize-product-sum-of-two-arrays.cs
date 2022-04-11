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
        
        int len = nums1.Length;
        int[] map1 = new int[101];
        int[] map2 = new int[101];
        
        for(int i = 0; i < len; i++){
            map1[nums1[i]]++;
            map2[nums2[i]]++;
        }
        
        // [0,0,1,1,1,1]
        // [0,0,2,0,1,1]
        
        int total = 0;
        int l = 1, r = 100;
        int count = 0;
        while(count < len){
            while(map1[l] == 0){
                l++;
            }
            
            //Console.WriteLine(l);
            while(map2[r] == 0){
                r--;
            }
            //Console.WriteLine(r);
            total += l * r;
            
            map1[l]--;
            map2[r]--;
            
            count++;
        }
        
        
        return total;
    }
}