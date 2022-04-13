public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] result = new int[n][];
        for(int i = 0; i < n; i++){
            result[i] = new int[n];
        }
        
        int count = 1;
        
        int row = 0, col = 0;
        while(count <= n*n){
            //go right
            while(col < n && result[row][col] == 0){
                result[row][col] = count++;
                col++;
            }
            
            col--;
            row++;
            
            //go down
            while(row < n && result[row][col] == 0){
                result[row][col] = count++;
                row++;
            }
            
            row--;
            col--;
            
            //go left
            while(col >= 0 && result[row][col] == 0){
                result[row][col] = count++;
                col--;
            }
            
            col++;
            row--;
            
            //go up
            while(row >= 0 && result[row][col] == 0){
                result[row][col] = count++;
                row--;
            }
            
            
            row++;
            col++;
        }
        
        return result;
    }
}