public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        List<List<Node>> result = new List<List<Node>>();
        Helper(n, 0, new HashSet<int>(), new HashSet<int>(), new HashSet<int>(), new List<Node>(), result);
        
        IList<IList<string>> res = new List<IList<string>>();
        foreach(List<Node> list in result){
            IList<string> resItem = new List<string>();
            foreach(Node node in list){
                resItem.Add(FormResult(n, node.y));
            }
            res.Add(resItem);
        }
        
        return res;
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
    
    private string FormResult(int n, int col){
        List<char> list = new List<char>();
        for(int i = 0; i < n; i++){
            list.Add('.');
        }
        
        list[col] = 'Q';
        
        return new string(list.ToArray());
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