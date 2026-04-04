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
    public int res = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        res = root.val;
        MaxSum(root);
        return res;
    }

    public int MaxSum(TreeNode root){
        if(root == null) return 0;

        int leftMax = MaxSum(root.left);

        int rightMax = MaxSum(root.right);

        leftMax = Math.Max(0, leftMax);
        rightMax = Math.Max(0, rightMax);

        res = Math.Max(res, leftMax + rightMax + root.val);

        return root.val + Math.Max(leftMax, rightMax);
    }
}
