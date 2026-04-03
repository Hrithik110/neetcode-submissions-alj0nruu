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
    private int result = -1;
    private int count = 0;
    public int KthSmallest(TreeNode root, int k) {
        count = k;
        Inorder(root);

        return result;
    }

    public void Inorder(TreeNode root){
        if(root == null || result != -1) return;

        Inorder(root.left);

        count--;

        if(count == 0){
            result = root.val;
            return;
        }

        Inorder(root.right);
    }
}
