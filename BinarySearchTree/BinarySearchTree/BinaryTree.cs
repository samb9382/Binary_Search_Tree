using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        //Member variables
        
        public TreeNode root;
        
        
        //Constructor
        public BinaryTree()
        {
            root = null;

        }

        //Methods
        public void Insert(int data)
        {
            if (root != null)
            {
                //if the root is not null then add a node
                root.Insert(data);
            }
            else 
            {
                //if the root is null then root becomes a new node
                root = new TreeNode(data);
            }

        }

        public void AddNode()//add new node with data onto the BST
        {
            

        }

        public bool SearchNodes(TreeNode root, int searchPoint)//search for specific value within the BST data structrure
        //if searchPoint is the same as the data then it is true
        //if the searchPoint is less than the data look left of the root
        //if the searchPoint is greater than the data look right of the root
        {
            if (root == null)
            {
                return false;
            }

            

        }

    }
}
