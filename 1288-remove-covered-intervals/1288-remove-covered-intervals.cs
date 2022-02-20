public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        Array.Sort(intervals, new MyComparer());
        
        int left = intervals[0][0], right = intervals[0][1];
        int removed = 0;
        for(int i = 1; i < intervals.Length; i++){
            if(intervals[i][0] >= left && intervals[i][1] <= right){
                removed++;
            }
            else{
                if(intervals[i][1] > right){
                    left = intervals[i][0];
                    right = intervals[i][1];
                }
            }
        }
        
        return intervals.Length-removed;
    }
}

public class MyComparer : IComparer<int[]>
{
    public int Compare(int[] x, int[] y)
    {
        if (x[0] < y[0])
            return -1;
        else if (x[0] > y[0])
            return 1;
        else
        {
            if (x[1] < y[1])
                return 1;
            else if (x[1] > y[1])
                return -1;
            else
                return 0;

        }
    }
}