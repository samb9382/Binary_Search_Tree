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

        
       
    }
}
