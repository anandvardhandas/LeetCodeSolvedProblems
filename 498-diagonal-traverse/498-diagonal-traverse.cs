public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        int m = mat.Length, n = mat[0].Length;
        
        List<int> result = new List<int>();
        int index = 0;
        
        //down the rows
        bool reverse = false;
        for(int i = 0; i < m; i++){
            int row = i, col = 0;
            List<int> res = new List<int>();
            while(row >= 0 && col < n){
                res.Add(mat[row][col]);
                if(row-1 >= 0 && col+1 < n){
                    row--;
                    col++;
                }
                else
                    break;
            }
            
            if(reverse){
                res.Reverse();
                reverse = false;
            }
            else{
                reverse = true;
            }
            
            result.AddRange(res);
        }
        
        //Console.WriteLine("done");
        
        //reverse = false;
        for(int j = 1; j < n; j++){
            int row = m-1, col = j;
            List<int> res = new List<int>();
            while(row >= 0 && col < n){
                res.Add(mat[row][col]);
                if(row-1 >= 0 && col+1 < n){
                    row--;
                    col++;
                }
                else
                    break;
            }
            
            if(reverse){
                res.Reverse();
                reverse = false;
            }
            else{
                reverse = true;
            }
            
            result.AddRange(res);
        }
        
        return result.ToArray();
    }
}