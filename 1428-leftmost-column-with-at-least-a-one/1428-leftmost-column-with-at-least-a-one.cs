/**
 * // This is BinaryMatrix's API interface.
 * // You should not implement it, or speculate about its implementation
 * class BinaryMatrix {
 *     public int Get(int row, int col) {}
 *     public IList<int> Dimensions() {}
 * }
 */

class Solution {
    public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix) {
       IList<int> dims =  binaryMatrix.Dimensions();
        int row = dims[0], col = dims[1];
        
        int min = int.MaxValue;
        for(int i = 0; i < row; i++){
            int low = 0, hi = col-1;
            int ans = int.MaxValue;
            while(low <= hi){
                int mid = low + (hi-low)/2;
                if(binaryMatrix.Get(i,mid) == 1){
                    ans = mid;
                    hi = mid-1;
                }
                else{
                    low = mid+1;
                }
            }
            
            if(ans != int.MaxValue)
                min = Math.Min(min,ans);
            if(min == 0){
                return min;
            }
        }
        
        if(min == int.MaxValue)
            return -1;
        
        return min;
    }
}