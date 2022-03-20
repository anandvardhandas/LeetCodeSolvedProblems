public class Solution {
    public int CountCollisions(string directions) {
        
        
        int len = directions.Length;
        int pc = 1;
        int total = 0;
        char prev = directions[0];
        for(int i = 1; i < len; i++){
            char c = directions[i];
            if(c == 'L'){
                if(prev == 'R'){
                    total += 2;
                    prev = 'S';
                    if(pc > 1){
                        total += pc-1;
                    }
                    pc = 1;
                }
                else if(prev == 'S'){
                    total += 1;
                }
            }
            else if(c == 'S'){
                if(prev == 'R'){
                    total += pc*1;
                    prev = 'S';
                    pc = 1;
                }
                else if(prev == 'L'){
                    prev = 'S';
                }
            }
            else if(c == 'R'){
                if(prev == 'S'){
                    prev = 'R';
                }
                else if(prev == 'L'){
                    prev = 'R';
                }
                else if(prev == 'R'){
                    pc++;
                }
            }
        }
        
        return total;
    }
}