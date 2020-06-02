using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(80);
            binaryTree.Insert(55);
            binaryTree.Insert(69);
            binaryTree.Insert(77);
            binaryTree.Insert(8);
            binaryTree.Insert(32);
        }
    }
}
