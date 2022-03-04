public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        if(poured == 0)
            return 0;
        
        List<double> prev = new List<double>();
        
        prev.Add((double)poured);
        
        for(int query = 1; query <= query_row; query++){
            List<double> curr = new List<double>();
            curr.Add(Math.Max(0, (prev[0]-1)/2));
            for(int i = 1;  i < prev.Count; i++){
                curr.Add(Math.Max(0, (prev[i-1]-1)/2) + Math.Max(0, (prev[i]-1)/2));
            }
            curr.Add(Math.Max(0, (prev[0]-1)/2));
            
            prev = new List<double>(curr);
        }
        
        return Math.Min(1, prev[query_glass]);
    }
}