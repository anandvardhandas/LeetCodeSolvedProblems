public class Solution {
    public int TotalNQueens(int n) {
        List<List<Node>> result = new List<List<Node>>();
        Helper(n, 0, new HashSet<int>(), new HashSet<int>(), new HashSet<int>(), new List<Node>(), result);
        return result.Count;
    }
    
    private void Helper(int n, int row, HashSet<int> cols, HashSet<int> diag, HashSet<int> antidiag, List<Node> temp, List<List<Node>> result){
        if(row == n){
            result.Add(new List<Node>(temp));
            return;
        }
        
        for(int col = 0; col < n; col++){
            bool exists = CheckIfQueenNear(row, col, cols, diag, antidiag);
            if(!exists){
                temp.Add(new Node(row,col));
                cols.Add(col);
                diag.Add(row-col);
                antidiag.Add(row+col);
                Helper(n, row+1, cols, diag, antidiag, temp, result);
                temp.RemoveAt(temp.Count-1);
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