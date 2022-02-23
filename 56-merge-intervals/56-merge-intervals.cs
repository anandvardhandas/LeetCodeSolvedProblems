public class Solution {
    public int[][] Merge(int[][] intervals) {
        int len = intervals.GetLength(0);
        
        //Sort Logic
        Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
        
        List<int[]> result = new List<int[]>();
        int[] merged = new int[] { intervals[0][0], intervals[0][1]};
        for(int i = 1; i < len; i++){
            if(intervals[i][0] <= merged[1]){
                int greater = merged[1] > intervals[i][1] ? merged[1] : intervals[i][1];
                merged = new int[] { merged[0], greater };
            }
            else{
                result.Add(merged);
                merged = new int[] { intervals[i][0], intervals[i][1]};
            }
        }
        
        result.Add(merged);
        
        return result.ToArray();
    }
}