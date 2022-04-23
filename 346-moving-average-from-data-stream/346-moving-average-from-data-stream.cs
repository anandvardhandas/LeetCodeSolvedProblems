public class MovingAverage {
    
    public int cap;
    public int total;
    public Queue<int> que;
    public MovingAverage(int size) {
        cap = size;
        total = 0;
        
        que = new Queue<int>();
    }
    
    public double Next(int val) {
        que.Enqueue(val);
        if(que.Count <= cap){
            total += val;
            
            return (double) total/que.Count;
            
        }
        else{
            int removed = que.Dequeue();
            total = total - removed;
            total = total + val;
            return (double) total/cap;
        }
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */