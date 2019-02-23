using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class RedBlackTreeForm : Form
    {
        public RedBlackTreeForm()
        {
            InitializeComponent();
        }
        private static int[] StringToIntArray(string myNumbers)
        {
            List<int> myIntegers = new List<int>();
            Array.ForEach(myNumbers.Split(",".ToCharArray()), s =>
            {
                int currentInt;
                if (Int32.TryParse(s, out currentInt))
                    myIntegers.Add(currentInt);
            });
            return myIntegers.ToArray();
        }
        public class RBTNode
        {
            public RBTNode left, right;
            public int value, NoOfNodes;
            public enum colour { RED, BLACK };
            public colour Colour;
            public RBTNode()
            {
                left = null;
                right = null;
                value = 0;
                Colour = colour.RED;
                NoOfNodes = 0;
            }
            public RBTNode(int val)
            {
                left = null;
                right = null;
                value = val;
                Colour = colour.RED;
                NoOfNodes = 0;
            }
            public void setLeft(RBTNode Node) { left = Node; }
            public RBTNode getLeft() { return left; }
            public void setRight(RBTNode Node) { right = Node; }
            public RBTNode getRight() { return right; }
            public void setValue(int val) { value = val; }
            public int getValue() { return value; }
            public void setColour(colour Name) { Colour = Name; }
            public colour getColour() { return Colour; }
        }
        public class RBT
        {
            public string preOrd, postOrd, inOrd;
            public RBTNode.colour Red, Black, NullNodeColour;
            public RBTNode root;
            public RBT()
            {
                root = null;
                Red = RBTNode.colour.RED;
                Black = RBTNode.colour.BLACK;
                NullNodeColour = Black;
                //                levelOrd = "";
            }
            public RBTNode.colour getColour(RBTNode Node)
            {
                if (Node == null) return NullNodeColour;
                else return Node.Colour;
            }
            public void Insert(int value)
            {
                root = Insert(value, root);
                if (getColour(root) == Red)
                    root.Colour = Black;
            }
            private RBTNode Insert(int value, RBTNode Node)
            {
                if (Node == null) return new RBTNode(value);
                if (value < Node.value) Node.left = Insert(value, Node.left);
                else if (value > Node.value) Node.right = Insert(value, Node.right);
                else Node.value = value;
                if (getColour(Node.right) == Red && getColour(Node.left) != Red)
                    Node = rotateLeft(Node);
                if (getColour(Node.left) == Red && getColour(Node.left.left) == Red)
                    Node = rotateRight(Node);
                if (getColour(Node.left) == Red && getColour(Node.right) == Red)
                    flipColour(Node);
                Node.NoOfNodes = size(Node.left) + size(Node.right) + 1;
                return Node;
            }
            public int size() { return size(root); }
            private int size(RBTNode Node)
            {
                if (Node == null) return 0;
                else return Node.NoOfNodes;
            }
            private RBTNode rotateLeft(RBTNode Node)
            {
                RBTNode temp = Node.right;
                Node.right = temp.left;
                temp.left = Node;
                temp.Colour = getColour(Node.left);
                temp.left.Colour = Red;
                temp.NoOfNodes = Node.NoOfNodes;
                Node.NoOfNodes = size(Node.left) + size(Node.right) + 1;
                return temp;
            }
            private RBTNode rotateRight(RBTNode Node)
            {
                RBTNode temp = Node.left;
                Node.left = temp.right;
                temp.right = Node;
                temp.Colour = getColour(Node.right);
                temp.right.Colour = Red;
                temp.NoOfNodes = Node.NoOfNodes;
                Node.NoOfNodes = size(Node.left) + size(Node.right) + 1;
                return temp;
            }
            private RBTNode flipColour(RBTNode Node)
            {
                RBTNode.colour temp;
                temp = Node.left.Colour;
                Node.left.Colour = Node.Colour;
                Node.right.Colour = Node.Colour;
                Node.Colour = temp;
                return Node;
            }
            public bool isEmpty() { return root == null; }
            private RBTNode min(RBTNode Node)
            {
                if (Node.left == null) return Node;
                return min(Node.left);
            }
            private RBTNode deleteMin(RBTNode Node)
            {
                if (Node.left == null) return Node.right;
                Node.left = deleteMin(Node.left);
                return Node;
            }
            public void Delete(int value)
            {
                if (getColour(root.left) == Black && getColour(root.right) == Black)
                    root.Colour = Red;
                root = Delete(value, root);
                if (!isEmpty() && getColour(root) == Red) root.Colour = Black;
            }
            private RBTNode Delete(int value, RBTNode Node)
            {
                if (value < Node.value)
                {
                    if (getColour(Node.left) == Black && getColour(Node.left.left) == Black)
                    {
                        flipColour(Node);
                        if (getColour(Node.right.left) == Red)
                        {
                            Node.right = rotateRight(Node.right);
                            Node = rotateLeft(Node);
                            flipColour(Node);
                        }
                    }
                    Node.left = Delete(value, Node.left);
                }
                else
                {
                    if (getColour(Node.left) == Red) Node = rotateRight(Node);
                    if (value == Node.value && (Node.right == null)) return null;
                    if (getColour(Node.right) == Black && getColour(Node.right.left) == Black)
                    {
                        flipColour(Node);
                        if (getColour(Node.left.left) == Red)
                        {
                            Node = rotateRight(Node);
                            flipColour(Node);
                        }
                    }
                    if (value == Node.value)
                    {
                        RBTNode temp = min(Node.right);
                        Node.value = temp.value;
                        Node.right = deleteMin(Node.right);
                    }
                    else Node.right = Delete(value, Node.right);
                }
                return Balance(Node);
            }
            private RBTNode Balance(RBTNode Node)
            {
                if (getColour(Node.right) == Red) Node = rotateLeft(Node);
                if (getColour(Node.left) == Red && getColour(Node.left.left) == Red) Node = rotateRight(Node);
                if (getColour(Node.left) == Red && getColour(Node.right) == Red) flipColour(Node);
                Node.NoOfNodes = size(Node.left) + size(Node.right) + 1;
                return Node;
            }
            private int Height(RBTNode Node)
            {
                if (Node == null)
                    return -1;
                return 1 + Math.Max(Height(Node.left), Height(Node.right));
            }
            /*            public void LevelOrder()
                        {
                            int h = Height(root) + 1;
                            for (int i = 1; i <= h; i++)
                                printGivenLevel(root, i);
                        }
                        private void printGivenLevel(RBTNode Node, int level)
                        {
                            if (Node == null)
                                return;
                            if (level == 1)
                                levelOrd += Node.value + ",";
                            else if (level > 1)
                            {
                                printGivenLevel(Node.left, level - 1);
                                printGivenLevel(Node.right, level - 1);
                            }
                        }
            */
            public void Preorder(RBTNode Root)
            {
                if (Root != null)
                {
                    preOrd += Root.getValue() + ",";
                    Preorder(Root.getLeft());
                    Preorder(Root.getRight());
                }
            }
            public void Inorder(RBTNode Root)
            {

                if (Root != null)
                {
                    Inorder(Root.getLeft());
                    inOrd += Root.getValue() + ",";
                    Inorder(Root.getRight());
                }
            }
            public void Postorder(RBTNode Root)
            {
                if (Root != null)
                {
                    Postorder(Root.getLeft());
                    Postorder(Root.getRight());
                    postOrd += Root.getValue() + ",";
                }
            }
        }

        private void RedBlackTreeButton_Click(object sender, EventArgs e)
        {
            int[] arr = StringToIntArray(RedBlackTreeInputTextBox.Text);
            RBT PreRBT = new RBT();
            RBT InRBT = new RBT();
            RBT PostRBT = new RBT();
            for (int i = 0; i < arr.Length; i++)
            {
                PreRBT.Insert(arr[i]);
                InRBT.Insert(arr[i]);
                PostRBT.Insert(arr[i]);
            }
            PreRBT.Preorder(PreRBT.root);
            InRBT.Inorder(InRBT.root);
            PostRBT.Postorder(PostRBT.root);
            RedBlackTreePreOutputTextBox.Text = PreRBT.preOrd.Remove(PreRBT.preOrd.Length - 1, 1);
            RedBlackTreeInOutputTextBox.Text = InRBT.inOrd.Remove(InRBT.inOrd.Length - 1, 1);
            RedBlackTreePostOutputTextBox.Text = PostRBT.postOrd.Remove(PostRBT.postOrd.Length - 1, 1);
        }

        private void RedBlackTreePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form2 form2 = new Form2();
            //form2.Show();
        }
        
    }
}
