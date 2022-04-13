public class MovingAverage {
    Queue<int> que = new Queue<int>();
    private int size = 0;
    private int sum = 0;
    public MovingAverage(int size) {
        this.size = size;
    }
    
    public double Next(int val) {
        if(que.Count == size){
            sum -= que.Dequeue();
            que.Enqueue(val);
            
            sum += val;
        }
        else{
            que.Enqueue(val);
            sum += val;
        }
        
        return (double)sum/que.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */