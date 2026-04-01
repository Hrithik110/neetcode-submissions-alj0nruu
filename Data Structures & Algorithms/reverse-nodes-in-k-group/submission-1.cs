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
            var kth = GetKthNode(groupPrev, k);

            if(kth == null) break;

            ListNode groupNext = kth.next;

            ListNode curr = groupPrev.next;
            ListNode prev = groupNext;
            Console.WriteLine(kth.val);
            while(curr!=groupNext){
                var temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            var temp2 = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = temp2;
        }

        return dummy.next;
    }

    public ListNode GetKthNode(ListNode curr, int k){
        while(curr != null && k>0){
            curr = curr.next;
            k--;
        }

        return curr;
    }
}
