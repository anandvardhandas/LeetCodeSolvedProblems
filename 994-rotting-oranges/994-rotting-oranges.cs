public class Solution {
    public int OrangesRotting(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        Queue<Node> que = new Queue<Node>();
        
        int fresh = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    fresh++;
                }
                else if(grid[i][j] == 2){
                    que.Enqueue(new Node(i,j));
                }
            }
        }
        
        if(fresh == 0)
            return 0;
        int mins = 0;
        
        while(que.Count > 0){
            int size = que.Count;
            for(int i = 1; i <= size; i++){
                Node node = que.Dequeue();
                
                foreach(int[] dir in Directions){
                    int row = dir[0]+node.x, col = dir[1]+node.y;
                    if(row < 0 || row >= m || col < 0 || col >= n || grid[row][col] == 2 || grid[row][col] == 0){
                        continue;
                    }
                    
                    grid[row][col] = 2;
                    fresh--;
                    if(fresh == 0){
                        return mins+1;
                    }
                    
                    que.Enqueue(new Node(row,col));
                }
            }
            
            mins++;
            
        }
        
        return fresh > 0 ? -1 : mins;
    }
    
    private int[][] Directions = new int[4][]{
        new int[] { 1, 0},
        new int[] { -1, 0},
        new int[] { 0, 1},
        new int[] { 0, -1}
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