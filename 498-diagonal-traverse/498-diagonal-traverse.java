class Solution {
    public int[] findDiagonalOrder(int[][] mat) {
        int m = mat.length, n = mat[0].length;
        int[] result = new int[m*n];
        
        int total = m*n;
        int row = 0, col = 0;
        int count = 0;
        int index= 0;
        while(count < total){
            while(row >= 0 && col < n){
                if(count == total)
                    break;
                
                result[index++] = mat[row][col];
                count++;
                
                row--;
                col++;
            }
            
            if(col == n){
                col = n-1;
                row += 2;
            }
            else if(row < 0){
                row = 0;
            }
            
            while(col >= 0 && row < m){
                if(count == total)
                    break;
                
                result[index++] = mat[row][col];
                count++;
                row++;
                col--;
            }
            
            if(row == m){
                row = m-1;
                col += 2;
            }
            else if(col < 0){
                col = 0;
            }
        }
        
        return result;
    }
}