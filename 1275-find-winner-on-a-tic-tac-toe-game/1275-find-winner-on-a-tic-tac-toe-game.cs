public class Solution {
    public string Tictactoe(int[][] moves) {
        int[,] grid = new int[3,3];
        bool fora = true;
        for(int i = 0; i < moves.Length; i++){
            if(fora){
                grid[moves[i][0],moves[i][1]] = 1;
                fora = false;
            }
            else{
                grid[moves[i][0],moves[i][1]] = -1;
                fora = true;
            }
            
            if(i >= 4){
                int num = 0;
                if(!fora){
                    num = 1;
                }
                else{
                    num = -1;
                }
                
                bool iswinner = Check(grid, moves[i][0],moves[i][1], num);
                if(iswinner){
                    if(!fora)
                        return "A";
                    else
                        return "B";
                }
            }
        }
        
        if(moves.Length < 9)
            return "Pending";
        
        return "Draw";
    }
    
    private bool Check(int[,] grid, int i, int j, int num){
        //row check
        bool same = true;
        for(int col = 0; col <= 2; col++){
            if(grid[i,col] != num){
                same = false;
                break;
            }
        }
        
        if(same)
            return true;
        
        //col check
        same = true;
        for(int row = 0; row <= 2; row++){
            if(grid[row,j] != num){
                same = false;
                break;
            }
        }
        
        if(same)
            return true;
        
        //diag check
        if(grid[0,0] == num && grid[1,1] == num && grid[2,2] == num){
            return true;
        }

        if(grid[2,0] == num && grid[1,1] == num && grid[0,2] == num){
            return true;
        }
        
        return false;
    }
}