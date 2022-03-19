public class Solution {
    public IList<string> AlertNames(string[] keyName, string[] keyTime) {
        
        Dictionary<string,List<int>> map = new Dictionary<string,List<int>>();
        SortedDictionary<string,string> result = new SortedDictionary<string,string>();
        for(int i = 0; i < keyName.Length; i++){
            string name = keyName[i];
            if(map.ContainsKey(name)){
                map[name].Add(GetTime(keyTime[i]));
                
                List<int> times = map[name];
                times.Sort();
                for(int j = 2; j < times.Count; j++){
                    if(times[j]-times[j-2] <= 60){
                        if(!result.ContainsKey(name))
                            result.Add(name,name);
                    }
                }
            }
            else{
                map.Add(name, new List<int>() { GetTime(keyTime[i]) });
            }
        }
        
        List<string> res = new List<string>();
        foreach(var item in result){
            res.Add(item.Key);
        }
        
        return res;
    }
    
    private int GetTime(string time){
        string[] times = time.Split(':');
        return int.Parse(times[0]) * 60 + int.Parse(times[1]);
    }
}