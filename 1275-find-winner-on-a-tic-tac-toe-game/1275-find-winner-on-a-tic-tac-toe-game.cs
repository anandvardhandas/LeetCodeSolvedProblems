public class Solution {
    public string Tictactoe(int[][] moves) {
        int n = 3;
        
        int[] rows = new int[3];
        int[] cols = new int[3];
        int diag = 0, adiag = 0;
        int player = 1;
        for(int i = 0; i < moves.Length; i++){
            int row = moves[i][0], col = moves[i][1];
            rows[row] += player;
            cols[col] += player;
            
            if(row == col){
                diag += player;
            }
            
            if(row+col == n-1){
                //anti diag
                adiag += player;
            }
            
            if(i >= 4){
                //check winning
                if(Math.Abs(rows[row]) == n || Math.Abs(cols[col]) == n || Math.Abs(diag) == n || Math.Abs(adiag) == n){
                    if(player == 1)
                        return "A";
                    else
                        return "B";
                }
            }
            
            player = player * -1; //switch player
        }
        
        if(moves.Length < 9)
            return "Pending";
        
        return "Draw";
    }
    
    
}