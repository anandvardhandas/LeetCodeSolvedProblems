public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> st = new Stack<int>();
        
        int len = asteroids.Length;
        
        for(int i = 0; i < len; i++){
            if(asteroids[i] > 0){
                st.Push(asteroids[i]);
            }
            else{
                bool continues = false;
                while(st.Count > 0 && st.Peek() > 0){
                    int ast = st.Pop();
                    if(Math.Abs(ast) > Math.Abs(asteroids[i])){
                        continues = true;
                        st.Push(ast);
                        break;
                    }
                    else if(Math.Abs(ast) == Math.Abs(asteroids[i])){
                        continues = true;
                        break;
                    }
                }
                
                if(!continues){
                    st.Push(asteroids[i]);
                }
            }
        }
        
        int[] result = new int[st.Count];
        int index = 0;
        while(st.Count > 0){
            result[index++] = st.Pop();
        }
        
        Array.Reverse(result);
        
        return result;
    }
}