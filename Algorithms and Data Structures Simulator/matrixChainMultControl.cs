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
    public partial class matrixChainMultControl : UserControl
    {
        public matrixChainMultControl()
        {
            InitializeComponent();
        }

        string matrix;

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

        public void matrixChainMult(int[] arr)
        {
            matrix = "";
            int[] p = new int[arr.Length + 1];
            Array.Copy(arr, p, arr.Length);
            int L = p.Length + 1;
            int[][] m = new int[L][];
            for (int a = 0; a < L; a++)
                m[a] = new int[L];
            int[][] s = new int[L][];
            for (int a = 0; a < L; a++)
                s[a] = new int[L];
            int n, i, ll, j, k, q;
            i = p.Length;
            n = i - 1;
            for (i = 1; i <= n; i++)
                m[i][i] = 0;
            for (ll = 2; ll <= n; ll++)
                for (i = 1; i <= n - ll + 1; i++)
                {
                    j = i + ll - 1;
                    m[i][j] = Int16.MaxValue;
                    for (k = i; k <= j - 1; k++)
                    {
                        q = m[i][k] + m[k + 1][j] + (p[i - 1] * p[k] * p[j]);
                        if (q < m[i][j])
                        {
                            m[i][j] = q;
                            s[i][j] = k;
                        }
                    }
                }
            matrix = r3(1, n, s);
            for (int z = 2; z < n; z++)
            {
                for (i = 1; i < n - z + 1; i++)
                {
                    j = i + z - 1;
                    if (j == n) continue;
                    m[i][j] = Int16.MaxValue;
                    for (k = i; k <= j - 1; k++)
                    {
                        q = m[i][k] + m[k + 1][j] + p[i - 1] * p[k] * p[j];
                        if (q < m[i][j])
                            m[i][j] = q;
                    }
                }
            }
            noOfMultTextBox.Text = "" + m[1][n - 1];
            matrixTextBox.Text = matrix;
        }
        private string r3(int i, int j, int[][] s)
        {
            int k;
            if (i == j)
            {
                matrix = matrix + "A" + i;
                return matrix;
            }
            matrix += "(";
            k = s[i][j];
            matrix = r3(i, k, s);
            matrix += "*";
            matrix = r3(k + 1, j, s);
            matrix += ")";
            return matrix;
        }
        private void matrixChainMultForm_Load(object sender, EventArgs e)
        {

        }
        private void matrixChainMultButton_Click(object sender, EventArgs e)
        {
            int[] dim = StringToIntArray(DimMatrixTextBox.Text);
            matrixChainMult(dim);
        }

        private void noOfMultLabel_Click(object sender, EventArgs e)
        {

        }

        private void matrixChainMultPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form2 form2 = new Form2();
            //form2.Show();
        }
    }
}
