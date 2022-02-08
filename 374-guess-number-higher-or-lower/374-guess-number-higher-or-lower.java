/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution extends GuessGame {
    public int guessNumber(int n) {
        
        int low = 1, hi = n;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            int picked = guess(mid);
            if(picked  == -1){
                hi = mid-1;
            }
            else if(picked == 1){
                low = mid+1;
            }
            else
                return mid;
        }
        
        return low;
    }
}