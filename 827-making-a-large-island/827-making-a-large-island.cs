public class Solution {
    public int LargestIsland(int[][] grid) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int id = 2;
        int n = grid.Length;
        int maxarea = 0;
        
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    int[] count = new int[1];
                    Helper(grid, i, j, id, count);
                    map.Add(id,count[0]);
                    maxarea = Math.Max(maxarea, count[0]);
                    //Console.WriteLine("modified " + grid[i][j]);
                    id++;
                }
            }
        }
        
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 0){
                    //Console.WriteLine("trying to put");
                    HashSet<int> set = new HashSet<int>();
                    foreach(int[] dir in Directions){
                        int row = i+dir[0], col = j+dir[1];
                        //Console.WriteLine($"row: {row} col: {col}  and gridval: {grid[i][j]}");
                        if(row >= 0 && row < n && col >= 0 && col < n && grid[row][col] > 1){
                            set.Add(grid[row][col]);
                            //Console.WriteLine("Adding id to set:" + grid[row][col]);
                        }
                    }
                    
                    int area = 1;
                    foreach(var item in set){
                        if(item > 1)
                            area += map[item];
                    }
                    
                    maxarea = Math.Max(maxarea,area);
                }
            }
        }
        
        return maxarea;
    }
    
    private void Helper(int[][] grid, int i, int j, int id, int[] count){
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid.Length || grid[i][j] == 0 || grid[i][j] > 1){
            return;
        }
        
        grid[i][j] = id;
        count[0]++;
        //Console.WriteLine("helper " + grid[i][j]);
        foreach(int[] dir in Directions){
            int row = i+dir[0], col = j+dir[1];
            Helper(grid, row, col, id, count);
        }
    }
    
    private int[][] Directions = new int[4][]{
        new int[] { 1,0 },
        new int[] { -1,0 },
        new int[] { 0,1 },
        new int[] { 0,-1 }
    };
}