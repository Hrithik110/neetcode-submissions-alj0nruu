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
    public List<List<int>> LevelOrder(TreeNode root) {
        if(root == null) return new List<List<int>>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        List<List<int>> ans = new List<List<int>>();

        while(queue.Count>0){
           
            int nodes = queue.Count;

            List<int> level = new List<int>();
            int i = 0;
            while(i<nodes){

                var node = queue.Dequeue();
                level.Add(node.val);

                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);

                i++;
            }

            ans.Add(level);

        }

        return ans;
    }
}
