public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length, n = board[0].Length;
        int[,] visited = new int[m,n];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(word[0] == board[i][j]){
                    if(!Helper(board, word, visited, 0, i, j))
                        visited = new int[m,n];
                    else
                        return true;
                }
            }
        }
        
        
        return false;
    }
    
    private bool Helper(char[][] board, string word, int[,] visited, int index, int i, int j){
        if(index == word.Length)
            return true;
        
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || visited[i,j] == 1 || word[index] != board[i][j])
            return false;
        
        visited[i,j] = 1;
        foreach(int[] item in Directions){
            if(Helper(board, word, visited, index+1, item[0]+i, item[1]+j))
                return true;
        }
        
        
        
        visited[i,j] = 0;
        return false;
        
    }
    
    private int[][] Directions = new int[4][] {
      new int[] { 1,0},
        new int[] { -1,0},
        new int[] { 0,1},
        new int[] { 0,-1}
    };
}