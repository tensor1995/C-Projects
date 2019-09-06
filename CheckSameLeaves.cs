using System;
using System.Collections.Generic;

public class Node
{
    public int data;
    public Node left;
    public Node right;

    public Node(int x)
    {
        data = x;
        left = right = null;
    }

    public virtual bool IsLeaf
    {
        get
        {
            return (left == null && right == null);
        }
    }
} /* End of class Node */

public class CheckSameLeaves
{

    public bool IsSame(Node root1, Node root2)
    {

        Stack<Node> stackone = new Stack<Node>();
        Stack<Node> stacktwo = new Stack<Node>();

        stackone.Push(root1);
        stacktwo.Push(root2);

        while (stackone.Count > 0 || stacktwo.Count > 0)
        {

            if (stackone.Count == 0 || stacktwo.Count == 0)
            {
                return false;
            }

            Node temp1 = stackone.Pop();

            while (temp1 != null && temp1.IsLeaf == false)
            {

                if (temp1.right != null)
                {
                    stackone.Push(temp1.right);
                }
                if (temp1.left != null)
                {
                    stackone.Push(temp1.left);
                }

                temp1 = stackone.Pop();
            }

            Node temp2 = stacktwo.Pop();

            while (temp2 != null && temp2.IsLeaf == false)
            {

                if (temp2.right != null)
                {
                    stacktwo.Push(temp2.right);
                }
                if (temp2.left != null)
                {
                    stacktwo.Push(temp2.left);
                }

                temp2 = stacktwo.Pop();
            }

            if (temp1 == null && temp2 != null)
            {
                return false;
            }

            if (temp2 == null && temp1 != null)
            {
                return false;
            }

            if (temp1 != null && temp2 != null)
            {
                if (temp1.data != temp2.data)
                {
                    return false;
                }
            }

            
        }

        return true;
    } /* kuck */
} /* End of class CheckSameLeaves */

public class Driver
{

    public static void Main()
    {
        Node root1 = new Node(1);
        root1.left = new Node(2);
        root1.right = new Node(3);
        root1.left.left = new Node(4);
        root1.right.left = new Node(6);
        root1.right.right = new Node(7);

        Node root2 = new Node(0);
        root2.left = new Node(1);
        root2.right = new Node(5);
        root2.left.right = new Node(1);
        root2.right.left = new Node(6);
        root2.right.right = new Node(7);

        CheckSameLeaves obj = new CheckSameLeaves();
        if (obj.IsSame(root1, root2))
        {
            Console.Write("Same");
        }
        else
        {
            Console.Write("Not Same");
        }
    }
}
