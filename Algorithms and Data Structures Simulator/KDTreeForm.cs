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
    public partial class KDTreeForm : Form
    {
        public KDTreeForm()
        {
            InitializeComponent();
        }
        private static double[] StringToDoubleArray(string myNumbers)
        {
            List<double> myDouble = new List<double>();
            Array.ForEach(myNumbers.Split(",".ToCharArray()), s =>
            {
                double currentDouble;
                if (double.TryParse(s, out currentDouble))
                    myDouble.Add(currentDouble);
            });
            return myDouble.ToArray();
        }

        private void KDTreeForm_Load(object sender, EventArgs e)
        {

        }

        public class KD2DNode
        {
            public int axis;
            public double[] x;
            public int id;
            public bool isChecked;
            public bool orientation;

            public KD2DNode Parent;
            public KD2DNode Left;
            public KD2DNode Right;

            public KD2DNode(double[] x0, int axis0)
            {
                x = new double[2];
                axis = axis0;
                for (int k = 0; k < 2; k++)
                    x[k] = x0[k];

                Left = Right = Parent = null;
                isChecked = false;
                id = 0;
            }

            public KD2DNode FindParent(double[] x0)
            {
                KD2DNode parent = null;
                KD2DNode next = this;
                int split;
                while (next != null)
                {
                    split = next.axis;
                    parent = next;
                    if (x0[split] > next.x[split])
                        next = next.Right;
                    else
                        next = next.Left;
                }
                return parent;
            }

            public KD2DNode Insert(double[] p)
            {
                x = new double[2];
                KD2DNode parent = FindParent(p);
                if (equal(p, parent.x, 2) == true)
                    return null;

                KD2DNode newNode = new KD2DNode(p,
                        parent.axis + 1 < 2 ? parent.axis + 1 : 0);
                newNode.Parent = parent;

                if (p[parent.axis] > parent.x[parent.axis])
                {
                    parent.Right = newNode;
                    newNode.orientation = true;
                }
                else
                {
                    parent.Left = newNode;
                    newNode.orientation = false;
                }

                return newNode;
            }

            public bool equal(double[] x1, double[] x2, int dim)
            {
                for (int k = 0; k < dim; k++)
                {
                    if (x1[k] != x2[k])
                        return false;
                }

                return true;
            }

            public double distance2(double[] x1, double[] x2, int dim)
            {
                double S = 0;
                for (int k = 0; k < dim; k++)
                    S += (x1[k] - x2[k]) * (x1[k] - x2[k]);
                return S;
            }
        }
        public class KDTree
        {
            public string preOrd, inOrd, postOrd;
            KD2DNode Root;

            int TimeStart, TimeFinish;
            int CounterFreq;

            double d_min;
            KD2DNode nearest_neighbour;

            int KD_id;

            int nList;

            KD2DNode[] CheckedNodes;
            int checked_nodes;
            KD2DNode[] List;

            double[] x_min, x_max;
            bool[] max_boundary, min_boundary;
            int n_boundary;
            public KDTree(int i)
            {
                Root = null;
                KD_id = 1;
                nList = 0;
                List = new KD2DNode[i];
                CheckedNodes = new KD2DNode[i];
                max_boundary = new bool[2];
                min_boundary = new bool[2];
                x_min = new double[2];
                x_max = new double[2];
            }

            public bool add(double[] x)
            {
                if (nList >= 2000000 - 1)
                    return false; // can't add more points

                if (Root == null)
                {
                    Root = new KD2DNode(x, 0);
                    Root.id = KD_id++;
                    List[nList++] = Root;
                }
                else
                {
                    KD2DNode pNode;
                    if ((pNode = Root.Insert(x)) != null)
                    {
                        pNode.id = KD_id++;
                        List[nList++] = pNode;
                    }
                }

                return true;
            }

            public KD2DNode find_nearest(double[] x)
            {
                if (Root == null)
                    return null;

                checked_nodes = 0;
                KD2DNode parent = Root.FindParent(x);
                nearest_neighbour = parent;
                d_min = Root.distance2(x, parent.x, 2);
                ;

                if (parent.equal(x, parent.x, 2) == true)
                    return nearest_neighbour;

                search_parent(parent, x);
                uncheck();

                return nearest_neighbour;
            }

            public void check_subtree(KD2DNode node, double[] x)
            {
                if ((node == null) || node.isChecked)
                    return;

                CheckedNodes[checked_nodes++] = node;
                node.isChecked = true;
                set_bounding_cube(node, x);

                int dim = node.axis;
                double d = node.x[dim] - x[dim];

                if (d * d > d_min)
                {
                    if (node.x[dim] > x[dim])
                        check_subtree(node.Left, x);
                    else
                        check_subtree(node.Right, x);
                }
                else
                {
                    check_subtree(node.Left, x);
                    check_subtree(node.Right, x);
                }
            }

            public void set_bounding_cube(KD2DNode node, double[] x)
            {
                if (node == null)
                    return;
                int d = 0;
                double dx;
                for (int k = 0; k < 2; k++)
                {
                    dx = node.x[k] - x[k];
                    if (dx > 0)
                    {
                        dx *= dx;
                        if (!max_boundary[k])
                        {
                            if (dx > x_max[k])
                                x_max[k] = dx;
                            if (x_max[k] > d_min)
                            {
                                max_boundary[k] = true;
                                n_boundary++;
                            }
                        }
                    }
                    else
                    {
                        dx *= dx;
                        if (!min_boundary[k])
                        {
                            if (dx > x_min[k])
                                x_min[k] = dx;
                            if (x_min[k] > d_min)
                            {
                                min_boundary[k] = true;
                                n_boundary++;
                            }
                        }
                    }
                    double temp = d;
                    temp += dx;
                    if (temp > d_min)
                        return;
                }

                if (d < d_min)
                {
                    d_min = d;
                    nearest_neighbour = node;
                }
            }

            public KD2DNode search_parent(KD2DNode parent, double[] x)
            {
                for (int k = 0; k < 2; k++)
                {
                    x_min[k] = x_max[k] = 0;
                    max_boundary[k] = min_boundary[k] = false; //
                }
                n_boundary = 0;

                KD2DNode search_root = parent;
                while (parent != null && (n_boundary != 2 * 2))
                {
                    check_subtree(parent, x);
                    search_root = parent;
                    parent = parent.Parent;
                }

                return search_root;
            }

            public void uncheck()
            {
                for (int n = 0; n < checked_nodes; n++)
                    CheckedNodes[n].isChecked = false;
            }

            public void inorder()
            {
                inorder(Root);
            }

            private void inorder(KD2DNode root)
            {
                if (root != null)
                {
                    inorder(root.Left);
                    inOrd += "(" + root.x[0] + ", " + root.x[1] + ")  ";
                    inorder(root.Right);
                }
            }

            public void preorder()
            {
                preorder(Root);
            }

            private void preorder(KD2DNode root)
            {
                if (root != null)
                {
                    preOrd += "(" + root.x[0] + ", " + root.x[1] + ")  ";
                    preorder(root.Left);
                    preorder(root.Right);
                }
            }

            public void postorder()
            {
                postorder(Root);
            }

            private void postorder(KD2DNode root)
            {
                if (root != null)
                {
                    postorder(root.Left);
                    postorder(root.Right);
                    postOrd += "(" + root.x[0] + ", " + root.x[1] + ")  ";
                }
            }
        }

        private void KDTreeButton_Click(object sender, EventArgs e)
        {
            int numpoints = 5;
            double[] dimX = StringToDoubleArray(KDTreeInputXTextBox.Text);
            double[] dimY = StringToDoubleArray(KDTreeInputYTextBox.Text);
            double[] x = new double[2];
            KDTree preOrdkDTree = new KDTree(numpoints);
            KDTree postOrdkDTree = new KDTree(numpoints);
            KDTree inOrdkDTree = new KDTree(numpoints);
            for (int i = 0; i < dimX.Length; i++)
            {
                x[0] = dimX[i];
                x[1] = dimY[i];
                preOrdkDTree.add(x);
                inOrdkDTree.add(x);
                postOrdkDTree.add(x);
            }
            inOrdkDTree.inorder();
            preOrdkDTree.preorder();
            postOrdkDTree.postorder();
            KDTreePreOutputTextBox.Text = preOrdkDTree.preOrd;
            KDTreeInOutputTextBox.Text = inOrdkDTree.inOrd;
            KDTreePostOutputTextBox.Text = postOrdkDTree.postOrd;
        }

        private void KDTreePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form2 form2 = new Form2();
            //form2.Show();
        }
    }
}
