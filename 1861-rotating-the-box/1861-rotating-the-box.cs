public class Solution {
    public char[][] RotateTheBox(char[][] box) {
        int m = box.Length, n = box[0].Length;
        
        //create an empty result array
        char[,] result = new char[n,m];
        for(int i = 0; i < result.GetLength(0); i++){
            for(int j = 0; j < result.GetLength(1); j++){
                result[i,j] = '.';
            }
        }
        
        int col = 0, row = 0;
        for(int i = m-1; i >= 0; i--){
            row = n-1;
            int swapIndex = n-1; // maintain a swap index which would contain last swap index to swap stone with empty space
            for(int j = n-1; j >=0; j--){
                if(box[i][j] == '*'){
                    result[row,col] = '*';
                    swapIndex = j-1;
                }
                else if(box[i][j] == '.'){
                    //do nothing
                }
                else{
                    //swap with swap index
                    char temp = result[swapIndex, col];
                    result[swapIndex, col] = '#';
                    swapIndex--;
                }
                
                
                row--;
            }
            
            col++;
        }
        
        return ConvertTo2DArray(result);
    }
    
    private char[][] ConvertTo2DArray(char[,] arr)
    {
        char[][] result = new char[arr.GetLength(0)][];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            result[i] = new char[arr.GetLength(1)];
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                result[i][j] = arr[i, j];
            }
        }

        return result;
    }
}