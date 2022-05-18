public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int len = letters.Length;
        if(letters[len-1] <= target){
            return letters[0];
        }
        
        int low = 0, hi = len-1;
        int res = -1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(letters[mid] <= target){
                low = mid+1;
            }
            else{
                res = mid;
                hi = mid-1;
            }
        }
        
        return letters[res];
    }
}