public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        Array.Sort(costs, Comparer<int[]>.Create((x,y) => {
            return (x[1]-x[0]).CompareTo(y[1]-y[0]);
        }));
        
        int n = costs.Length/2;
        
        int totalcost = 0;
        for(int i = 0; i < costs.Length; i++){
            if(i < n){
                totalcost += costs[i][1];
            }
            else{
                totalcost += costs[i][0];
            }
        }
        
        return totalcost;
    }
}