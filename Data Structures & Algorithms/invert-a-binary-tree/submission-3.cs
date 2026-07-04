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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return null;
        // var resultTree = new TreeNode();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while(queue.Count > 0){
            var node = queue.Dequeue();
            // resultTree
            (node.left, node.right) = (node.right, node.left);
            if(node.left != null)
                queue.Enqueue(node.left);
            if(node.right != null)
                queue.Enqueue(node.right);
        }   

        return root;
    }
}
