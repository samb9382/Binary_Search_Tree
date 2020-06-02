using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class TreeNode
    {
        //Member variables
        private int data;
        public int Data
        {
            get { return data; }
            set { Data = data; }
        }
        private TreeNode leftNode;
        public TreeNode LeftNode//get sets to return value for the leftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }
        private TreeNode rightNode;
        public TreeNode RightNode//get sets to return value for the rightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }
        

        //Constructor
        public TreeNode(int value)
        {
            data = value;
        }


        //Methods

        public void Insert(int value)
        {
            //if the value passed in is greater than the data insert to the right node 
            if (value > data)
            {
                if (rightNode == null) // if right child node is null create a new node
                {
                    rightNode = new TreeNode(value);
                }
                else // if right node is not null add node on the right
                {
                    rightNode.Insert(value);
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
                    leftNode.Insert(value);
                }
            }
        }
       
    }
}
