public class Solution {
    public int MaxArea(int[] height) {
        int len = height.Length;
        
        int l = 0, r = len-1;
        
        int maxArea = 0;
        while(l<r){
            int width = r-l;
            int length = Math.Min(height[l], height[r]);
            int currArea = width * length;
            
            maxArea = Math.Max(maxArea, currArea);
            
            if(height[l] > height[r]){
                r--;
            }
            else if(height[l] < height[r]){
                l++;
            }
            else{
                l++;
                r--;
            }
        }
        
        return maxArea;
    }
}