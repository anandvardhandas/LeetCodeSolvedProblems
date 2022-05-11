public class Solution {
    public int CountVowelStrings(int n) {
        char[] arr = new char[] { 'a', 'e', 'i', 'o', 'u' };
        List<string> result = new List<string>();
        Helper(n, arr, 0, new List<char>(), result);
        return result.Count;
    }
    
    private void Helper(int n, char[] arr, int index, List<char> temp, List<string> result){
        if(index >= arr.Length){
            return;
        }
        
        if(temp.Count == n){
            result.Add(new string(new List<char>(temp).ToArray()));
            return;
        }
        
        for(int i = index; i < arr.Length; i++){
            temp.Add(arr[i]);
            Helper(n, arr, i, temp, result);
            temp.RemoveAt(temp.Count-1);
        }
    }
}