public class Solution {
    public int ConnectSticks(int[] sticks) {
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
        
        foreach(int stick in sticks){
            pq.Enqueue(stick,stick);
        }
        
        int totalcost = 0;
        while(pq.Count > 1){
            int stick1 = pq.Dequeue();
            int stick2 = pq.Dequeue();
            totalcost += stick1+stick2;
            pq.Enqueue(stick1+stick2,stick1+stick2);
        }
        
        return totalcost;
    }
}