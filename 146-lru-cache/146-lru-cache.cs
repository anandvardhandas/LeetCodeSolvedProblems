public class LRUCache {
    public Dictionary<int, Node> map;
    public int cap;
    public int currlen;
    public Node head;
    public Node tail;
    public LRUCache(int capacity) {
        map = new Dictionary<int,Node>();
        cap = capacity;
        this.head = new Node();
        this.tail = new Node();
        this.head.next = this.tail;
        this.tail.prev = this.head;
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key)){
            Node curr = map[key];
            
            //removing the node from linked list
            curr.prev.next = curr.next;
            curr.next.prev = curr.prev;
            
            //adding on front of linked list
            curr.next = this.head.next;
            this.head.next.prev = curr;
            this.head.next = curr;
            curr.prev = this.head;
            
            //update in map again
            this.map[key] = curr;
            
            return curr.val;
        }
        
        return -1;
    }
    
    public void Put(int key, int value) {
        if(!map.ContainsKey(key)){
            this.currlen++; //increasing current length
            
            //adding on front of linked list
            Node curr = new Node(key, value);
            curr.next = this.head.next;
            this.head.next.prev = curr;
            this.head.next = curr;
            curr.prev = this.head;
            
            this.map.Add(key, curr);
            
            if(this.currlen > this.cap){
                //remove from dictionary
                int evictKey = this.tail.prev.key; 
                this.map.Remove(evictKey);
                
                //evict - remove the node just before tail
                this.tail.prev = this.tail.prev.prev;
                this.tail.prev.next = this.tail;
                
                this.currlen--;
            }
        }
        else{
            //Call get just to remove the node from its original position and put it in front of linked list
            Get(key);
            //now just need to update its value
            this.head.next.val = value;
            //update dictionary
            this.map[key] = this.head.next;
        }
    }
}

public class Node{
    public Node next;
    public Node prev;
    public int key;
    public int val;
    public Node(int _key = 0, int _val = 0, Node _next = null, Node _prev = null){
        this.key = _key;
        this.val = _val;
        this.next = _next;
        this.prev = _prev;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */