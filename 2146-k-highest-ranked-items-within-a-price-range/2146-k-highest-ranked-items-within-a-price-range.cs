public class Solution {
    public IList<IList<int>> HighestRankedKItems(int[][] grid, int[] pricing, int[] start, int k) {
        IList<IList<int>> result = new List<IList<int>>();
        PriorityQueue pq = new PriorityQueue(k);
        
        int[,] visited = new int[grid.Length, grid[0].Length];
        //now doing a bfs traversal to reach all cells and to calculate distance from start cell
        Queue<int[]> que = new Queue<int[]>();
        que.Enqueue(new int[] { start[0],start[1], 0 });
        while(que.Count > 0){
            int[] node = que.Dequeue();
            if(node[0] < 0 || node[0] >= grid.Length || node[1] < 0 || node[1] >= grid[0].Length || visited[node[0],node[1]] == 1 || grid[node[0]][node[1]] == 0)
                continue;
            
            visited[node[0],node[1]] = 1;
            
            foreach(int[] dir in Directions){
                que.Enqueue(new int[] { node[0]+dir[0], node[1]+dir[1], node[2]+1 });
            }
            
            Node currentNode = new Node(node[2], grid[node[0]][node[1]], node[0], node[1]);
            if(grid[node[0]][node[1]] != 1 && grid[node[0]][node[1]] >= pricing[0] && grid[node[0]][node[1]] <= pricing[1]){
                if(pq.count < k){
                    pq.Enqueue(currentNode);
                }
                else{
                    if(!ComparedTo(currentNode, pq.Peek())){
                        pq.Dequeue();
                        pq.Enqueue(currentNode);
                    }
                }
            }
            
        }
        
        //adding to the result
        while(pq.count > 0){
            Node node = pq.Dequeue();
            result.Add(new List<int>() { node.row, node.col });
        }
        
        return result.Reverse().ToList();
    }
    
    public static bool ComparedTo(Node node1, Node node2){
        if(node1.dist > node2.dist)
            return true;
        else if(node1.dist == node2.dist && node1.price > node2.price)
            return true;
        else if(node1.dist == node2.dist && node1.price == node2.price && node1.row > node2.row)
            return true;
        else if(node1.dist == node2.dist && node1.price == node2.price && node1.row == node2.row && node1.col > node2.col)
            return true;
        else
            return false;
    }
    
    private int[][] Directions = new int[4][] {
        new int[] { 0,1 },
        new int[] { 0,-1 },
        new int[] { 1,0 },
        new int[] { -1,0 }
    };
}

public class Node
{
    public int dist;
    public int price;
    public int row;
    public int col;
    
    public Node(int _dist, int _price, int _row, int _col)
    {
        dist = _dist;
        price = _price;
        row = _row;
        col = _col;
    }
}

public class PriorityQueue
{
    public Node[] nums;
    public int count;
    private int cap;
    public PriorityQueue(int _capacity)
    {
        cap = _capacity;
        nums = new Node[cap];
    }

    public Node Peek()
    {
        if (count > 0)
            return nums[0];
        return null;
    }

    public void Enqueue(Node node)
    {
        if (count < cap)
        {
            nums[count] = node;
            count++;
            int i = count - 1;
            while (i > 0 && Solution.ComparedTo(nums[i], nums[(i-1)/2]))
            {
                //Swap
                Node temp = nums[i];
                nums[i] = nums[(i - 1) / 2];
                nums[(i - 1) / 2] = temp;

                i = (i - 1) / 2;
            }
        }
    }
    
    public Node Dequeue()
    {
        if (count > 0)
        {
            Node result = nums[0];
            nums[0] = nums[count - 1];
            count--;

            int i = 0;
            while (2 * i + 1 < count)
            {
                int greater = 2 * i + 1;
                if (2 * i + 2 < count && Solution.ComparedTo(nums[2 * i + 2], nums[greater]))
                {
                    greater = 2 * i + 2;
                }

                if (Solution.ComparedTo(nums[greater], nums[i]))
                {
                    //swap
                    Node temp = nums[i];
                    nums[i] = nums[greater];
                    nums[greater] = temp;

                    i = greater;
                }
                else
                    break;
            }

            return result;
        }

        return null;
    }
}