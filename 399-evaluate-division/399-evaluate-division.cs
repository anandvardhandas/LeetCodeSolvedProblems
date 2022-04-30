public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        Dictionary<string,List<Node>> map = new Dictionary<string,List<Node>>();
        
        for(int i = 0; i < equations.Count; i++){
            string var1 = equations[i][0];
            string var2 = equations[i][1];
            
            double val = values[i];
            
            Node node1 = new Node(var1, 1/val);
            Node node2 = new Node(var2, val);
            if(!map.ContainsKey(var1)){
                map.Add(var1, new List<Node>() { node2 });
            }
            else{
                map[var1].Add(node2);
            }
            
            if(!map.ContainsKey(var2)){
                map.Add(var2, new List<Node>() { node1 });
            }
            else{
                map[var2].Add(node1);
            }
        }
        
        List<double> result = new List<double>();
        
        foreach(IList<string> query in queries){
            string from = query[0];
            string to = query[1];
            
            if(!map.ContainsKey(from) || !map.ContainsKey(to)){
                result.Add((double)-1);
            }
            else if(from == to){
                result.Add((double)1);
            }
            else{
                Dictionary<string,bool> visited = new Dictionary<string,bool>();
                double res = Helper(map, to, from, visited);
                if(res == 0)
                    result.Add((double)-1);
                else
                    result.Add(res);
            }
        }
        
        return result.ToArray();
    }
    
    private double Helper(Dictionary<string,List<Node>> map,string to, string name, Dictionary<string,bool> visited){
        
        if(name == to){
            return 1.0;
        }
        
        if(visited.ContainsKey(name) && visited[name] == true){
            return 0;
        }
        
        if(visited.ContainsKey(name)){
            visited[name] = true;
        }
        else{
            visited.Add(name, true);
        }
        
        //Console.WriteLine(name);
        List<Node> nodes = map[name];
        double res = 0;
        foreach(Node node in nodes){
            res = node.weight * Helper(map, to, node.name, visited);
            if(res != 0){
                return res;
            }
        }
        
        return res;
    }
}

public class Node{
    public string name;
    public double weight;
    public Node(string _name, double _weight){
        this.name = _name;
        this.weight = _weight;
    }
}