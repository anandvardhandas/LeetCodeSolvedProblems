public class WordDistance {
     Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
    public WordDistance(string[] wordsDict) {
        int len = wordsDict.Length;
        for(int i = 0; i < len; i++){
            if(map.ContainsKey(wordsDict[i])){
                map[wordsDict[i]].Add(i);
            }
            else{
                map.Add(wordsDict[i], new List<int>() { i });
            }
        }
    }
    
    public int Shortest(string word1, string word2) {
         List<int> lst1 = map[word1];
        List<int> lst2 = map[word2];
        
        int l = 0, r = 0;
        
        int mindist = int.MaxValue;
        while(l < lst1.Count && r < lst2.Count){
            mindist = Math.Min(mindist, Math.Abs(lst1[l]-lst2[r]));
            if(mindist == 1)
                return 1;
            if(lst2[r] < lst1[l]){
                r++;
            }
            else{
                l++;
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