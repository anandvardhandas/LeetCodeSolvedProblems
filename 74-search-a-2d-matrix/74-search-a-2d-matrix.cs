public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length, n = matrix[0].Length;
        
        int top = 0, bot = m-1;
        int rowtochoose = 0;
        while(top <= bot){
            int mid = top + (bot-top)/2;
            int first = matrix[mid][0], last = matrix[mid][n-1];
            //Console.WriteLine(mid);
            if(target >= first && target <= last){
                rowtochoose = mid;
                break;
            }
            else if(target < first){
                bot = mid-1;
            }
            else if(target > last){
                top = mid+1;
            }
        }
        
        int low = 0, hi = n-1;
        
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(matrix[rowtochoose][mid] == target){
                return true;
            }
            else if(target < matrix[rowtochoose][mid]){
                hi = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        
        return false;
    }
}