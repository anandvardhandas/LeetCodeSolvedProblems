public class Solution {
    public void GameOfLife(int[][] board) {
        int m = board.Length, n = board[0].Length;
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                int[] cells = GetNearByCells(board, m, n, i, j);
                int lives = cells[0], deads = cells[1];
                if(board[i][j] == 1 || board[i][j] == -1){
                    if(lives < 2){
                        board[i][j] = -1;
                    }
                    else if(lives > 3){
                        board[i][j] = -1;
                    }
                }
                else{
                    if(lives == 3){
                        board[i][j] = 2;
                    }
                }
            }
        }
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(board[i][j] == -1){
                    board[i][j] = 0;
                }
                else if(board[i][j] == 2){
                    board[i][j] = 1;
                }
            }
        }
    }
    
    private int[] GetNearByCells(int[][] board, int m, int n, int i, int j){
        int lives = 0, deads = 0;
        foreach(int[] dir in Directions){
            int row = i + dir[0];
            int col = j + dir[1];
            if(row >= 0 && row < m && col >= 0 && col < n){
                if(board[row][col] == 1 || board[row][col] == -1){
                    lives++;
                }
                else{
                    deads++;
                }
            }
        }
        
        return new int[] { lives, deads };
    }
    
    private int[][] Directions = new int[8][]{
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 },
        new int[] { 1, 1 },
        new int[] { -1, -1 },
        new int[] { 1, -1 },
        new int[] { -1, 1 }
    };
}