public class Solution {
    public string IntToRoman(int num) {
        Dictionary<int,string> map = new Dictionary<int,string>();
        map.Add(1,"I");
        map.Add(4,"IV");
        map.Add(5,"V");
        map.Add(9,"IX");
        map.Add(10,"X");
        map.Add(40,"XL");
        map.Add(50,"L");
        map.Add(90,"XC");
        map.Add(100,"C");
        map.Add(400,"CD");
        map.Add(500,"D");
        map.Add(900,"CM");
        map.Add(1000,"M");
        
        StringBuilder sb = new StringBuilder();
        int[] div = new int[] { 1000,900,500,400,100,90,50,40,10,9,5,4,1 };
        
        int divind = 0;
        while(num > 0){
            if(num/div[divind] > 0){
                int n = num/div[divind];
                AppendString(sb,n,div[divind],map);
                num = num % div[divind];
            }
            
            divind++;
        }
        
        return sb.ToString();
    }
    
    private void AppendString(StringBuilder sb, int times, int div, Dictionary<int,string> map){
        string s = map[div];
        int count = 1;
        while(count <= times){
            sb.Append(s);
            count++;
        }
    }
}