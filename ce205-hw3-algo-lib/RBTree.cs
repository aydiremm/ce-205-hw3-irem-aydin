using System;

public class Node
{
    public int ID;
    public string data;
    public Node parent;
    public Node left;
    public Node right;
    public int color;
}

public class RedBlackTree
{
    public Node root;
    public Node TNULL;


    /**
    * @name   preOrderHelper 
    * 
    * @brief \b  Preorder
    * 
    * @param  [in] node [\b Node] function index of  in the serie 
    *
    * 
    * **/
    private void preOrderHelper(Node node)
    {
        if (node != TNULL)
        {
            Console.Write(node.ID + " ");
            preOrderHelper(node.left);
            preOrderHelper(node.right);
        }
    }

    /**
    * @name   inOrderHelper 
    * 
    * @brief \b  Inorder
    * 
    * @param  [in] node [\b Node] function index of  in the serie 
    *
    * 
    * **/
    private void inOrderHelper(Node node)
    {
        if (node != TNULL)
        {
            inOrderHelper(node.left);
            Console.Write(node.ID + " ");
            inOrderHelper(node.right);
        }
    }


    /**
    * @name   postOrderHelper 
    * 
    * @brief \b Post order
    * 
    * @param  [in] node [\b Node] function index of  in the serie 
    *
    * 
    * **/
    private void postOrderHelper(Node node)
    {
        if (node != TNULL)
        {
            postOrderHelper(node.left);
            postOrderHelper(node.right);
            Console.Write(node.ID + " ");
        }
    }

    /**
    * @name   searchTreeHelper 
    * 
    * @brief \b Search the tree
    * 
    * @param  [in] node [\b Node] function index of  in the serie 
    * 
    * @param  [in] key [\b int] function index of  in the serie 
    * 
    * @param  [in] data [\b string] function index of  in the serie 
    * 
    * @retval [in] searchTreeHelper [\b Node] search the value on tree
    * 
    * **/
    private Node searchTreeHelper(Node node, int key, string data)
    {
        if (node == TNULL || key == node.ID)
        {
            return node;
        }

        if (key < node.ID)
        {
            return searchTreeHelper(node.left, key, data);
        }
        return searchTreeHelper(node.right, key, data);
    }


    /**
    * @name   fixDelete 
    * 
    * @brief \b Balance the tree after deletion of a node
    * 
    * @param  [in] x [\b Node] function index of  in the serie 
    *
    * 
    * **/
    private void fixDelete(Node x)
    {
        //creating a new Node object and assigning it to x.
        Node s;
        //checks if x is equal to root or not.
        while (x != root && x.color == 0)
        {
            //If it is not then the code loops through all of the children
            //of x until it finds one that has a color value of 0.
            if (x == x.parent.left)
            {
                //assigns this child as the parent for another node which becomes its left child and sets its color value to 1.
                s = x.parent.right;
                //repeats until there are no more nodes with a color value of 0 in the tree structure.
                if (s.color == 1)
                {
                    s.color = 0;
                    x.parent.color = 1;
                    leftRotate(x.parent);
                    //The next section starts by checking if s is equal to x's parent on its right side (s == x's parent).
                    s = x.parent.right;
                }

                //then s will be assigned as the right child for another node which becomes its parent and sets its color value to 1.
                if (s.left.color == 0 && s.right.color == 0)
                {
                    s.color = 1;
                    x = x.parent;
                }
                else
                {
                    //If s does not have an adjacent sibling on either side,
                    //then s will be assigned as an ancestor for another node which becomes
                    //its left child and sets its color value to 0 while also setting
                    //itself as having been rotated 180 degrees from where it was originally placed at (x).
                    if (s.right.color == 0)
                    {
                        s.left.color = 0;
                        s.color = 1;
                        rightRotate(s);
                        s = x.parent.right;
                    }
                    //The code will first check if the node is not the root node.
                    s.color = x.parent.color;
                    x.parent.color = 0;
                    s.right.color = 0;
                    leftRotate(x.parent);
                    x = root;
                }
            }
            //If it does reach a leaf node, then the code will set that leaf's color to zero and move on to the next iteration of the while loop.
            else
            {
                s = x.parent.left;
                if (s.color == 1)
                {
                    s.color = 0;
                    x.parent.color = 1;
                    rightRotate(x.parent);
                    s = x.parent.left;
                }

                if (s.right.color == 0 && s.right.color == 0)
                {
                    s.color = 1;
                    x = x.parent;
                }
                else
                {
                    if (s.left.color == 0)
                    {
                        s.right.color = 0;
                        s.color = 1;
                        leftRotate(s);
                        s = x.parent.left;
                    }

                    s.color = x.parent.color;
                    x.parent.color = 0;
                    s.left.color = 0;
                    rightRotate(x.parent);
                    x = root;
                }
            }
        }
        x.color = 0;
    }

