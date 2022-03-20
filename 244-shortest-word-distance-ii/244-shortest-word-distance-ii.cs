public class WordDistance {
    public Dictionary<string,List<int>> map;
    public WordDistance(string[] wordsDict) {
        map = new Dictionary<string,List<int>>();
        for(int i = 0; i < wordsDict.Length; i++){
            if(map.ContainsKey(wordsDict[i])){
                map[wordsDict[i]].Add(i);
            }
            else{
                map.Add(wordsDict[i], new List<int>() { i });
            }
        }
    }
    
    public int Shortest(string word1, string word2) {
        List<int> list1 = map[word1];
        List<int> list2 = map[word2];
        
        int l = 0, r = 0;
        int mindist = int.MaxValue;
        while(l < list1.Count && r < list2.Count){
            mindist = Math.Min(mindist, Math.Abs(list1[l]-list2[r]));
            if(mindist == 1)
                return 1;
            
            if(list1[l] < list2[r]){
                l++;
            }
            else{
                r++;
            }
        }
        
        return mindist;
    }
}

/**
 * Your WordDistance object will be instantiated and called as such:
 * WordDistance obj = new WordDistance(wordsDict);
 * int param_1 = obj.Shortest(word1,word2);
 */