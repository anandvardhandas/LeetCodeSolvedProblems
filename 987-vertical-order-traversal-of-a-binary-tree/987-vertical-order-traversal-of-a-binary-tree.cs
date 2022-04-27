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
        if(root == null)
            return result;
        Queue<Node> que = new Queue<Node>();
        
        Dictionary<int,PriorityQueue<Node,Node>> map = new Dictionary<int,PriorityQueue<Node,Node>>();
        int maxcol = 0, mincol = 0;
        que.Enqueue(new Node(root,1,0));
        int level = 1;
        while(que.Count > 0){
            int size = que.Count;
            for(int i = 1; i <= size; i++){
                Node node = que.Dequeue();
                
                int col = node.col;
                
                maxcol = Math.Max(maxcol, col);
                mincol = Math.Min(mincol, col);
                
                if(map.ContainsKey(col)){
                    map[col].Enqueue(node,node);
                }
                else{
                    PriorityQueue<Node,Node> pq = new PriorityQueue<Node,Node>(Comparer<Node>.Create((x,y) => {
                        if(x.level != y.level){
                            return x.level.CompareTo(y.level);
                        }
                        else{
                            return x.root.val.CompareTo(y.root.val);
                        }
                    }));
                    
                    pq.Enqueue(node,node);
                    
                    map.Add(col,pq);
                        
                }
                
                if(node.root.left != null){
                    Node newnode = new Node(node.root.left, level+1, col-1);
                    que.Enqueue(newnode);
                }
                
                if(node.root.right != null){
                    Node newnode = new Node(node.root.right, level+1, col+1);
                    que.Enqueue(newnode);
                }
            }
            
            level++;
        }
        
        //Console.WriteLine(mincol);
        //Console.WriteLine(maxcol);
        
        
        for(int i = mincol; i<= maxcol; i++){
            var pqueue = map[i];
            IList<int> res = new List<int>();
            while(pqueue.Count > 0){
                Node pop = pqueue.Dequeue();
                res.Add(pop.root.val);
            }
            
            result.Add(res);
        }
        
        return result;
    }
}

public class Node{
    public int level;
    public TreeNode root;
    public int col;
    
    public Node(TreeNode _root, int _level, int _col){
        root = _root;
        level = _level;
        col = _col;
    }
}