/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();
        
        Dictionary<int,PriorityQueue<Node,Node>> map = new Dictionary<int,PriorityQueue<Node,Node>>();
        
        Queue<Node> que = new Queue<Node>();
        que.Enqueue(new Node(root, 0));
        int level = 1;
        
        int mincol = 0, maxcol = 0;
        
        while(que.Count > 0){
            int size = que.Count;
            for(int i = 1; i <= size; i++){
                Node node = que.Dequeue();
                
                int col = node.col;
                
                mincol = Math.Min(mincol,col);
                maxcol = Math.Max(maxcol,col);
                
                if(!map.ContainsKey(col)){
                    PriorityQueue<Node,Node> pq = 
                    new PriorityQueue<Node,Node>(Comparer<Node>.Create((x,y) => {
                        if(x.level != y.level){
                            return x.level.CompareTo(y.level);
                        }
                        else{
                            return x.val.CompareTo(y.val);
                        }
                    }));
                    
                    Node newnode = new Node(node.root.val,level,col);
                    pq.Enqueue(newnode,newnode);
                    map.Add(col, pq);
                }
                else{
                    Node newnode = new Node(node.root.val,level,col);
                    map[col].Enqueue(newnode,newnode);
                }
                
                if(node.root.left != null){
                    que.Enqueue(new Node(node.root.left, col-1));
                }
                
                if(node.root.right != null){
                    que.Enqueue(new Node(node.root.right, col+1));
                }
            }
            
            level++;
        }
        
        
        for(int j = mincol; j <= maxcol; j++){
            var poppedpq = map[j];
            IList<int> res = new List<int>();
            while(poppedpq.Count > 0){
                Node popped = poppedpq.Dequeue();
                res.Add(popped.val);
            }
            
            result.Add(res);
        }
        
        return result;
    }
}

public class Node{
    public int level;
    public int val;
    public int col;
    public TreeNode root;
    public Node(int _val, int _level, int _col){
        level = _level;
        val = _val;
        col = _col;
    }
    
    public Node(TreeNode _root, int _col){
        root = _root;
        col = _col;
    }
}