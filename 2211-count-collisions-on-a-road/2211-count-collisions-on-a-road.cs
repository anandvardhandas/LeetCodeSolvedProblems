public class Solution {
    public int CountCollisions(string directions) {
        int len = directions.Length;
        int prevRCount = 1;
        int total = 0;
        char prev = directions[0];
        for(int i = 1; i < len; i++){
            char c = directions[i];
            if(c == 'L'){
                if(prev == 'R'){
                    total += 2;
                    prev = 'S';
                    if(prevRCount > 1){
                        total += prevRCount-1;
                    }
                    prevRCount = 1;
                }
                else if(prev == 'S'){
                    total += 1;
                }
            }
            else if(c == 'S'){
                if(prev == 'R'){
                    total += prevRCount*1;
                    prev = 'S';
                    prevRCount = 1;
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
                    prevRCount++;
                }
            }
        }
        
        return total;
    }
}