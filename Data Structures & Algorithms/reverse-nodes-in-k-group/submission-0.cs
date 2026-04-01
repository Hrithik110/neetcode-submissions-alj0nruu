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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(head == null || k == 1) return head;

        var dummy = new ListNode(0, head);
        var groupPrev = dummy;

        while(true){
            var kthNode = GetKth(groupPrev, k);

            if(kthNode == null) break;

            ListNode groupNext = kthNode.next;
            ListNode curr = groupPrev.next;
            ListNode prev = groupNext;
            while(curr != groupNext){
                var next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            var temp = groupPrev.next;
            groupPrev.next = kthNode;
            groupPrev = temp;
        }

        return dummy.next;
    }

    public ListNode GetKth(ListNode node, int k){
        ListNode curr = node;
        while(curr!=null && k>0){
            curr = curr.next;
            k--;
        }
        return curr;
    }
}
