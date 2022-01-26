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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        IList<int> result = new List<int>();
        
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode curr = root1;
        while(curr != null || st.Count > 0){
            while(curr != null){
                st.Push(curr);
                curr = curr.left;
            }
            
            curr = st.Pop();
            list1.Add(curr.val);
            curr = curr.right;
        }
        
        st = new Stack<TreeNode>();
        curr = root2;
        while(curr != null || st.Count > 0){
            while(curr != null){
                st.Push(curr);
                curr = curr.left;
            }
            
            curr = st.Pop();
            list2.Add(curr.val);
            curr = curr.right;
        }
        
        //Merge the two sorted list
        
        int i = 0, j = 0;
        while(i < list1.Count && j < list2.Count){
            if(list1[i] <= list2[j]){
                result.Add(list1[i]);
                i++;
            }
            else{
                result.Add(list2[j]);
                j++;
            }
        }
        
        while(i < list1.Count){
            result.Add(list1[i]);
            i++;
        }
        
        while(j < list2.Count){
            result.Add(list2[j]);
            j++;
        }
        
        return result;
    }
}