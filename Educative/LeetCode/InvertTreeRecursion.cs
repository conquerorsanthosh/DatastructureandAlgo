namespace LeetCode;
public class InvertTreeRecursion
{
    public TreeNode InvertTree(TreeNode root) 
    {
        ProcessInvertTree(root);
        return root;
        
    }

    private void ProcessInvertTree(TreeNode current)
    {
        if(current==null)
        {
            return;
        }

        ProcessInvertTree(current.left);
        ProcessInvertTree(current.right);
        TreeNode temp=current.left;
        current.left=current.right;
        current.right=temp;  
        
    }
}