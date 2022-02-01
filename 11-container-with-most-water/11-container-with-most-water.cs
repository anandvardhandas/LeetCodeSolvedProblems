public class Solution {
    public int MaxArea(int[] height) {
        int len = height.Length;
        int low = 0, hi = len-1;
        int max = 0;
        
        while(low < hi){
            int width = hi-low;
            int hei = Math.Min(height[low], height[hi]);
            max = Math.Max(max, width * hei);
            if(height[low] > height[hi]){
                hi--;
            }
            else if(height[low] < height[hi]){
                low++;
            }
            else{
                low++;
                hi--;
            }
        }
        
        return max;
    }
}