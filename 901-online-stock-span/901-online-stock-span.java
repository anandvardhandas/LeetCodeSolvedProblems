public class StockSpanner {
    
    List<int> prices;
    public StockSpanner() {
        prices = new List<int>();
    }
    
    public int Next(int price) {
        int result = 1;
        int index = prices.Count-1;
        while(prices.Count > 0 && index >= 0 && price >= prices[index]){
            index--;
            result++;
        }
        
        prices.Add(price);
        
        return result;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */