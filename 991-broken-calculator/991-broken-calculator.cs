public class Solution {
    public int BrokenCalc(int startValue, int target) {
        if(target < startValue)
            return startValue-target;
        
        int steps = 0;
        while(target > startValue){
            if(target % 2 == 0)
                target = target/2;
            
            else if(target % 2 == 1)
                target++;
            
            steps++;
        }
        
        return steps + startValue-target;
            
    }
    
    
}