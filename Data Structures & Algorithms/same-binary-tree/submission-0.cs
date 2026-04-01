/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        var queue1 = new Queue<TreeNode>();
        var queue2 = new Queue<TreeNode>();

        queue1.Enqueue(p);
        queue2.Enqueue(q);

        while(queue1.Count > 0 && queue2.Count > 0){
            var node1 = queue1.Dequeue();
            var node2 = queue2.Dequeue();
            if (node1 == null && node2 == null) continue;
            if (node1 == null || node2 == null) return false;
            if (node1.val != node2.val) return false;

            queue1.Enqueue(node1.left);
            queue2.Enqueue(node2.left);
            queue1.Enqueue(node1.right);
            queue2.Enqueue(node2.right);
        }

        return queue1.Count == 0 && queue2.Count == 0;
    }


}
