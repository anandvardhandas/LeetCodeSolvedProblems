/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int l = 1, r = n;
        int bad = -1;
        while(l<=r){
            int mid = l + (r-l)/2;
            bool isbad = IsBadVersion(mid);
            if(!isbad){
                l = mid+1;
            }
            else{
                bad = mid;
                r = mid-1;
            }
        }
        
        return bad;
    }
}