public class FileSystem {
    private Dictionary<string,int> map;
    public FileSystem() {
        map = new Dictionary<string,int>();
        map.Add("",-1);
    }
    
    public bool CreatePath(string path, int value) {
        string[] paths = path.Split('/');
        //Console.WriteLine(paths.Length);
        if(paths.Length <= 1)
            return false;
        else{
            int lastIndex = path.LastIndexOf('/');
            //Console.WriteLine(lastIndex);
            string parent = path.Substring(0, lastIndex);
            //Console.WriteLine(parent);
            if(!map.ContainsKey(parent) || map.ContainsKey(path)){
                return false;
            }
            else{
                map.Add(path,value);
                return true;
            }
        }
    }
    
    public int Get(string path) {
        if(map.ContainsKey(path))
            return map[path];
        else
            return -1;
    }
}


/**
 * Your FileSystem object will be instantiated and called as such:
 * FileSystem obj = new FileSystem();
 * bool param_1 = obj.CreatePath(path,value);
 * int param_2 = obj.Get(path);
 */