    /**
    * @name   rbTransplant 
    * 
    * @brief \b Balance colors
    * 
    * @param  [in] u [\b Node] function index of  in the serie 
    * 
    * @param  [in] v [\b Node] function index of  in the serie 
    *
    * 
    * **/
    private void rbTransplant(Node u, Node v)
    {
        if (u.parent == null)
        {
            root = v;
        }
        else if (u == u.parent.left)
        {
            u.parent.left = v;
        }
        else
        {
            u.parent.right = v;
        }
        v.parent = u.parent;
    }

    /**
    * @name   Delete 
    * 
    * @brief \b Delete vertex from the tree
    * 
    * @param  [in] root [\b Node] function index of  in the serie 
    * 
    * @param  [in] key [\b int] function index of  in the serie 
    * 
    * @param  [in] data [\b string] function index of  in the serie 
    * 
    * @retval [in] deleteNodeHelper [\b Node] delete the value from the tree
    * 
    * **/
    private void deleteNodeHelper(Node node, int key, string data)
    {
        //starts by creating a new Node object called z.
        Node z = TNULL;
        Node x, y;
        //then iterates through all of the nodes in the tree, checking if node is equal to key.
        while (node != TNULL)
        {
            if (node.ID == key)
            {
                //if node is equal to key.
                z = node;
            }

            if (node.ID <= key)
            {
                //z is assigned to node and x becomes its right child.
                node = node.right;
            }
            else
            {
                //y becomes its left child.
                node = node.left;
            }
        }

        //The code then checks if there are any more children for z before continuing on with the next iteration of this loop.

        if (z == TNULL)
        {
            Console.WriteLine("Couldn't find key in the tree");
            return;
        }

        y = z;
        //it assigns y as x's parent and changes both their colors accordingly (yOriginalColor == 0).
        int yOriginalColor = y.color;

        if (z.left == TNULL)
        {
            x = z.right;
            rbTransplant(z, z.right);
        }
        else if (z.right == TNULL)
        {
            x = z.left;
            rbTransplant(z, z.left);
        }
        else
        {
            y = minimum(z.right);
            yOriginalColor = y.color;
            x = y.right;
            if (y.parent == z)
            {
                x.parent = y;
            }
            else
            {
                rbTransplant(y, y.right);
                y.right = z.right;
                y.right.parent = y;
            }

            rbTransplant(z, y);
            y.left = z.left;
            y.left.parent = y;
            y.color = z.color;
        }
        if (yOriginalColor == 0)
        {
            //will delete the node with key "key" from the tree.
            fixDelete(x);
        }
    }



    /**
    * @name   fixInsert 
    * 
    * @brief \b Balance the node after insertion
    * 
    * @param  [in] k [\b Node] function index of  in the serie 
    *
    * 
    * **/
    private void fixInsert(Node k)
    {
        Node u;
        while (k.parent.color == 1)
        {
            if (k.parent == k.parent.parent.right)
            {
                u = k.parent.parent.left;
                if (u.color == 1)
                {
                    u.color = 0;
                    k.parent.color = 0;
                    k.parent.parent.color = 1;
                    k = k.parent.parent;
                }
                else
                {
                    if (k == k.parent.left)
                    {
                        k = k.parent;
                        rightRotate(k);
                    }
                    k.parent.color = 0;
                    k.parent.parent.color = 1;
                    leftRotate(k.parent.parent);
                }
            }
            else
            {
                u = k.parent.parent.right;

                if (u.color == 1)
                {
                    u.color = 0;
                    k.parent.color = 0;
                    k.parent.parent.color = 1;
                    k = k.parent.parent;
                }
                else
                {
                    if (k == k.parent.right)
                    {
                        k = k.parent;
                        leftRotate(k);
                    }
                    k.parent.color = 0;
                    k.parent.parent.color = 1;
                    rightRotate(k.parent.parent);
                }
            }
            if (k == root)
            {
                break;
            }
        }
        root.color = 0;
    }

    /**
    * @name   printHelper 
    * 
    * @brief \b print helper
    * 
    * @param  [in] root [\b Node] function index of  in the serie 
    * 
    * @param  [in] indent [\b String] function index of  in the serie 
    * 
    * @param  [in] last [\b bool] function index of  in the serie 
    * 
    * @retval [in] printHelper [\b Node] it helps to print vertices
    * 
    * **/
    private void printHelper(Node root, String indent, bool last)
    {
        if (root != TNULL)
        {
            Console.WriteLine(indent);
            if (last)
            {
                Console.Write("R----");
                indent += "   ";
            }
            else
            {
                Console.Write("L----");
                indent += "|  ";
            }

            String sColor = root.color == 1 ? "RED" : "BLACK";
            Console.WriteLine(root.ID + "(" + sColor + ")");
            printHelper(root.left, indent, false);
            printHelper(root.right, indent, true);
        }
    }

    public RedBlackTree()
    {
        TNULL = new Node();
        TNULL.color = 0;
        TNULL.left = null;
        TNULL.right = null;
        root = TNULL;
    }

    public void preorder()
    {
        preOrderHelper(this.root);
    }

    public void inorder()
    {
        inOrderHelper(this.root);
    }

    public void postorder()
    {
        postOrderHelper(this.root);
    }

