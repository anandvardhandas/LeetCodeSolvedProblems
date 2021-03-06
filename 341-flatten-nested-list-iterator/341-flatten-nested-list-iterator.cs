/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
    List<int> list;
    int index = 0;
    public NestedIterator(IList<NestedInteger> nestedList) {
        list = new List<int>();
        ExtractNumbers(nestedList);
    }
    
    private void ExtractNumbers(IList<NestedInteger> nestedList){
        foreach(var nested in nestedList){
            if(nested.IsInteger()){
                list.Add(nested.GetInteger());
            }
            else{
                ExtractNumbers(nested.GetList());
            }
        }
    }

    public bool HasNext() {
        return index < list.Count;
    }

    public int Next() {
        return list[index++];
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */