public class Solution {
    public int MaxConsecutive(int bottom, int top, int[] special) {
        Array.Sort(special);
        int max = 0;
        
        int i = bottom;
        int index = 0;
        while(index < special.Length && i <= top){
            int diff = special[index]-i;
            max = Math.Max(max, diff);
            i = special[index]+1;
            index++;
        }
        
        if(i <= top){
            int diff = top-i+1;
            max = Math.Max(max, diff);
        }
        
        return max;
    }
}