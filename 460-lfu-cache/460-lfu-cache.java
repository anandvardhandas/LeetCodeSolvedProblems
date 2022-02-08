class LFUCache {
    HashMap<Integer,DList> freqMap;
    HashMap<Integer,Node> nodeMap;
    public int cap;
    public int size;
    public int minFreq;
    public LFUCache(int capacity) {
        freqMap = new HashMap<>();
        nodeMap = new HashMap<>();
        cap = capacity;
        size = 0;
        
        freqMap.put(1, new DList());
        minFreq = 1;
    }
    
    public int get(int key) {
        if(nodeMap.containsKey(key)){
            Node node = nodeMap.get(key);
            UpdateFreqMap(node);
            return node.val;
        }
        else
            return -1;
    }
    
    public void put(int key, int value) {
        if(cap == 0)
            return;
        
        if(nodeMap.containsKey(key)){
            Node node = nodeMap.get(key);
            node.val = value;
            UpdateFreqMap(node);
            nodeMap.put(key, node);
        }
        else{
            if(size == cap){
                DList oldList = freqMap.get(minFreq);
                Node oldNode = oldList.RemoveLast();
                nodeMap.remove(oldNode.key);
                
                freqMap.put(minFreq, oldList);
                
                size--;
            }
            
            Node node = new Node();
            node.key = key;
            node.val = value;
            
            DList newList = freqMap.get(node.freq);
            newList.Add(node);
            freqMap.put(node.freq, newList);
            nodeMap.put(key, node);
            minFreq = node.freq;
            size++;
        }
    }
    
    private void UpdateFreqMap(Node node){
        DList oldList = freqMap.get(node.freq);
        oldList.Remove(node);
        nodeMap.remove(node.key);
        
        if(oldList.size == 0 && node.freq == minFreq){
            minFreq++;
        }
        
        node.freq++;
        
        DList newList = freqMap.get(node.freq);
        if(newList == null){
            newList = new DList();
        }
        
        newList.Add(node);
        freqMap.put(node.freq, newList);
        nodeMap.put(node.key, node);
    }
}

class DList{
    public int size;
    public Node head;
    public Node tail;
    
    public DList(){
        head = new Node();
        tail = new Node();
        head.next = tail;
        tail.prev = head;
    }
    
    public void Add(Node node){
        node.next = head.next;
        node.prev = head;
        head.next.prev = node;
        head.next = node;
        
        size++;
    }
    
    public void Remove(Node node){
        node.prev.next = node.next;
        node.next.prev = node.prev;
        
        size--;
    }
    
    public Node RemoveLast(){
        Node node = tail.prev;
        Remove(tail.prev);
        return node;
    }
}

class Node{
    public int freq = 1;
    public int key;
    public int val;
    public Node next;
    public Node prev;
    
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.get(key);
 * obj.put(key,value);
 */