public class Solution {
    public int MinMoves(int target, int maxDoubles) {
        int steps = 0;
        while(target > 1){
            //if odd reduce by 1
            if(target % 2 == 1){
                target -= 1;
                steps++;
            }
            else{
                if(maxDoubles > 0){
                    target = target/2;
                    maxDoubles--;
                    steps++;
                }
                else{
                    steps = steps + target-1;
                    break;
                }
            }
        }
        
        return steps;
    }
}