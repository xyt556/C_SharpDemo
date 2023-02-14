using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_BinaryTree
{
    class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            Root = InsertRecursive(Root, data);
        }

        private Node InsertRecursive(Node current, int data)
        {
            if (current == null)
            {
                return new Node(data);
            }

            if (data < current.Data)
            {
                current.Left = InsertRecursive(current.Left, data);
            }
            else
            {
                current.Right = InsertRecursive(current.Right, data);
            }

            return current;
        }

        public void InOrderTraversal()
        {
            InOrderTraversalRecursive(Root);
        }

        private void InOrderTraversalRecursive(Node current)
        {
            if (current != null)
            {
                InOrderTraversalRecursive(current.Left);
                Console.WriteLine(current.Data);
                InOrderTraversalRecursive(current.Right);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(9);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(10);
            tree.Insert(11);
            Console.WriteLine("In-Order Traversal:");
            tree.InOrderTraversal();
            Console.ReadLine();
        }
    }

}
/*
 * 在上面的代码中，我们定义了一个Node类，表示二叉树中的每个节点。该类具有数据，左子树和右子树等属性。
 * 接下来，我们定义了一个BinaryTree类，它是二叉树的主要实现。该类提供了插入数据，中序遍历等功能。
 * 最后，在Main函数中，我们创建了一个BinaryTree对象，并向其插入了数数据，然后调用InOrderTraversal（）方法来遍历二叉树并显示其所有节点的数据。
 * 需要注意的是，这只是二叉树的一种实现方法，还有很多其他实现方法。根据需求和项目需要，可以选择其他的实现方法。
 */