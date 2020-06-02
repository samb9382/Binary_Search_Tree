using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class TreeNode
    {
        //Member variables
        public int data;
        public TreeNode leftNode;
        public TreeNode rightNode;

        //Constructor
        public TreeNode(int value)
        {
            data = value;
        }


        //Methods
        public void AddNode(int value)
        {
            //if the data passed in is greater than the data add to the right node 
            if (rightNode > data)
            {
                if (rightNode == null) // if right child node is null create a new one
                {
                    rightNode = new TreeNode(value);
                }
                else // if right node is not null add node on the right
                {
                    rightNode.AddNode(value);
                }
            }
            else 
            {
                if (leftNode == null) // if left node is null create a new node
                {
                    leftNode = new TreeNode(value);
                }
                else // if the left node is not null then add node on the left
                {
                    leftNode.AddNode(value); 
                }
            }
        }
       
    }
}
