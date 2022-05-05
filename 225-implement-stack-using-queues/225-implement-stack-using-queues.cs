public class MyStack {
    Queue<int> que1;
    Queue<int> que2;
    public MyStack() {
        que1 = new Queue<int>();
        que2 = new Queue<int>();
    }
    
    public void Push(int x) {
        while(que1.Count > 0){
            que2.Enqueue(que1.Dequeue());
        }
        
        que1.Enqueue(x);
        
        while(que2.Count > 0){
            que1.Enqueue(que2.Dequeue());
        }
    }
    
    public int Pop() {
        return que1.Dequeue();
    }
    
    public int Top() {
        return que1.Peek();
    }
    
    public bool Empty() {
        return que1.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */