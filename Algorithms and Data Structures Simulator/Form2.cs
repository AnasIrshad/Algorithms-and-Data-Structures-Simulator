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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //private void tab_Click(object sender, EventArgs e)
        //{
        //    bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
        //}

        private void animationButton_Click(object sender, EventArgs e)
        {
            animationControl.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
        }

        private void visualisationButton_Click(object sender, EventArgs e)
        {
            visualisationControl1.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //exeSortControl1.BringToFront();
            plainColorControl.BringToFront();
            //bubbleSortForm bubbleSortForm = new bubbleSortForm();
            //bubbleSortForm.Show();
            sortControl1.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
        }

        private void exeTreeButton_Click(object sender, EventArgs e)
        {
            // red black tree
            plainColorControl.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            //RedBlackTreeForm redBlackTreeForm = new RedBlackTreeForm();
            //redBlackTreeForm.Show();
            redBlackTreeControl1.BringToFront();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            // about
            aboutControl1.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //exit
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            Environment.Exit(0);
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            // binary tree
            plainColorControl.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            //BinSearchTreeForm binarySearchTreeForm = new BinSearchTreeForm();
            //binarySearchTreeForm.Show();
            binaryTreeControl1.BringToFront();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            // KD tree
            plainColorControl.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            //KDTreeForm kDTreeForm = new KDTreeForm();
            //kDTreeForm.Show();
            kdTreeControl1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //knap sack
            plainColorControl.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            //KnapsackForm knapsackForm = new KnapsackForm();
            //knapsackForm.Show();
            knapsackControl1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            //chain
            plainColorControl.BringToFront();
            bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
            //matrixChainMultForm matrixChainMultForm = new matrixChainMultForm();
            //matrixChainMultForm.Show();
            matrixChainMultControl1.BringToFront();
        }
    }
}
