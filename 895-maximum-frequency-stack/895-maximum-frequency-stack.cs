public class FreqStack
{
    public Dictionary<int, DLL> freqList;
    public Dictionary<int, int> valMap;
    public Dictionary<int, int> freqMap;
    public int maxFreq = 1;
    public FreqStack()
    {
        freqList = new Dictionary<int, DLL>();
        valMap = new Dictionary<int, int>();
        freqMap = new Dictionary<int, int>();
    }

    public void Push(int val)
    {
        if (valMap.ContainsKey(val))
        {
            int freq = valMap[val];
            AddToFreqList(val, freq + 1);
            freq = freq + 1;
            valMap[val] = freq;

            maxFreq = Math.Max(maxFreq, freq);

            AddToFreqMap(freq);
        }
        else
        {
            valMap.Add(val, 1);
            AddToFreqList(val, 1);

            AddToFreqMap(1);
        }
    }

    public int Pop()
    {
        DLL dll = freqList[maxFreq];
        int returnedVal = dll.Get();
        valMap[returnedVal]--;
        if(valMap[returnedVal] == 0)
        {
            valMap.Remove(returnedVal);
        }

        RemoveFromFreqMap(maxFreq);
        if (freqMap[maxFreq] == 0 && maxFreq > 1)
        {
            maxFreq--;
        }

        return returnedVal;
    }

    private void AddToFreqList(int val, int freq)
    {
        if (freqList.ContainsKey(freq))
        {
            DLL dll = freqList[freq];
            dll.Add(val);
        }
        else
        {
            DLL dll = new DLL();
            dll.Add(val);
            freqList.Add(freq, dll);
        }
    }

    private void AddToFreqMap(int freq)
    {
        if (freqMap.ContainsKey(freq))
        {
            freqMap[freq]++;
        }
        else
        {
            freqMap.Add(freq, 1);
        }
    }

    private void RemoveFromFreqMap(int freq)
    {
        freqMap[freq]--;
    }
}


public class DLL
{
    public Node head;
    public Node tail;

    public DLL()
    {
        head = new Node();
        tail = new Node();

        head.next = tail;
        tail.prev = head;
    }

    public void Add(int val)
    {
        Node node = new Node(val);

        node.next = head.next;
        node.next.prev = node;
        head.next = node;
        node.prev = head;
    }

    public void Remove()
    {
        head.next.next.prev = head;
        head.next = head.next.next;
    }

    public int Get()
    {
        int returnedVal = head.next.val;
        Remove();
        return returnedVal;
    }
}

public class Node
{
    public int val;
    public Node next;
    public Node prev;

    public Node(int _val = 0, Node _next = null, Node _prev = null)
    {
        this.val = _val;
        this.next = _next;
        this.prev = _prev;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */