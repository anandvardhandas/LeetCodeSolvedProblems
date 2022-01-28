public class StringIterator {

    string str = "";
    int index = 1;
    int curr = 0;
    char lastChar = ' ';
    public StringIterator(string compressedString) {
        this.str = compressedString;
    }
    
    public char Next() {
        if(index >= str.Length)
            return ' ';
        if(lastChar == ' ')
            lastChar = str[index-1];
        if(curr == 0){
            string num = "";
            int cindex = index;
            while(cindex < str.Length && char.IsDigit(str[cindex])){
                num += str[cindex].ToString();
                cindex++;
            }
            curr = int.Parse(num);
            cindex--;
            lastChar = str[index-1];
            index = cindex;
        }
            
        curr--;
        if(curr == 0){
            index += 2;
        }
        
        return lastChar;
    }
    
    public bool HasNext() {
        if(index >= str.Length)
            return false;
        
        return true;
    }
}

/**
 * Your StringIterator object will be instantiated and called as such:
 * StringIterator obj = new StringIterator(compressedString);
 * char param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */