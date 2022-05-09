public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        int len = intervals.Length;
        if(len <= 1)
            return true;
        
        Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
        
        int start = intervals[0][0], end = intervals[0][1];
        for(int i = 1; i < intervals.Length; i++){
            if(intervals[i][0] < end){
                return false;
            }
            else{
                start = intervals[i][0];
                end = intervals[i][1];
            }
        }
        
        return true;
    }
}