public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        if(!wordList.Contains(endWord))
            return 0;
        
        wordList.Add(beginWord);
        
        Dictionary<string,List<string>> graph = new Dictionary<string,List<string>>();
        
        foreach(string str in wordList){
            for(int i = 0; i < str.Length; i++){
                char[] keys = str.ToCharArray();
                keys[i] = '*';
                string key = new string(keys);
                if(graph.ContainsKey(key)){
                    graph[key].Add(str);
                }
                else{
                    graph.Add(key, new List<string>() { str });
                }
            }
        }
        
        Dictionary<string,bool> visited = new Dictionary<string,bool>();
        int result = 1;
        
        Queue<string> que = new Queue<string>();
        que.Enqueue(beginWord);
        
        while(que.Count > 0){
            int size = que.Count;
            for(int j = 1; j <= size; j++){
                string word = que.Dequeue();
                
                for(int i = 0; i < word.Length; i++){
                    char[] keys = word.ToCharArray();
                    keys[i] = '*';
                    string key = new string(keys);
                    if(graph.ContainsKey(key)){
                        List<string> neighbours = graph[key];
                        foreach(string neighbour in neighbours){
                            if(!visited.ContainsKey(neighbour)){
                                que.Enqueue(neighbour);
                                visited.Add(neighbour, true);
                                if(neighbour == endWord)
                                  return result+1;
                            }
                        }
                    }
                }
            }
            
            result++;
        }
        
        return 0;
    }
}