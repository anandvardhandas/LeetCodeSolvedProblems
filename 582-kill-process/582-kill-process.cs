public class Solution {
    public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill) {
        Dictionary<int,List<int>> map = new Dictionary<int,List<int>>();
        int len = pid.Count;
        for(int i = 0; i < len; i++){
            int parent = ppid[i];
            int child = pid[i];
            if(map.ContainsKey(parent)){
                map[parent].Add(child);
            }
            else{
                map.Add(parent, new List<int>() { child });
            }
        }
        
        
        IList<int> result = new List<int>();
        Helper(map, result, kill);
        return result;
    }
    
    private void Helper(Dictionary<int,List<int>> map, IList<int> result, int pid){
        if(!map.ContainsKey(pid)){
            result.Add(pid);
            return;
        }
        
        result.Add(pid);
        
        List<int> children = map[pid];
        foreach(int child in children){
            Helper(map, result, child);
        }
    }
}