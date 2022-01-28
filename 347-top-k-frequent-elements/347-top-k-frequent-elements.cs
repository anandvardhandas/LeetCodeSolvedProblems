public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int len = nums.Length;
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0; i < len; i++){
            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i], 1);
            }
            else{
                map[nums[i]]++;
            }
        }
        
        PriorityQueue pq = new PriorityQueue(k);
        foreach(var item in map){
            if(pq.count < k){
                pq.Enqueue(new Node(item.Key, item.Value));
            }
            else{
                Node minElement = pq.Peek();
                if(item.Value > minElement.freq){
                    pq.Dequeue();
                    pq.Enqueue(new Node(item.Key, item.Value));
                }
            }
        }
        
        List<int> result = new List<int>();
        while(pq.count > 0){
            result.Add(pq.Dequeue().num);
        }
        
        return result.ToArray();
    }
}

public class Node
{
    public int num;
    public int freq;
    
    public Node(int _num, int _freq)
    {
        num = _num;
        freq = _freq;
    }
}

//Min heap
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
            while (i > 0 && nums[i].freq < nums[(i - 1) / 2].freq)
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
                if (2 * i + 2 < count && nums[2 * i + 2].freq < nums[greater].freq)
                {
                    greater = 2 * i + 2;
                }

                if (nums[greater].freq < nums[i].freq)
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