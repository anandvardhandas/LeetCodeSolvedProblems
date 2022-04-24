public class UndergroundSystem {
    Dictionary<int, Person> personsMap;
    Dictionary<string, StationDetails> stationMap;
    public UndergroundSystem() {
        personsMap = new Dictionary<int,Person>();
        stationMap = new Dictionary<string,StationDetails>();
    }
    
    public void CheckIn(int id, string stationName, int t) {
        personsMap.Add(id, new Person(stationName, t));
    }
    
    public void CheckOut(int id, string stationName, int t) {
        Person person = personsMap[id];
        person.stationTo = stationName;
        person.end = t;
        
        string key = $"{person.stationFrom}-{person.stationTo}";
        int duration = t-person.start;
        if(stationMap.ContainsKey(key)){
            StationDetails sd = stationMap[key];
            double total = sd.persons*sd.average;
            sd.persons++;
            double average = (double) (total+(double)duration)/sd.persons;
            sd.average = average;
            
        }
        else{
            StationDetails sd = new StationDetails();
            sd.persons = 1;
            sd.average = (double)duration/1;
            stationMap.Add(key, sd);
        }
        
        personsMap.Remove(id);
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        string key = $"{startStation}-{endStation}";
        return stationMap[key].average;
    }
}

public class StationDetails{
    public int persons;
    public double average;
}

public class Person{
    public string stationFrom;
    public string stationTo;
    public int start;
    public int end;
    
    public Person(string _stationFrom, int _start){
        stationFrom = _stationFrom;
        start = _start;
    }
    
    
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */