class Solution {
    public int shortestPathBinaryMatrix(int[][] grid) {
        int n = grid.length;
        
        if(grid[0][0] == 1 || grid[n-1][n-1] == 1)
            return -1;
        
        //As we are travelling in all directions, we cannot go with dynamic programming approach as we havent travveled all the cells for which the current cells is dependent to calculate result, 
        // Hence we are doing BFS approach
        Queue<int[]> que = new ArrayDeque<>();
        que.add(new int[] { 0,0,1 });
        int[][] visited = new int[n][n];
        visited[0][0] = 1;
        
        while(!que.isEmpty()){
            int[] node = que.remove();
            int row = node[0], col = node[1], dist = node[2];
            
            if(row == n-1 && col == n-1)
                return dist;
            
            for(int[] dir : Directions){
                int nrow = dir[0]+row, ncol = dir[1]+col;
                if(nrow >= 0 && nrow < n && ncol >= 0 && ncol < n && grid[nrow][ncol] == 0 && visited[nrow][ncol] == 0){
                    visited[nrow][ncol] = 1;
                    que.add(new int[] { nrow, ncol, dist+1 });
                }
                    
            }
        }
        
        return -1;
    }
    
    private int[][] Directions = new int[][]{
        new int[] { 1,0 },
        new int[] { -1,0 },
        new int[] { 0,1 },
        new int[] { 0,-1 },
        
        new int[] { -1,1 },
        new int[] { 1,1 },
        new int[] { 1,-1 },
        new int[] { -1,-1 },
    };
}