public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new List<int[]>();
        int len = intervals.Length;
        
        int i = 0;
        
        //Adding all intervals starting before new interval
        while(i < len && intervals[i][1] < newInterval[0]){
            result.Add(intervals[i]);
            i++;
        }
        
        int start = newInterval[0];
        int end = newInterval[1];
        
        //merging the intervals in between
        while(i < len && newInterval[1] >= intervals[i][0]){
           start = Math.Min(start, intervals[i][0]);
           end = Math.Max(end, intervals[i][1]);
           i++;
        }
        
        result.Add(new int[] { start, end });
        
        //adding all intervals starting after new intervals
        while(i < len && intervals[i][0] > newInterval[1]){
            result.Add(intervals[i]);
            i++;
        }
        
        return result.ToArray();
    }
}