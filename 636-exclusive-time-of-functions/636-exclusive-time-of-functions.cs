public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) {
        
        int[] result = new int[n];
        
        Stack<Node> st = new Stack<Node>();
        
        foreach(string log in logs){
            string[] parts = log.Split(':');
            int fid = int.Parse(parts[0]);
            string pos = parts[1];
            int time = int.Parse(parts[2]);
            
            Node node = new Node(fid, 0, time);
            
            if(pos == "start"){
                st.Push(node);
            }
            else{
                Node popped = st.Pop();
                int interval = time-popped.time+1;
                int total = interval-popped.child;
                result[fid] += total;
                
                if(st.Count > 0){
                    st.Peek().child += interval;
                }
            }
        }
        
        return result;
    }
    
    
}

public class Node{
    public int fid;
    public int child;
    public int time;
    
    public Node(int _fid, int _child, int _time){
        fid = _fid;
        child = _child;
        time = _time;
    }
    
}