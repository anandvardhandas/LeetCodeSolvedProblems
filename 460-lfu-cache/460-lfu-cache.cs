public class LFUCache {
    Dictionary<int, DList> freqMap;
    Dictionary<int, Node> nodeMap;
    public int minFreq;
    public int cap;
    public int size;
    public LFUCache(int capacity) {
        this.minFreq = 1;
        this.freqMap = new Dictionary<int, DList>();
        this.freqMap.Add(1, new DList());
        
        this.nodeMap = new Dictionary<int,Node>();
        this.cap = capacity;
        this.size = 0;
    }
    
    public int Get(int key) {
        if(nodeMap.ContainsKey(key)){
            Node node = this.nodeMap[key];
            this.UpdateNodeInFreqMap(node);
            return node.val;
        }
        
        return -1;
    }
    
    public void Put(int key, int value) {
        if(cap == 0)
            return;
        
        if(this.nodeMap.ContainsKey(key)){
            Node node = this.nodeMap[key];
            node.val = value;
            this.UpdateNodeInFreqMap(node);
        }
        else{
            if(this.size == this.cap){
                DList oldList = this.freqMap[this.minFreq];
                Node lastNode = oldList.GetLastNode();
                if(lastNode != null){
                    this.nodeMap.Remove(lastNode.key);
                }
                
                oldList.RemoveLast();
                this.freqMap[this.minFreq] = oldList;
                this.size--;
                
                if(oldList.Length == 0){
                    this.minFreq++;
                }
            }
            
            Node node = new Node(key, value);
            
            DList existingList = this.freqMap[node.freq];
            existingList.AddNode(node);
            this.freqMap[node.freq] = existingList;
            this.nodeMap.Add(key, node);
            this.minFreq = node.freq;
            this.size++;
        }
    }
    
    private void UpdateNodeInFreqMap(Node node){
        DList list = freqMap[node.freq];
        list.RemoveNode(node);
        
        if(list.Length == 0 && node.freq == this.minFreq){
            this.minFreq++;
        }
        
        node.freq++;
        
        if(!freqMap.ContainsKey(node.freq)){
            DList newList = new DList();
            newList.AddNode(node);
            this.freqMap.Add(node.freq, newList);
        }
        else{
            DList existingList = this.freqMap[node.freq];
            existingList.AddNode(node);
        }
        
        this.nodeMap[node.key] = node;
    }
}


public class DList{
    public int Length;
    public Node head;
    public Node tail;
    
    public DList(){
        this.head = new Node();
        this.tail = new Node();
        this.head.next = this.tail;
        this.tail.prev = this.head;
    }
    
    public void AddNode(Node node){
        //adding to the front
        node.next = this.head.next;
        node.prev = this.head;
        this.head.next.prev = node;
        this.head.next = node;
        
        this.Length++;
    }
    
    public void RemoveNode(Node node){
        node.prev.next = node.next;
        node.next.prev = node.prev;
        
        this.Length--;
    }
    
    public void RemoveLast(){
        if(this.Length > 0)
            RemoveNode(this.tail.prev);
    }
    
    public Node GetLastNode(){
        if(this.Length > 0)
            return this.tail.prev;
        
        return null;
    }
    
}


public class Node{
    public int key;
    public int val;
    public int freq;
    public Node next;
    public Node prev;
    
    public Node(int _key = 0, int _val = 0, Node _next = null, Node _prev = null){
        this.key = _key;
        this.val = _val;
        this.next = _next;
        this.prev = _prev;
        this.freq = 1;
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */