public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
        List<int[]> result = new List<int[]>();
        if(firstList == null || firstList.Length == 0 || secondList == null || secondList.Length == 0)
            return result.ToArray();
        
        int len1 = firstList.Length, len2 = secondList.Length;
        
        int i = 0, j = 0;
        int start = 0, end = 0;
        
        while(i < len1 && j < len2){
            if(firstList[i][0] > secondList[j][1]){
                j++;
                continue;
            }
            else if(secondList[j][0] > firstList[i][1]){
                i++;
                continue;
            }
            
            start = Math.Max(firstList[i][0], secondList[j][0]);
            end = Math.Min(firstList[i][1], secondList[j][1]);
            
            if(firstList[i][1] <= secondList[j][1]){
                i++;
            }
            else{
                j++;
            }
            
            result.Add(new int[] { start, end });
        }
        
        return result.ToArray();
    }
}