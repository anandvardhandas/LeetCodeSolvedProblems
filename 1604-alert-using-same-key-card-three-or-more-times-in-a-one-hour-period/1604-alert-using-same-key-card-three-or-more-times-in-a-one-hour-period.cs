public class Solution {
    public IList<string> AlertNames(string[] keyName, string[] keyTime) {
        List<string> result = new List<string>();
        
        Dictionary<string,List<int>> map = new Dictionary<string,List<int>>();
        
        for(int i = 0; i < keyName.Length; i++){
            if(map.ContainsKey(keyName[i])){
                map[keyName[i]].Add(GetTime(keyTime[i]));
            }
            else{
                map.Add(keyName[i], new List<int>() { GetTime(keyTime[i]) });
            }
        }
        
        foreach(var item in map){
            List<int> times = item.Value;
            times.Sort();
            for(int i = 2; i < times.Count; i++){
                if((times[i]-times[i-2]) <= 60){
                    result.Add(item.Key);
                    break;
                }
            }
        }
        
        result.Sort();
        return result;
    }
    
    private int GetTime(string time){
        string[] times = time.Split(':');
        int totaltime = 60 * int.Parse(times[0]) + int.Parse(times[1]);
        return totaltime;
    }
}