public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int len = gas.Length;
        
        int totalgas = 0, totalcost = 0;
        for(int i = 0; i < len; i++){
            totalgas += gas[i];
            totalcost += cost[i];
        }
        
        if(totalcost > totalgas)
            return -1;
        
        int index = 0;
        while(index < len){
            if(gas[index] >= cost[index]){
                int tank = 0;
                int i = index;
                int count = 0;
                while(count < len){
                    tank = tank + gas[i];
                    if(tank >= cost[i]){
                        tank = tank - cost[i];
                        i = (i+1)%len;
                        count++;
                    }
                    else
                        break;
                }
                
                if(count == len)
                    return index;
                else if(count == len-1)
                    return -1;
                else{
                    index = i;
                }
            }
            
            index++;
        }
        
        return -1;
    }
}