public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] v1 = version1.Split('.');
        string[] v2 = version2.Split('.');
        
        int i = 0, j = 0;
        
        while(i < v1.Length || j < v2.Length){
            int ver1 = 0, ver2 = 0;
            if(i < v1.Length){
                string version = v1[i].TrimStart('0');
                if(!string.IsNullOrWhiteSpace(version))
                    ver1 = int.Parse(version);
                i++;
            }
            
            if(j < v2.Length){
                string version = v2[j].TrimStart('0');
                if(!string.IsNullOrWhiteSpace(version))
                    ver2 = int.Parse(version);
                j++;
            }
            
            if(ver1 < ver2)
                return -1;
            else if(ver1 > ver2)
                return 1;
        }
        
        return 0;
    }
}