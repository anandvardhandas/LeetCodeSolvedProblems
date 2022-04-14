public class Solution {
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit) {
        int len = startTime.Length;
        List<Job> jobslist = new List<Job>();
        for(int i = 0; i < len; i++){
            jobslist.Add(new Job(startTime[i], endTime[i], profit[i]));
        }
        
        Job[] jobs = jobslist.ToArray();
        Array.Sort(jobs, Comparer<Job>.Create((x,y) => x.start.CompareTo(y.start)));
        
        for(int i = 0; i < len; i++){
            startTime[i] = jobs[i].start;
        }
        
        Dictionary<int,int> map = new Dictionary<int,int>();
        return Helper(jobs, startTime, 0, map);
    }
    
    private int Helper(Job[] jobs, int[] startTime, int index, Dictionary<int,int> map){
        if(index == startTime.Length)
            return 0;
        
        if(map.ContainsKey(index))
            return map[index];
        
        //skipping the current schedule
        int skip = Helper(jobs, startTime, index+1, map);
        
        //finding the next index 
        int nextIndex = BinarySearchFindNextJob(startTime, jobs[index].end);
        
        //selecting the current schedule
        int curr = jobs[index].profit + Helper(jobs, startTime, nextIndex, map);
        
        int maxprofit = Math.Max(skip, curr);
        
        map.Add(index, maxprofit);
        return maxprofit;
    }
    
    private int BinarySearchFindNextJob(int[] startTime, int endTime){
        int low = 0, hi = startTime.Length-1;
        int index = hi+1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(startTime[mid] >= endTime){
                index = mid;
                hi = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        
        return index;
    }
}

public class Job{
    public int start;
    public int end;
    public int profit;
    
    public Job(int _start, int _end, int _profit){
        start = _start;
        end = _end;
        profit = _profit;
    }
}