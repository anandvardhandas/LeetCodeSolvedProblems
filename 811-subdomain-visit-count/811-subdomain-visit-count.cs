public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        Dictionary<string,int> map = new Dictionary<string,int>();
        IList<string> result = new List<string>();
        
        foreach(string cpdomain in cpdomains){
            string[] parts = cpdomain.Split(' ');
            int count = int.Parse(parts[0]);
            string domain = parts[1];
            for(int i = domain.Length-1; i >= 0; i--){
                if(parts[1][i] == '.'){
                    string dom = domain.Substring(i+1, domain.Length-i-1);
                    if(map.ContainsKey(dom)){
                        map[dom] += count;
                    }
                    else{
                        map.Add(dom, count);
                    }
                }
            }
            
            if(map.ContainsKey(domain)){
                map[domain] += count;
            }
            else{
                map.Add(domain, count);
            }
        }
        
        foreach(var item in map){
            result.Add($"{item.Value} {item.Key}");
        }
        
        return result;
    }
}