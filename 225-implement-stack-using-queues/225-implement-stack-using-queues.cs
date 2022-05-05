public class MyStack {
    Queue<int> que1;
    public MyStack() {
        que1 = new Queue<int>();
    }
    
    public void Push(int x) {
        que1.Enqueue(x);
        int count = que1.Count;
        while(count > 1){
            que1.Enqueue(que1.Dequeue());
            count--;
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