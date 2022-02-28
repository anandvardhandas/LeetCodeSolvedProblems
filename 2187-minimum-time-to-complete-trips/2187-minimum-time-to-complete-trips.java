class Solution {
    public long minimumTime(int[] time, int totalTrips) {
        long lt = 1;
        long rt = 100000000000000L;
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
        
        for(int i = 0; i < time.length; i++){
            total = total + (sec/time[i]);
        }
        
        return total;
    }
}