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
                //if the root is not null then we add a node
                root.AddNode(data);
            }
            else 
            {
                //if the root is null then root becomes a new node
                root = new TreeNode(data);
            }

        }


    }
}
