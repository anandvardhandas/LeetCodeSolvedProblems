/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode currA = headA;
        ListNode currB = headB;
        int count = 0;
        while(true){
            if(count > 2)
                break;
            if(currA == null || currB == null){
                if(currA == null){
                    currA = headB;
                }
                
                if(currB == null){
                    currB = headA;
                }
                
                count++;
                
                continue;
            }
            
            if(currA == currB)
                return currA;
            
            currA = currA.next;
            currB = currB.next;
        }
        
        return null;
    }
}