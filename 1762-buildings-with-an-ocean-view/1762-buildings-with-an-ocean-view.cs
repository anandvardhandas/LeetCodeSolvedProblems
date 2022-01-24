public class Solution {
    public int[] FindBuildings(int[] heights) {
        //without using any space
        int len = heights.Length;
        List<int> result = new List<int>();
        result.Add(len-1);
        int maxHeight = heights[len-1];
        for(int i = len-2; i >= 0; i--){
            bool replaced = false;
            if(heights[i] > maxHeight){
                maxHeight = heights[i];
                replaced = true;
            }
            
            if(replaced){
                result.Add(i);
            }
        }
        
        result.Reverse();
        return result.ToArray();
    }
}