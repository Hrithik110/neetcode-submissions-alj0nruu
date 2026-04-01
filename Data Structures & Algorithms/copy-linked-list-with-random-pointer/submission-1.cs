/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
         if (head == null) return null;
        var map = new Dictionary<Node, Node>();

        Node curr = head;
        while(curr != null){
            Node copy = new Node(curr.val);
            map[curr] = copy;
            curr = curr.next;
        }

        curr = head;

        while(curr!=null){
            Node copy = map[curr];
            copy.next = curr.next!=null ? map[curr.next] : null;
            copy.random = curr.random!=null ? map[curr.random] : null;
            curr = curr.next;
        }

        return map[head];
       
    }
}
