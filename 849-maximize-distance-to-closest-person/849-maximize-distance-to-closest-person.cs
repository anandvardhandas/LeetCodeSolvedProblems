public class Solution {
    public int MaxDistToClosest(int[] seats) {
        
        int max = 0;
        
        int cl = -1, cr = -1, cmax = 0;
        
        for(int i = 0; i < seats.Length; i++){
            if(seats[i] == 1){
                cl = -1;
                cr = -1;
            }
            else{
                if(cl == -1){
                    cl = i;
                    cr = i;
                }
                else{
                    cr = i;
                }
                
                cmax = cr-cl+1;
                //updating max based on condition
                if(cl == 0 || cr == seats.Length-1){
                    if(cmax > max)
                        max = cmax;
                }
                else{
                    int mid = cl + (cr-cl)/2;
                    if(mid-cl+1 > max)
                        max = mid-cl+1;
                }
            }
        }
        
       return max;
        
    }
}