public class Solution {
    public  string MinWindow(string s, string t)
    {
        string alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";


        Dictionary<char, int> map2 = new Dictionary<char, int>();
        Dictionary<char, int> map1 = new Dictionary<char, int>();

        FillMap(map2, alpha);
        FillMap(map1, alpha);

        foreach (char c in t)
        {
            map2[c]++;
        }

        int count = 0;

        int len = s.Length;
        int size = t.Length;

        int l = 0, r = 0;

        int min = int.MaxValue;
        string res = "";
        while (r < len)
        {
            //expand right to get all charcs of t
            //"ADOBECODEBANC", "ABC"
            while (r < len)
            {
                char ch = s[r];
                if (map2[ch] > 0)
                {
                    if (map1[ch] < map2[ch])
                    {
                        count++;
                        if (count == size)
                        {
                            map1[ch]++;
                            r++;
                            break;
                        }
                    }

                    map1[ch]++;
                }

                r++;
            }

            if (count == size && r - l < min)
            {
                min = r - l;
                res = s.Substring(l, min);
            }
            //"ADOBECODEBANC", "ABC"
            //shrink left till it is valid
            while (l < len)
            {
                char ch = s[l];
                if (map2[ch] > 0)
                {
                    if (map1[ch] <= map2[ch])
                    {
                        count--;
                        map1[ch]--;
                        l++;
                        break;
                    }

                    map1[ch]--;
                }

                l++;
                if (count == size && r - l < min)
                {
                    min = r - l;
                    res = s.Substring(l, min);
                }
            }

        }

        return res;
    }
    
    private void FillMap(Dictionary<char,int> map, string alpha){
        foreach(char c in alpha){
            map.Add(c,0);
        }
    }
}