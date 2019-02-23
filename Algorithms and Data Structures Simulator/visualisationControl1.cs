using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class visualisationControl1 : UserControl
    {
        public visualisationControl1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            //quick sort button
            quickpic.BringToFront();
            backpic.BringToFront();
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            //heap sort button
            heappic.BringToFront();
            backpic.BringToFront();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            //radix sort button
            radixpic.BringToFront();
            backpic.BringToFront();
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            //merge sort button
            mergepic.BringToFront();
            backpic.BringToFront();
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            //bubble sort button
            bubblepic.BringToFront();
            backpic.BringToFront();
        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {
            //tree insert button
            insertpic.BringToFront();
            backpic.BringToFront();
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {
            //tree remove button
            removepic.BringToFront();
            backpic.BringToFront();
        }

        private void bunifuFlatButton22_Click(object sender, EventArgs e)
        {
            //tree traverse button
            traversepic.BringToFront();
            backpic.BringToFront();
        }

        private void RedBlackTreePictureBox_Click(object sender, EventArgs e)
        {
            //back button
            backpic.SendToBack();
            quickpic.SendToBack();
            heappic.SendToBack();
            radixpic.SendToBack();
            mergepic.SendToBack();
            bubblepic.SendToBack();
            insertpic.SendToBack();
            removepic.SendToBack();
            traversepic.SendToBack();
        }
    }
}
