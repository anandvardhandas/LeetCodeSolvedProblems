/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists == null || lists.Length == 0)
            return null;
        
        int len = lists.Length;
        PriorityQueue<ListNode,ListNode> pq = 
            new PriorityQueue<ListNode,ListNode>(len, Comparer<ListNode>.Create((x,y) => x.val.CompareTo(y.val)));
        
        for(int i = 0; i < len; i++){
            if(lists[i] != null)
                pq.Enqueue(lists[i],lists[i]);
        }
        
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        
        while(pq.Count > 0){
            ListNode popped = pq.Dequeue();
            curr.next = new ListNode(popped.val);
            curr = curr.next;
            if(popped.next != null)
                pq.Enqueue(popped.next,popped.next);
        }
        
        return dummy.next;
    }
}

