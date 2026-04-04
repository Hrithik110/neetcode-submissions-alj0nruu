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
    public int result = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        result = root.val;
        FindMax(root);
        return result;
    }

    public int FindMax(TreeNode root){

        if(root == null) return 0;

        int leftMax = FindMax(root.left);
        int rightMax = FindMax(root.right);

        leftMax = Math.Max(0, leftMax);
        rightMax = Math.Max(0, rightMax);

        result = Math.Max(result, leftMax + rightMax + root.val);

        return root.val + Math.Max(leftMax, rightMax);

    }
}
