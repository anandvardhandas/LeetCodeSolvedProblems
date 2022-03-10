public class Solution {
    public string ArrangeWords(string text) {
        if(string.IsNullOrWhiteSpace(text))
            return text;
        
        text = text.ToLower();
        string[] words = text.Split(' ');
        
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(words.Length, Comparer<int>.Create((x,y) => words[x].Length != words[y].Length ? words[x].Length.CompareTo(words[y].Length) : x.CompareTo(y)));
        
        for(int i = 0; i < words.Length; i++){
            pq.Enqueue(i,i);
        }
        
        StringBuilder sb = new StringBuilder();
        while(pq.Count > 0){
            sb.Append(words[pq.Dequeue()]);
            sb.Append(" ");
        }
        
        char[] result = sb.ToString().ToCharArray();
        
        result[0] = Char.ToUpper(result[0]);
        
        return new string(result).Substring(0, result.Length-1);
    }
}