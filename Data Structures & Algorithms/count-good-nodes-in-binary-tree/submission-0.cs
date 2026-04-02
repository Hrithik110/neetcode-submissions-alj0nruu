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
    public int GoodNodes(TreeNode root) {
        return CountGoodNodes(root, root.val);
    }

    public int CountGoodNodes(TreeNode node, int maxSoFar){
        if(node == null) return 0;

        int count = 0;
        if(node.val>= maxSoFar){
            count = 1;
            maxSoFar = node.val;
        }

        count += CountGoodNodes(node.left, maxSoFar);
        count += CountGoodNodes(node.right, maxSoFar);

        return count;

    }
}
