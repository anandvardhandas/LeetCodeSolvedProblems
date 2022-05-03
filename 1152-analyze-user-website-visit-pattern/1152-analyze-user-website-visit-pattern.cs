public class Solution {
    public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website) {
        int len = username.Length;
        User[] users = new User[len];
        for(int i = 0; i < len; i++){
            users[i] = new User(username[i],timestamp[i],website[i]);
        }
        
        Array.Sort(users, (x,y) => x.time.CompareTo(y.time));
        
        Dictionary<string,List<string>> userWebsites = new Dictionary<string,List<string>>();
        foreach(User user in users){
            if(userWebsites.ContainsKey(user.username)){
                userWebsites[user.username].Add(user.website);
            }
            else{
                userWebsites.Add(user.username, new List<string>() { user.website });
            }
        }
        
        Dictionary<string, int> seqFreqMap = new Dictionary<string, int>();
        foreach(var item in userWebsites){
            List<string> list = item.Value;
            
            //generate combination of 3 websites
            if(list.Count >= 3){
                HashSet<string> set = new HashSet<string>();
                for(int i = 0; i < list.Count; i++){
                    for(int j = i+1; j < list.Count; j++){
                        for(int k = j+1; k < list.Count; k++){
                            string keyset = $"{list[i]},{list[j]},{list[k]}";
                            set.Add(keyset);
                        }
                    }
                }
                
                foreach(string wkey in set){
                    if(seqFreqMap.ContainsKey(wkey)){
                        seqFreqMap[wkey]++;
                    }
                    else{
                        seqFreqMap.Add(wkey,1);
                    }
                }
            }
        }
        
        int maxfreq = -1;
        string res = "";
        foreach(var item in seqFreqMap){
            if(item.Value > maxfreq){
                maxfreq = item.Value;
                res = item.Key;
            }
            else if(item.Value == maxfreq && item.Key.CompareTo(res) < 0){
                res = item.Key;
            }
        }
        
        return res.Split(",").ToList();
    }
}

public class User{
    public string username;
    public int time;
    public string website;
    public User(string _username, int _time, string _website){
        username = _username;
        time = _time;
        website = _website;
    }
}