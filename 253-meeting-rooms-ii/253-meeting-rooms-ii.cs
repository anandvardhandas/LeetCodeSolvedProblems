public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
        int len = intervals.Length;
        PriorityQueue<int[],int[]> pq = new PriorityQueue<int[],int[]>(len, Comparer<int[]>.Create((x,y) => x[1].CompareTo(y[1])));
        
        int rooms = 1;
        int[] prevmeeting = intervals[0];
        pq.Enqueue(intervals[0], intervals[0]);
        
        int i = 1;
        while(i < len){
            int[] currmeeting = intervals[i];
            if(currmeeting[0] < pq.Peek()[1]){
                pq.Enqueue(currmeeting,currmeeting);
                rooms++;
            }
            else{
                pq.Dequeue();
                pq.Enqueue(currmeeting, currmeeting);
            }
            
            i++;
        }
        
        return rooms;
    }
}