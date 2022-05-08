public class Solution {
    public int GetFood(char[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int dist = 0;
        Queue<Node> que = new Queue<Node>();
        //find the person with *
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == '*'){
                    que.Enqueue(new Node(i,j));
                    grid[i][j] = 'X';
                    break;
                }
            }
        }
        
        while(que.Count > 0){
            int size = que.Count;
            for(int i = 1; i <= size; i++){
                Node node = que.Dequeue();
                
                foreach(int[] dir in Directions){
                    int row = dir[0]+node.x, col = dir[1]+node.y;
                    
                    if(row < 0 || row >= m || col < 0 || col >= n || grid[row][col] == 'X'){
                        continue;
                    }
                    
                    if(grid[row][col] == '#'){
                        return dist+1;
                    }
                    
                    grid[row][col] = 'X';
                    que.Enqueue(new Node(row,col));
                }
            }
            
            dist++;
        }
        
        return -1;
    }
    
    private int[][] Directions = new int[4][]{
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
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