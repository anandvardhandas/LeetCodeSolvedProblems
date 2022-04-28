public class Solution {
    public int MinimumEffortPath(int[][] heights) {
        
        int low = 0, hi = 1000000;
        int ans = -1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            bool ispossible = IsPossible(heights, mid);
            if(ispossible){
                ans = mid;
                hi = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        
        return ans;
    }
    
    private bool IsPossible(int[][] heights, int mineffort){
        int m = heights.Length, n = heights[0].Length;
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
                int row = dir[0]+node.x;
                int col = dir[1]+node.y;
                
                if(row >= 0 && row < m && col >= 0 && col < n && visited[row,col] == 0){
                    int costdiff = Math.Abs(heights[row][col] - heights[node.x][node.y]);
                    if(costdiff <= mineffort){
                        que.Enqueue(new Node(row,col));
                        visited[row,col] = 1;
                    }
                }
            }
        }
        
        return false;
        
    }
    
    private int[][] Directions = new int[4][]{
        new int[] { 1,0 },
        new int[] { -1,0 },
        new int[] { 0,1 },
        new int[] { 0,-1 }
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