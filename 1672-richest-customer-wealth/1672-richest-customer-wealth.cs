public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int m = accounts.Length, n = accounts[0].Length;
        int maxwealth = 0;
        for(int i = 0; i < m; i++){
            int currwealth = 0;
            for(int j = 0; j < n; j++){
                currwealth += accounts[i][j];
            }
            
            maxwealth = Math.Max(maxwealth, currwealth);
        }
        
        return maxwealth;
    }
}