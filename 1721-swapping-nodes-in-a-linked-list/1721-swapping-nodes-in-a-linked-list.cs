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
    public ListNode SwapNodes(ListNode head, int k) {
        int len = 1;
        
        ListNode curr = head;
        while(curr.next != null){
            curr = curr.next;
            len++;
        }
        
        ListNode right = head;
        int i = 1;
        while(i < len-k+1){
            right = right.next;
            i++;
        }
        
        ListNode left = head;
        i = 1;
        while(i < k){
            left = left.next;
            i++;
        }
        
        int temp = left.val;
        left.val = right.val;
        right.val = temp;
        
        return head;
    }
}