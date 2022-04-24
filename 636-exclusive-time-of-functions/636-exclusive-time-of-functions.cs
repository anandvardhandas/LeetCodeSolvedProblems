public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) {
        int[] result = new int[n];
        int lastend = -1;
        
        Stack<Node> st = new Stack<Node>();
        
        foreach(string log in logs){
            string[] parts = log.Split(':');
            int fid = int.Parse(parts[0]);
            string pos = parts[1];
            int time = int.Parse(parts[2]);
            
            if(pos == "start"){
                if(st.Count > 0){
                    Node npeeked = st.Peek();
                    if(npeeked.start > lastend){
                        result[npeeked.fid] += time-npeeked.start;
                    }
                    else{
                        result[npeeked.fid] += time-lastend-1;
                    }
                    
                    st.Push(new Node(fid,time));
                }
                else{
                    st.Push(new Node(fid,time));
                }
            }
            else{
                Node npopped = st.Pop();
                if(npopped.start >= lastend){
                    result[fid] += time - npopped.start+1;
                    lastend = time;
                }
                else{
                    result[fid] += time - lastend;
                    lastend = time;
                }
            }
        }
        
        return result;
    }
}

public class Node{
    public int start;
    public int fid;
    public Node(int _fid, int _start){
        start = _start;
        fid = _fid;
    }
}