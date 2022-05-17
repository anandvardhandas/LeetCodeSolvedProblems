public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        Queue<Node> que = new Queue<Node>();
        int m = mat.Length, n = mat[0].Length;
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(mat[i][j] == 0){
                    que.Enqueue(new Node(i, j, 0));
                }
            }
        }
        
        
        int[,] visited = new int[m,n];
        while(que.Count > 0){
            Node node = que.Dequeue();
            
            foreach(int[] dir in Directions){
                int row = dir[0]+node.x, col = dir[1]+node.y;
                if(row < 0 || row >= m || col < 0 || col >= n || mat[row][col] == 0 || visited[row,col] == 1){
                    continue;
                }
                
                mat[row][col] = node.dist+1;
                visited[row,col] = 1;
                que.Enqueue(new Node(row, col, node.dist+1));
            }
        }
        
        return mat;
    }
    
    private int[][] Directions = new int[4][]{
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, -1 },
        new int[] { 0, 1 }
    };
}

public class Node{
    public int x;
    public int y;
    public int dist;
    
    public Node(int _x, int _y, int _dist){
        x = _x;
        y = _y;
        dist = _dist;
    }
}