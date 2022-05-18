/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int low = 1, hi = n;
        int result = 1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            bool isbad = IsBadVersion(mid);
            if(!isbad){
                low = mid+1;
            }
            else{
                result = mid;
                hi = mid-1;
            }
        }
        
        return result;
    }
}