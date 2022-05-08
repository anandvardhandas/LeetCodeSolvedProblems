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
        ListNode root = new ListNode(0);
        ListNode curr = root;
        PriorityQueue<ListNode,ListNode> pq = 
            new PriorityQueue<ListNode,ListNode>(Comparer<ListNode>.Create((x,y) => x.val.CompareTo(y.val)));
        
        foreach(ListNode list in lists){
            if(list != null)
                pq.Enqueue(list,list);
        }
        
        while(pq.Count > 0){
            ListNode node = pq.Dequeue();
            curr.next = new ListNode(node.val);
            curr = curr.next;
            
            node = node.next;
            if(node != null){
                pq.Enqueue(node,node);
            }
        }
        
        return root.next;
    }
}