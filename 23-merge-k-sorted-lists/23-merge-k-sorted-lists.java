/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode mergeKLists(ListNode[] lists) {
        if(lists == null || lists.length == 0)
            return null;
        
        ListNode dummy = new ListNode(0);
        ListNode prev = dummy;
        
        PriorityQueue<ListNode> pq = new PriorityQueue<ListNode>(lists.length, new Comparator<ListNode>(){
            @Override
            public int compare(ListNode l1, ListNode l2){
                if(l1.val < l2.val)
                    return -1;
                else if(l1.val > l2.val)
                    return 1;
                else
                    return 0;
            }
        });
        
        for(ListNode node : lists){
            if(node != null)
                pq.add(node);
        }
        
        while(pq.size() > 0){
            prev.next = pq.poll();
            
            prev = prev.next;
            if(prev.next != null){
                pq.add(prev.next);
            }
        }
        
        return dummy.next;
    }
}