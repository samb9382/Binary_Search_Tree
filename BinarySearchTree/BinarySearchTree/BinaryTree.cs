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
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
        }
        
        //Constructor
        public BinaryTree()
        {

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

        public void SearchNode()//search for specific value within the BST data structrure
        {
            

        }

    }
}
