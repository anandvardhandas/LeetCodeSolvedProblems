public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length, n = matrix[0].Length;
        
        int low = 0, hi = m*n-1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            int row = mid/n;
            int col = mid%n;
            
            if(matrix[row][col] == target)
                return true;
            else if(matrix[row][col] < target)
                low = mid+1;
            else
                hi = mid-1;
        }
        
        return false;
    }
}