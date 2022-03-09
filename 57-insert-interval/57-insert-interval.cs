public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int len = intervals.Length;
        List<int[]> result = new List<int[]>();
        
        //adding all intervals below start of new interval
        int i = 0;
        for(; i < len; i++){
            if(intervals[i][1] < newInterval[0])
                result.Add(intervals[i]);
            else
                break;
        }
        
        //merging in between the intervals
            int start = newInterval[0];
            int end = newInterval[1];

            while(i < len && newInterval[1] >= intervals[i][0]){
                start = Math.Min(intervals[i][0], start);
                end = Math.Max(end, intervals[i][1]);
                i++;
            }

            result.Add(new int[] { start, end });

            //adding all intervals after end of new interval
            for(; i < len; i++){
                if(intervals[i][0] > newInterval[1])
                    result.Add(intervals[i]);
            }
        
        return result.ToArray();
    }
}