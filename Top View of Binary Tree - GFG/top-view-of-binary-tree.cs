// { Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Node
{
    public int data;
    public Node left;
    public Node right;

    public Node(int key)
    {
        this.data = key;
        this.left = null;
        this.right = null;
    }
}

namespace DriverCode
{
    class GFG
    {
        // Function to Build Tree
        public Node buildTree(string str)
        {
            // Corner Case
            if (str.Length == 0 || str[0] == 'N')
                return null;

            // Creating vector of strings from input
            // string after spliting by space
            var ip = str.Split(' ');



            Node root = new Node(int.Parse(ip[0]));


            // Push the root to the queue
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            // Starting from the second element
            int i = 1;
            while (queue.Count != 0 && i < ip.Length)
            {

                // Get and remove the front of the queue
                Node currNode = queue.Peek();
                queue.Dequeue();

                // Get the current node's value from the string
                string currVal = ip[i];

                // If the left child is not null
                if (currVal != "N")
                {

                    // Create the left child for the current node
                    currNode.left = new Node(int.Parse(currVal));

                    // Push it to the queue
                    queue.Enqueue(currNode.left);
                }

                // For the right child
                i++;
                if (i >= ip.Length)
                    break;
                currVal = ip[i];

                // If the right child is not null
                if (currVal != "N")
                {

                    // Create the right child for the current node
                    currNode.right = new Node(int.Parse(currVal));

                    // Push it to the queue
                    queue.Enqueue(currNode.right);
                }
                i++;
            }

            return root;
        }
        
        void inorder(Node root){
            if(root==null) return;
            inorder(root.left);
            Console.Write(root.data + " ");
            inorder(root.right);
        }
        
        
        

        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                var gfg = new GFG();
                var str = Console.ReadLine().Trim();
                var root = gfg.buildTree(str);
                Solution obj = new Solution();
                var res = obj.topView(root);
                foreach(int i in res){
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}// } Driver Code Ends


//User function Template for C#

/*  A binary tree Node
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int key)
        {
            this.data = key;
            this.left = null;
            this.right = null;
        }
    }
*/
class Solution
{
    
    //Function to return a list of nodes visible from the top view 
    //from left to right in Binary Tree.
    public List<int> topView(Node root)
    {
        //Your code here
        Node curr = root;
        
        SortedDictionary<int,int> map = new SortedDictionary<int,int>();
        Queue<TreeNode> que = new Queue<TreeNode>();
        que.Enqueue(new TreeNode(curr, 0));
        
        while(que.Count > 0){
            int size = que.Count;
            for(int i = 1; i <= size; i++){
                TreeNode node = que.Dequeue();
                if(!map.ContainsKey(node.level)){
                    map.Add(node.level, node.node.data);
                }
                
                if(node.node.left != null){
                    que.Enqueue(new TreeNode(node.node.left, node.level-1));
                }
                
                if(node.node.right != null){
                    que.Enqueue(new TreeNode(node.node.right, node.level+1));
                }
            }
        }
        
        return map.Values.ToList();
    }
}

class TreeNode
{
    public Node node;
    public int level;
    
    public TreeNode(Node _node = null, int _level = 0){
        this.node = _node;
        this.level = _level;
    }
}