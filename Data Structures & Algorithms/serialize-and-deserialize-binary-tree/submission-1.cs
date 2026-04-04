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

public class Codec {
    public int idx = 0;
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        List<string> str = new List<string>();

        DFS(root, str);

        return string.Join(",", str);
    }

    public void DFS(TreeNode root, List<string> str){
        if(root == null){
             str.Add("N");
             return;
        }

        str.Add(root.val.ToString());

        DFS(root.left, str);
        DFS(root.right, str);

    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        var vals = new List<string>(data.Split(","));
        idx = 0;
        return DFS_Deserialize(vals);
    }

    public TreeNode DFS_Deserialize(List<string> vals){
        if(vals[idx] == "N"){
            idx++;
            return null;
        }

        var node = new TreeNode(int.Parse(vals[idx]));
        idx++;
        node.left = DFS_Deserialize(vals);
        node.right = DFS_Deserialize(vals);
        return node;
    }
}
