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
    public partial class BinSearchTreeForm : Form
    {
        public BinSearchTreeForm()
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
        
        public class BTNode
        {
            BTNode left, right, parent;
            int value;
            public BTNode()
            {
                left = null;
                right = null;
                parent = null;
                value = 0;
            }
            public BTNode(int val)
            {
                left = null;
                right = null;
                parent = null;
                value = val;
            }

            public void setLeft(BTNode BTNode) { left = BTNode; }
            public BTNode getLeft() { return left; }
            public void setRight(BTNode BTNode) { right = BTNode; }
            public BTNode getRight() { return right; }
            public void setParent(BTNode BTNode) { parent = BTNode; }
            public BTNode getParent() { return parent; }
            public void setValue(int val) { value = val; }
            public int getValue() { return value; }
        }
        class Tree
        {
            public BTNode root;
            public string preOrd, postOrd, inOrd;
            public Tree()
            {
                root = null;
                preOrd = "";
                inOrd = "";
                postOrd = "";
            }
            public BTNode ReturnRoot()
            {
                return root;
            }
            public void Insert(int id)
            {
                BTNode newBTNode = new BTNode();
                newBTNode.setValue(id);
                if (root == null)
                    root = newBTNode;
                else
                {
                    BTNode current = root;
                    BTNode parent;
                    while (true)
                    {
                        parent = current;
                        if (id < current.getValue())
                        {
                            current = current.getLeft();
                            if (current == null)
                            {
                                parent.setLeft(newBTNode);
                                return;
                            }
                        }
                        else
                        {
                            current = current.getRight();
                            if (current == null)
                            {
                                parent.setRight(newBTNode);
                                return;
                            }
                        }
                    }
                }
            }
            public void Preorder(BTNode Root)
            {
                if (Root != null)
                {
                    preOrd += Root.getValue() + ",";
                    Preorder(Root.getLeft());
                    Preorder(Root.getRight());
                }
            }
            public void Inorder(BTNode Root)
            {

                if (Root != null)
                {
                    Inorder(Root.getLeft());
                    inOrd += Root.getValue() + ",";
                    Inorder(Root.getRight());
                }
            }
            public void Postorder(BTNode Root)
            {
                if (Root != null)
                {
                    Postorder(Root.getLeft());
                    Postorder(Root.getRight());
                    postOrd += Root.getValue() + ",";
                }
            }
        }
        private void BinSearchTreeButton_Click(object sender, EventArgs e)
        {
            int[] arr = StringToIntArray(BinSearchTreeInputTextBox.Text);
            Tree PreBST = new Tree();
            Tree InBST = new Tree();
            Tree PostBST = new Tree();
            for (int i = 0; i < arr.Length; i++)
            {
                PreBST.Insert(arr[i]);
                InBST.Insert(arr[i]);
                PostBST.Insert(arr[i]);
            }
            PreBST.Preorder(PreBST.root);
            InBST.Inorder(InBST.root);
            PostBST.Postorder(PostBST.root);
            BinSearchTreePreOutputTextBox.Text = PreBST.preOrd.Remove(PreBST.preOrd.Length - 1, 1);
            BinSearchTreeInOutputTextBox.Text = InBST.inOrd.Remove(PreBST.preOrd.Length - 1, 1);
            BinSearchTreePostOutputTextBox.Text = PostBST.postOrd.Remove(PreBST.preOrd.Length - 1, 1);
        }

        private void BinSearchTreePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form2 form2 = new Form2();
            //form2.Show();
        }

    }
}
