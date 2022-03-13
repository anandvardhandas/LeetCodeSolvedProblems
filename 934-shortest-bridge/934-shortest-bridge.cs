public class Solution {
    public int ShortestBridge(int[][] grid) {
        int n = grid.Length;
        
        Queue<int[]> que = new Queue<int[]>();
        int[,] visited = new int[n,n];
        bool found = false;
        for(int i = 0; i < n; i++){
            if(found)
                break;
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    IslandMarker(n, grid, i, j, visited, que);
                    found = true;
                    break;
                }
            }
        }
       
        int dist = 0;
        while(que.Count > 0){
            int size = que.Count;
            //Console.WriteLine(size);
            for(int k = 1; k <= size; k++){
                int[] cords = que.Dequeue();
                //Console.WriteLine($"{cords[0]},{cords[1]}");
                foreach(int[] dir in Directions){
                    int i = dir[0] + cords[0], j = dir[1] + cords[1];
                    if(i >= 0 && i < n && j >= 0 && j < n && visited[i,j] == 0){
                        if(grid[i][j] == 1)
                            return dist;
                        
                        que.Enqueue(new int[] { i,j });
                        visited[i,j] = 1;
                    }
                }
            }
            dist++;
        }
        
        return dist;
    }
    
    private void IslandMarker(int n, int[][] grid, int i, int j, int[,] visited, Queue<int[]> que){
        if(i < 0 || i >= n || j < 0 || j >= n || grid[i][j] == 0 || visited[i,j] == 1)
            return;
        
        grid[i][j] = 2;
        visited[i,j] = 1;
       que.Enqueue(new int[] { i, j });
        foreach(int[] dir in Directions){
            int row = dir[0]+i, col = dir[1]+j;
            IslandMarker(n, grid, row, col, visited, que);
        }
    }
    
    private int[][] Directions = new int[4][] {
        new int[] { 1,0 },
        new int[] { -1,0 },
        new int[] { 0,1 },
        new int[] { 0,-1 }
    };
}