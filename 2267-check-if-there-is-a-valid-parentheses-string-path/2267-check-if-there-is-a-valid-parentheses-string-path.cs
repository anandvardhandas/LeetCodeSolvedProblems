public class Solution {
    public bool HasValidPath(char[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        if(grid[0][0] == ')' || grid[m-1][n-1] == '('){
            return false;
        }
        
        int[,] visited = new int[m,n];
        Dictionary<string,bool> dp = new Dictionary<string,bool>();
        return Helper(m, n, grid, 0, 0, visited, 0, 0, dp);
    }
    
    private bool Helper(int m, int n, char[][] grid, int row, int col, int[,] visited, int open, int close, Dictionary<string,bool> dp){
        if(row < 0 || row >= m || col < 0 || col >= n || visited[row,col] == 1){
            return false;
        }
        
        string key = $"{row}-{col}-{open}-{close}";
        
        if(dp.ContainsKey(key)){
            return dp[key];
        }
        
        visited[row,col] = 1;
        
        if(grid[row][col] == '('){
            open++;
        }
        else{
            close++;
        }

        if(row == m-1 && col == n-1 && open == close){
            return true;
        }
        
        if(open >= close){
            //go right
            bool res = Helper(m, n, grid, row, col+1, visited, open, close, dp);
            if(res)
                return true;
            //go down
            res = Helper(m, n, grid, row+1, col, visited, open, close, dp);
            if(res)
                return true;
        }
        
        visited[row,col] = 0;
        dp.Add(key, false);
        return false;
    }
}