public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        Array.Sort(costs, Comparer<int[]>.Create((x,y) => {
            return (x[0]-x[1]).CompareTo(y[0]-y[1]);
        }));
        
        int n = costs.Length/2;
        
        int totalcost = 0;
        for(int i = 0; i < costs.Length; i++){
            if(i < n){
                totalcost += costs[i][0];
            }
            else{
                totalcost += costs[i][1];
            }
        }
        
        return totalcost;
    }
}