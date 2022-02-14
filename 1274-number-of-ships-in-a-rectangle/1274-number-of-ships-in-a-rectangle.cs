/**
 * // This is Sea's API interface.
 * // You should not implement it, or speculate about its implementation
 * class Sea {
 *     public bool HasShips(int[] topRight, int[] bottomLeft);
 * }
 */

class Solution {
    public int CountShips(Sea sea, int[] topRight, int[] bottomLeft) {
        if(!sea.HasShips(topRight, bottomLeft))
            return 0;
        
        if(topRight[0] == bottomLeft[0] && topRight[1] == bottomLeft[1]){
            return 1;
        }
        
        int midx = (bottomLeft[0]+topRight[0])/2;
        int midy = (bottomLeft[1]+topRight[1])/2;
        
        return CountShips(sea, new int[] { midx, topRight[1] }, new int[] { bottomLeft[0], midy+1 } ) + //top left quadrant
               CountShips(sea, topRight, new int[] { midx+1, midy+1 }) + //top right quadrant
               CountShips(sea, new int[] { topRight[0], midy }, new int[] { midx+1, bottomLeft[1] }) + //bottom right quadrant
               CountShips(sea, new int[] { midx, midy }, bottomLeft); //bottom left quadrant
    }
}