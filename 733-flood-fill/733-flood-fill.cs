public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        int m = image.Length, n = image[0].Length;
        Queue<int[]> que = new Queue<int[]>();
        int original = image[sr][sc];
        int[,] visited = new int[m,n];
        que.Enqueue(new int[]{sr,sc});
        while(que.Count > 0){
            int[] curr = que.Dequeue();
            if(curr[0] < 0 || curr[0] >= m || curr[1] < 0 || curr[1] >= n || image[curr[0]][curr[1]] != original || visited[curr[0],curr[1]] == 1)
                continue;
            
            visited[curr[0],curr[1]] = 1;
            image[curr[0]][curr[1]] = newColor;
            
            foreach(int[] dir in Directions){
                que.Enqueue(new int[] { curr[0]+dir[0], curr[1]+dir[1] });
            }
        }
        
        return image;
    }
    
    private int[][] Directions = new int[4][]{
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };
}