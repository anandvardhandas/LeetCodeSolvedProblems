public class Solution {
    public string RemoveDuplicateLetters(string s) {
        int[] res = new int[26]; //will contain number of occurences of character (i+'a')
    bool[] visited = new bool[26]; //will contain if character (i+'a') is present in current result Stack
    foreach(char c in s){  //count number of occurences of character 
        res[c-97]++;
    }
    Stack<char> st = new Stack<char>(); // answer stack
    int index;
    foreach(char c in s){ 
        index= c-97;
        res[index]--;   //decrement number of characters remaining in the string to be analysed
        if(visited[index]) //if character is already present in stack, dont bother
            continue;
        //if current character is smaller than last character in stack which occurs later in the string again
        //it can be removed and  added later e.g stack = bc remaining string abc then a can pop b and then c
        while(st.Count > 0 && c < st.Peek() && res[st.Peek()-97]!=0){ 
            visited[st.Pop()-97]=false;
        }
        st.Push(c); //add current character and mark it as visited
        visited[index]=true;
    }

    StringBuilder sb = new StringBuilder();
    //pop character from stack and build answer string from back
    while(st.Count > 0){
        sb.Append(st.Pop());
    }
    
        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}