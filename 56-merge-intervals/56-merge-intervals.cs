public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
        
        List<int[]> result = new List<int[]>();
        
        int start = intervals[0][0], end = intervals[0][1];
        
        for(int i = 1; i < intervals.Length; i++){
            if(intervals[i][0] <= end){
                end = Math.Max(end, intervals[i][1]);
            }
            else{
                result.Add(new int[] { start, end });
                start = intervals[i][0];
                end = intervals[i][1];
            }
        }
        
        result.Add(new int[] { start, end });
        
        return result.ToArray();
    }
}