public class Solution {
    private int count;
    public int TotalNQueens(int n) {
        Helper(n, 0, new HashSet<int>(), new HashSet<int>(), new HashSet<int>());
        return this.count;
    }
    
    private void Helper(int n, int row, HashSet<int> cols, HashSet<int> diag, HashSet<int> antidiag){
        if(row == n){
            this.count++;
            return;
        }
        
        for(int col = 0; col < n; col++){
            bool exists = CheckIfQueenNear(row, col, cols, diag, antidiag);
            if(!exists){
                cols.Add(col);
                diag.Add(row-col);
                antidiag.Add(row+col);
                Helper(n, row+1, cols, diag, antidiag);
                cols.Remove(col);
                diag.Remove(row-col);
                antidiag.Remove(row+col);
            }
        }
    }
    
    private bool CheckIfQueenNear(int row, int col, HashSet<int> cols, HashSet<int> diag, HashSet<int> antidiag){
        if(cols.Contains(col) || diag.Contains(row-col) || antidiag.Contains(row+col)){
            return true;
        }
        
        return false;
    }
}

public class Node{
    public int x;
    public int y;
    public Node(int _x, int _y){
        x = _x;
        y = _y;
    }
}