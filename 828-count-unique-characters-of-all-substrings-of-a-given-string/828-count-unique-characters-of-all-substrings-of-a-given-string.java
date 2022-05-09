class Solution {
    public int uniqueLetterString(String s) {
         Map<Character, ArrayList<Integer>> indexMap = new HashMap<>();
		
        for(int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            indexMap.computeIfAbsent(c, k-> new ArrayList<>()).add(i);
        }

        int res = 0;

        for(Map.Entry<Character, ArrayList<Integer>> kv: indexMap.entrySet()) {
		
            var allOccurrences = kv.getValue();
            for(int i = 0; i < allOccurrences.size(); i++) {
                int currentIndex = allOccurrences.get(i);
				
                int left = i == 0 ? currentIndex : currentIndex - allOccurrences.get(i-1) - 1;
				
                int right = i == allOccurrences.size() - 1 ? s.length() - currentIndex - 1 : allOccurrences.get(i+1) - currentIndex - 1;
				
                res += 1 + left + (right * (left + 1));
            }
        }

        return res;
    }
}