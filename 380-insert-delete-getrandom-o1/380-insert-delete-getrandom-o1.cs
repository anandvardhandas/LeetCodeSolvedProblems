public class RandomizedSet {

    public Dictionary<int,int> numbers;
    public Dictionary<int,int> indexes;
    public int count;
    public RandomizedSet() {
        numbers = new Dictionary<int,int>();
        indexes = new Dictionary<int,int>();
        count = 0;
    }
    
    public bool Insert(int val) {
        if(numbers.ContainsKey(val)){
            return false;
        }
        else{
            indexes.Add(count, val);
            numbers.Add(val,count);
            count++;
            
            return true;
        }
    }
    
    public bool Remove(int val) {
        if(numbers.ContainsKey(val)){
            int index = numbers[val];
            indexes[index] = indexes[count-1];
            numbers[indexes[count-1]] = index;
            
            indexes.Remove(count-1);
            numbers.Remove(val);
            
            count--;
            
            return true;
        }
        else{
            return false;
        }
    }
    
    public int GetRandom() {
        int rand = new Random().Next(0, count);
        return indexes[rand];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */