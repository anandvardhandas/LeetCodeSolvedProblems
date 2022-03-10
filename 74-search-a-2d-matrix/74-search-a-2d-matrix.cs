public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = matrix.Length, col = matrix[0].Length;
        //binary search to decide in which row can target be
        int low = 0, hi = matrix.Length-1;
        while(low < hi){
            int mid = low + (hi-low)/2;
            
            if(matrix[mid][0] == target)
                return true;
            else if(matrix[mid][0] > target)
                hi = mid-1;
            else if(matrix[mid][0] < target && matrix[mid][col-1] < target)
                low = mid+1;
            else if(matrix[mid][0] < target && matrix[mid][col-1] >= target){
                low = mid;
                break;
            }
            else
                low = mid;
        }
        
        //Console.WriteLine(low);
        //binary search on row
        int l = 0, r = matrix[0].Length-1;
        int count = 0;
        while(l <= r){
            int m = l + (r-l)/2;
            
            if(matrix[low][m] == target)
                return true;
            else if(matrix[low][m] > target)
                r = m-1;
            else
                l = m+1;
            
            count++;
        }
        
        return false;
    }
}