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
        IList<int> dims = binaryMatrix.Dimensions();
        int m = dims[0], n = dims[1];
        
        int mincol = -1;
        int row = 0, col = n-1;
        while(row < m && col >= 0){
            if(binaryMatrix.Get(row,col) == 1){
                mincol = col;
                col--;
            }
            else{
                row++;
            }
        }
        
        return mincol;
    }
}