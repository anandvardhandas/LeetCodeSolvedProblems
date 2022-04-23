public class Solution {
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) {
        int len = accounts.Count;
        
        UnionFind uf = new UnionFind(len);
        
        Dictionary<string, int> map1 = new Dictionary<string,int>();
        for(int i = 0; i < len; i++){
            for(int j = 1; j < accounts[i].Count; j++){
                if(!map1.ContainsKey(accounts[i][j])){
                    map1.Add(accounts[i][j], i);
                }
                else{
                    int prevaccid = map1[accounts[i][j]];
                    uf.Union(i,prevaccid);
                }
            }
        }
        
        Dictionary<int,List<string>> map2 = new Dictionary<int,List<string>>();
        for(int i = 0; i < len; i++){
            int parentaccid = uf.Find(i);
            //Console.WriteLine($"accid:{i} and parentaccid:{parentaccid}");
            if(!map2.ContainsKey(parentaccid)){
                map2.Add(parentaccid, new List<string>());
            }
            
            //map2[parentaccid].Add(accounts[i][0]);//adding name
            map2[parentaccid].AddRange(accounts[i].ToList().GetRange(1, accounts[i].Count-1));
        }
        
        IList<IList<string>> result = new List<IList<string>>();
        foreach(var item in map2){
            List<string> res = new List<string>();
            res.Add(accounts[item.Key][0]);
            List<string> sortedList = item.Value.Distinct().ToList();
            sortedList.Sort(StringComparer.Ordinal);
            res.AddRange(sortedList);
            
            result.Add(res);
        }
        
        
        return result;
    }
}

public class UnionFind{
    public int[] sets;
    
    public UnionFind(int size){
        sets = new int[size];
        for(int i = 0; i < size; i++){
            sets[i] = i;
        }
    }
    
    public void Union(int set1, int set2){
        int p1 = Find(set1);
        int p2 = Find(set2);
        if(p1 != p2){
            sets[p1] = p2;
        }
    }
    
    public int Find(int set){
        if(sets[set] == set){
            return set;
        }
        
        sets[set] = Find(sets[set]);
        return sets[set];
    }
}