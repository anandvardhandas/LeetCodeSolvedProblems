public class MyHashSet {
    int[] map;
    public MyHashSet() {
        map = new int[10000000+1];
    }
    
    public void Add(int key) {
        map[key] = 1;
    }
    
    public void Remove(int key) {
        map[key] = -1;
    }
    
    public bool Contains(int key) {
        return map[key] == 1;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */