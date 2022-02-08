class LRUCache {
    public ConcurrentHashMap<Integer,Node> map;
    public int cap;
    public int size;
    public DList list;
    public LRUCache(int capacity) {
        map = new ConcurrentHashMap<>();
        cap = capacity;
        size = 0;
        list = new DList();
    }
    
    public int get(int key) {
        if(map.containsKey(key)){
            Node node = map.get(key);
            
            list.Remove(node);
            list.Add(node);
            
            map.put(key, node);
            
            return node.val;
        }
        else
            return -1;
    }
    
    public void put(int key, int value) {
        if(map.containsKey(key)){
           Node node = map.get(key);
            node.val = value;
            
            list.Remove(node);
            list.Add(node);
            
            map.put(key, node);
        }
        else{
            if(size == cap){
                Node removed = list.RemoveLast();
                size--;
                map.remove(removed.key);
            }
            
            Node node = new Node();
            node.key = key;
            node.val = value;
            
            list.Add(node);
            
            map.put(key, node);
            
            size++;
        }
    }
}

 class DList{
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
    }
    
    public void Remove(Node node){
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }
    
    public Node RemoveLast(){
        Node node = tail.prev;
        Remove(tail.prev);
        return node;
    }
    
}

 class Node{
    public int key;
    public int val;
    public Node next;
    public Node prev;
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.get(key);
 * obj.put(key,value);
 */