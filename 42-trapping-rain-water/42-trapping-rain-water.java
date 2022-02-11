class Solution {
    public int trap(int[] height) {
        int len = height.length;
        
        int[] left = new int[len];
        left[0] = 0;
        int max = height[0];
        for(int i = 1; i < len; i++){
            if(height[i] < max){
                left[i] = max;
            }
            else{
                max = height[i];
            }
        }
        
        int[] right = new int[len];
        right[len-1] = 0;
        max = height[len-1];
        for(int i = len-2; i >= 0; i--){
            if(height[i] < max){
                right[i] = max;
            }
            else{
                max = height[i];
            }
        }
        
        int area = 0;
        for(int i = 1; i < len-1; i++){
            int hight = Math.min(left[i],right[i]);
            
            if(hight > height[i])
                area += (hight - height[i]);
        }
        
        return area;
    }
}