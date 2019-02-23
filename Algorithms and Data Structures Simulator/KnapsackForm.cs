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
    public partial class KnapsackForm : Form
    {
        public int[] w, v;
        public int[][] V, keep;
        public KnapsackForm()
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

        private void knapsackPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void knapsackButton_Click(object sender, EventArgs e)
        {
            int[] value = StringToIntArray(valueInputTextBox.Text);
            int[] weight = StringToIntArray(weightInputTextBox.Text);
            int[] temp = StringToIntArray(WTextBox.Text);
            int W = temp[0];
            int i = value.Length;
            string[] output = knapsack(i, W, value, weight);
            itemOutputTextBox.Text = output[0].Remove(output[0].Length - 1);
            valueOutputTextBox.Text = output[1];
            weightOutputTextBox.Text = output[2];
        }

        private string[] knapsack(int i, int W, int[] Value, int[] Weight)
        {
            w = new int[i + 1];
            v = new int[i + 1];
            V = new int[i + 1][];
            Array.Copy(Value, v, Value.Length);
            Array.Copy(Weight, w, Weight.Length);
            for (int a = 0; a < i + 1; a++)
                V[a] = new int[W + 1];
            string[] output = new string[3];
            for (int x = i; x > 0; x--)
            {
                v[x] = v[x - 1];
                w[x] = w[x - 1];
            }
            v[0] = 0;
            w[0] = 0;
            W++;
            i++;
            keep = new int[i][];
            for (int a = 0; a < i; a++)
                keep[a] = new int[W];
            for (int x = 0; x < i; x++)
                for (int y = 0; y < W; y++)
                    V[x][y] = 0;
            for (int x = 1; x < i; x++)
                for (int y = 0; y < W; y++)
                    if (w[x] <= y)
                    {
                        V[x][y] = Math.Max(V[x - 1][y], v[x] + V[x - 1][y - w[x]]);
                    }
                    else
                    {
                        V[x][y] = V[x - 1][y];
                    }
            for (int x = 0; x < i; x++)
                for (int y = 0; y < W; y++)
                    keep[x][y] = 0;
            for (int x = 1; x < i; x++)
                for (int y = 0; y < W; y++)
                    if (V[x][y] != V[x - 1][y])
                        keep[x][y] = 1;
            string Item = "";
            int k = W - 1, value = 0, weight = 0;
            for (int x = i - 1; x >= 1; x--)
            {
                if (keep[x][k] == 1)
                {
                    Item += x + ",";
                    k = k - w[x];
                    value += v[x];
                    weight += w[x];
                }
            }
            output[0] = Item;
            output[1] = "" + value;
            output[2] = "" + weight;
            return output;
        }
    }
}