    /**
    * @name   SearchTree 
    * 
    * @brief \b Search the tree
    * 
    * @param  [in] k [\b int] function index of  in the serie 
    * 
    * @param  [in] data [\b string] function index of  in the serie 
    * 
    * @retval [in] SearchTree [\b Node] search the value on tree
    * 
    * **/
    public Node SearchTree(int k, string data)
    {
        return searchTreeHelper(this.root, k, data);
    }

    /**
    * @name   minimum 
    * 
    * @brief \b finds minimum value
    * 
    * @param  [in] node [\b Node] function index of  in the serie 
    *
    * @retval [in] minimum [\b Node] 
    * 
    * **/
    public Node minimum(Node node)
    {
        while (node.left != TNULL)
        {
            node = node.left;
        }
        return node;
    }

    /**
    * @name   maximum 
    * 
    * @brief \b finds maximum value
    * 
    * @param  [in] node [\b Node] function index of  in the serie 
    *
    * @retval [in] maximum [\b Node] 
    * 
    * **/
    public Node maximum(Node node)
    {
        while (node.right != TNULL)
        {
            node = node.right;
        }
        return node;
    }

    /**
    * @name   successor 
    * 
    * @brief \b 
    * 
    * 
    * 
    * @param  [in] node [\b Node] function index of  in the serie 
    *
    * @retval [in] maximum [\b Node] 
    * 
    * **/
    public Node successor(Node x)
    {
        if (x.right != TNULL)
        {
            return minimum(x.right);
        }

        Node y = x.parent;
        while (y != TNULL && x == y.right)
        {
            x = y;
            y = y.parent;
        }
        return y;
    }

    public Node predecessor(Node x)
    {
        if (x.left != TNULL)
        {
            return maximum(x.left);
        }

        Node y = x.parent;
        while (y != TNULL && x == y.left)
        {
            x = y;
            y = y.parent;
        }

        return y;
    }

    /**
    * @name   leftRotate 
    * 
    * @brief \b take vertex to left side
    *
    * @param  [in] node [\b Node] function index of  in the serie 
    * 
    * **/
    public void leftRotate(Node x)
    {
        Node y = x.right;
        x.right = y.left;
        if (y.left != TNULL)
        {
            y.left.parent = x;
        }
        y.parent = x.parent;
        if (x.parent == null)
        {
            this.root = y;
        }
        else if (x == x.parent.left)
        {
            x.parent.left = y;
        }
        else
        {
            x.parent.right = y;
        }
        y.left = x;
        x.parent = y;
    }

    /**
    * @name   rightRotate 
    * 
    * @brief \b take vertex to right side
    *
    * @param  [in] node [\b Node] function index of  in the serie 
    * 
    * **/
    public void rightRotate(Node x)
    {
        Node y = x.left;
        x.left = y.right;
        if (y.right != TNULL)
        {
            y.right.parent = x;
        }
        y.parent = x.parent;
        if (x.parent == null)
        {
            this.root = y;
        }
        else if (x == x.parent.right)
        {
            x.parent.right = y;
        }
        else
        {
            x.parent.left = y;
        }
        y.right = x;
        x.parent = y;
    }

    /**
    * @name   insert 
    * 
    * @brief \b insert values to the tree
    * 
    * @param  [in] key [\b int] function index of  in the serie 
    * 
    * @param  [in] data [\b string] function index of  in the serie 
    * 
    * **/
    public void insert(int key, string data)
    {
        Node node = new Node();
        node.parent = null;
        node.ID = key;
        node.data = data;
        node.left = TNULL;
        node.right = TNULL;
        node.color = 1;

        Node y = null;
        Node x = this.root;

        while (x != TNULL)
        {
            y = x;
            if (node.ID < x.ID)
            {
                x = x.left;
            }
            else
            {
                x = x.right;
            }
        }

        node.parent = y;
        if (y == null)
        {
            root = node;
        }
        else if (node.ID < y.ID)
        {
            y.left = node;
        }
        else
        {
            y.right = node;
        }

        if (node.parent == null)
        {
            node.color = 0;
            return;
        }

        if (node.parent.parent == null)
        {
            return;
        }

        fixInsert(node);
    }

    public Node getRoot()
    {
        return this.root;
    }

    /**
    * @name   deleteNode 
    * 
    * @brief \b delete values from the tree
    * 
    * @param  [in] key [\b int] function index of  in the serie 
    * 
    * @param  [in] data [\b string] function index of  in the serie 
    * 
    * **/
    public void deleteNode(int ID, string data)
    {
        deleteNodeHelper(this.root, ID, data);
    }

    public void printTree()
    {
        printHelper(this.root, "", true);
    }

    /**
    * @name   search 
    * 
    * @brief \b search values in the tree
    * 
    * @param  [in] key [\b int] function index of  in the serie 
    * 
    * @param  [in] data [\b string] function index of  in the serie 
    * 
    * @retval [in] search [\b int]  if value has in tree return 1 else 0
    * 
    * **/
    public int search(int key, string data)
    {

        if (SearchTree(key, data) == null)
            return 0;
        else
            return 1;

    }

}