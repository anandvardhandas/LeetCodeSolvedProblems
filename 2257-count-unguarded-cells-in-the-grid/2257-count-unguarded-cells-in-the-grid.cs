public class Solution {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {
        int[,] grid = new int[m,n];
        // 1 for Wall, -1 for guard and 0 for unguarded cell and -2 for guard able to see marking visit
        for(int i = 0; i < guards.Length; i++){
            grid[guards[i][0], guards[i][1]] = -1;
        }
        
        for(int i = 0; i < walls.Length; i++){
            grid[walls[i][0], walls[i][1]] = 1;
        }
        
        for(int i = 0; i < guards.Length; i++){
            Helper(grid,m,n,guards[i][0],guards[i][1]);
        }
        
        int result = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i,j] == 0){
                    result++;
                }
            }
        }
        
        return result;
    }
    
    private void Helper(int[,] grid, int m, int n, int row, int col){
        // go right
        int i = row, j = col+1;
        while(j < n){
            if(grid[i,j] == 1 || grid[i,j] == -1){
                break;
            }
            
            grid[i,j] = -2;
            j++;
        }
        
        // go left
        i = row; j = col-1;
        while(j >= 0){
            if(grid[i,j] == 1 || grid[i,j] == -1){
                break;
            }
            
            grid[i,j] = -2;
            j--;
        }
        
        //go up
        i = row-1; j = col;
         while(i >= 0){
            if(grid[i,j] == 1 || grid[i,j] == -1){
                break;
            }
            
            grid[i,j] = -2;
            i--;
        }
        
        //go down
        i = row+1; j = col;
        while(i < m){
            if(grid[i,j] == 1 || grid[i,j] == -1){
                break;
            }
            
            grid[i,j] = -2;
            i++;
        }
    }
}