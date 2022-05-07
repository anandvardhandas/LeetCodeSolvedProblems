public class Solution {
    public string Tictactoe(int[][] moves) {
        int size = 3;
        int len = moves.Length;
        
        int[] row = new int[size];
        int[] col = new int[size];
        int diag = 0, antidiag = 0;
        
        int move = 1;
        for(int i = 0; i < len; i++){
            int r = moves[i][0], c = moves[i][1];
            
            row[r] += move;
            col[c] += move;
            
            if(r == c){
                //diag
                diag += move;
            }
            
            if(r+c == size-1){
                //anti diag
                antidiag += move;
            }
            
            
            if(Math.Abs(row[r]) == size || Math.Abs(col[c]) == size || Math.Abs(diag) == size || Math.Abs(antidiag) == size){
                if(move == 1){
                    return "A";
                }
                else{
                    return "B";
                }
            }
            
            if(move == 1){
                move = -1;
            }
            else{
                move = 1;
            }
        }
        
        
        if(len == size*size){
            return "Draw";
        }
        else{
            return "Pending";
        }
    }
}