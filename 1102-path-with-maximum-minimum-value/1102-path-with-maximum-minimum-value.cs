public class Solution {
    public int MaximumMinimumPath(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        int low = -1, hi = Math.Min(grid[0][0], grid[m-1][n-1]);
        int res = -1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            bool ispossible = IsPossible(grid, mid);
            if(ispossible){
                res = mid;
                low = mid+1;
            }
            else{
                hi = mid-1;
            }
        }
        
        return res;
    }
    
    
    
    private bool IsPossible(int[][] grid, int mincost){
        int m = grid.Length, n = grid[0].Length;
        int[,] visited = new int[m,n];
        Queue<Node> que = new Queue<Node>();
        que.Enqueue(new Node(0,0));
        
        visited[0,0] = 1;
        
        while(que.Count > 0){
            Node node = que.Dequeue();
            if(node.x == m-1 && node.y == n-1){
                return true;
            }
            
            foreach(int[] dir in Directions){
                int row = node.x+dir[0], col = node.y + dir[1];
                if(row >= 0 && row < m && col >= 0 && col < n && visited[row,col] == 0){
                    if(grid[row][col] >= mincost){
                        que.Enqueue(new Node(row,col));
                        visited[row,col] = 1;
                    }
                }
            }
        }
        
        return false;
    }
    
    private int[][] Directions = new int[4][]{
        new int[]{ 1, 0},
        new int[]{ -1, 0},
        new int[]{ 0, -1},
        new int[]{ 0, 1}
    };
}

public class Node{
    public int x;
    public int y;
    public Node(int _x, int _y){
        x = _x;
        y = _y;
    }
}