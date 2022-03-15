public class Solution {
    public int ShortestDistance(string[] wordsDict, string word1, string word2) {
        Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
        int len = wordsDict.Length;
        for(int i = 0; i < len; i++){
            if(map.ContainsKey(wordsDict[i])){
                map[wordsDict[i]].Add(i);
            }
            else{
                map.Add(wordsDict[i], new List<int>() { i });
            }
        }
        
        List<int> lst1 = map[word1];
        List<int> lst2 = map[word2];
        
        int l = 0, r = 0;
        
        int mindist = int.MaxValue;
        while(l < lst1.Count && r < lst2.Count){
            mindist = Math.Min(mindist, Math.Abs(lst1[l]-lst2[r]));
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