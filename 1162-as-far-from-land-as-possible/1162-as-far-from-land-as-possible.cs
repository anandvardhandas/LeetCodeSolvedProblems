public class Solution {
    public int MaxDistance(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        int[,] score = new int[m,n];
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 0){
                    //check top
                    int row = i-1; int col = j;
                    int mindist = 1000000;
                    if(row >= 0){
                        if(grid[row][col] == 1){
                            mindist = 0;
                        }
                        else{
                            mindist = Math.Min(mindist, score[row,col]);
                        }
                    }
                    
                    //check left
                    row = i;  col = j-1;
                    if(col >= 0){
                        if(grid[row][col] == 1){
                            mindist = 0;
                        }
                        else{
                            mindist = Math.Min(mindist, score[row,col]);
                        }
                    }
                    
                    score[i,j] = 1 + mindist;
                }
            }
        }
        
        for(int i = m-1; i >= 0; i--){
            for(int j = n-1; j >= 0; j--){
                if(grid[i][j] == 0){
                    //check bottom
                    int row = i+1; int col = j;
                    int mindist = 1000000;
                    if(row < m){
                        if(grid[row][col] == 1){
                            mindist = 0;
                        }
                        else{
                            mindist = Math.Min(mindist, score[row,col]);
                        }
                    }
                    
                    //check right
                    row = i;  col = j+1;
                    if(col < n){
                        if(grid[row][col] == 1){
                            mindist = 0;
                        }
                        else{
                            mindist = Math.Min(mindist, score[row,col]);
                        }
                    }
                    
                    mindist = Math.Min(1 + mindist, score[i,j]);
                    
                    score[i,j] = mindist;
                }
            }
        }
        
        int maxdist = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                maxdist = Math.Max(maxdist, score[i,j]);
            }
        }
        
        return (maxdist == 1000001 || maxdist == 0) ? -1 : maxdist;
    }
}