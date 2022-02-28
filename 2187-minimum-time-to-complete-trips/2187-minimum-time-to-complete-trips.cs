public class Solution {
    public long MinimumTime(int[] time, int totalTrips) {
        int len = time.Length;
        
        long lt = 1;
        long rt = 100000000000000;
        while(lt < rt){
            long mt = (lt + (rt-lt)/2);
            long midtrips = GetTrips(time, mt);
            
            if(midtrips < totalTrips){
                lt = mt+1;
            }
            else if(midtrips >= totalTrips){
                rt = mt;
            }
        }
        
        return lt;
        
    }
    
    private long GetTrips(int[] time, long sec){
        long total = 0;
        
        for(int i = 0; i < time.Length; i++){
            total = total + (sec/time[i]);
        }
        
        return total;
    }
}