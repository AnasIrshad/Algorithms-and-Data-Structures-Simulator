using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Project1
{
    public partial class sortControl : UserControl
    {
        public sortControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

        private int[] bubbleSort(int[] arr, int first, int last)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(arr, j, j + 1);
                        count++;
                    }
                }
                if (count == 0)
                    i = arr.Length - 1;
            }
            return arr;
        }
        private void swap(int[] list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        private string showArray(int[] array, int flag)
        {
            string toChar = "";
            if (flag == 0)
            {
                for (int k = 0; k < array.Length - 1; k++)
                    toChar = toChar + array[k] + ",";
                toChar += array[array.Length - 1];
            }
            else
            {
                for (int k = array.Length - 1; k > 0; k--)
                    toChar = toChar + array[k] + ",";
                toChar += array[0];
            }
            bubbleSortOutputTextBox.Text = toChar;
            return toChar;
        }
        private void bubbleSortAButton_Click(object sender, EventArgs e)
        {
            if (bubbleButton.Checked)
            {
                int[] arrayToSort = StringToIntArray(bubbleSortInputTextBox.Text);
                int[] sortedArray = bubbleSort(arrayToSort, 0, arrayToSort.Length - 1);
                showArray(arrayToSort, 0);
            }
            else if (quickButton.Checked)
            {
                int[] arr = StringToIntArray(bubbleSortInputTextBox.Text);
                QuickSort(arr, 0, arr.Length - 1);
                qprintArray(arr, 0);
            }
            else if (radixButton.Checked)
            {
                RadixSort(StringToIntArray(bubbleSortInputTextBox.Text), 0);
            }
            else
            {
                int[] arrayToSort = StringToIntArray(bubbleSortInputTextBox.Text);
                int[] sortedArray = bubbleSort(arrayToSort, 0, arrayToSort.Length - 1);
                showArray(arrayToSort, 0);
            }
        }

        private void bubbleSortDButton_Click(object sender, EventArgs e)
        {
            if (bubbleButton.Checked)
            {
                int[] arrayToSort = StringToIntArray(bubbleSortInputTextBox.Text);
                int[] sortedArray = bubbleSort(arrayToSort, 0, arrayToSort.Length - 1);
                showArray(sortedArray, 1);
            }
            else if (quickButton.Checked)
            {
                int[] arr = StringToIntArray(bubbleSortInputTextBox.Text);
                QuickSort(arr, 0, arr.Length - 1);
                qprintArray(arr, 1);
            }
            else if (radixButton.Checked)
            {
                RadixSort(StringToIntArray(bubbleSortInputTextBox.Text), 1);
            }
            else
            {
                int[] arrayToSort = StringToIntArray(bubbleSortInputTextBox.Text);
                int[] sortedArray = bubbleSort(arrayToSort, 0, arrayToSort.Length - 1);
                showArray(sortedArray, 1);
            }
        }


        private void bubbleSortForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
            else
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }


        private void accessFile()
        {
            if (File.Exists("sortNumbers.txt"))
            {
                string content = File.ReadAllText("sortNumbers.txt");
                int[] arrayToSort = StringToIntArray(content);
                int[] sortedArray = bubbleSort(arrayToSort, 0, arrayToSort.Length - 1);
                string content1 = showArray(arrayToSort, 0);
                if (File.Exists("bubbleSortResult.txt"))
                    File.Delete("bubbleSortResult.txt");
                File.WriteAllText("bubbleSortResult.txt", content1);
            }
            else
            {
                MessageBox.Show("Create a Text File named\"sortNumbers.txt\"\n              containing numbers to Sort", "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bubbleSortFileButton_Click(object sender, EventArgs e)
        {
            accessFile();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form2 form2 = new Form2();
            //form2.Show();
        }
        public void closefor()
        {
            this.Hide();
        }
        private static int median(int[] a, int p, int q)
        {
            qswap(a, p, (p + q) / 2);
            return a[(p + q) / 2];
        }
        public static void QuickSort(int[] a, int p, int q)
        {
            int pivot = median(a, p, q - 1);
            int r = partition(a, p, q, pivot);
            if (p < r - 1) QuickSort(a, p, r - 1);
            if (q > r) QuickSort(a, r, q);
        }
        private static int partition(int[] a, int p, int q, int pivot)
        {
            while (p <= q)
            {
                while (a[p] > pivot) p++;
                while (a[q] < pivot) q--;
                if (p <= q)
                {
                    qswap(a, p, q);
                    p++;
                    q--;
                }
            }
            return p;
        }
        private static void qswap(int[] a, int x, int y)
        {
            int temp = a[x];
            a[x] = a[y];
            a[y] = temp;
        }
        public void qprintArray(int[] arr, int flag)
        {
            string temp = "";
            if (flag == 0)
            {
                for (int i = arr.Length - 1; i > 0; i--) temp = temp + arr[i] + ",";
                temp += arr[0];
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++) temp = temp + arr[i] + ",";
                temp += arr[arr.Length - 1];
            }
            bubbleSortOutputTextBox.Text = temp;
        }
        private void quickSortAButton_Click(object sender, EventArgs e)
        {
            int[] arr = StringToIntArray(bubbleSortInputTextBox.Text);
            QuickSort(arr, 0, arr.Length - 1);
            qprintArray(arr, 0);
        }

        private void quickSortDButton_Click(object sender, EventArgs e)
        {
            int[] arr = StringToIntArray(bubbleSortInputTextBox.Text);
            QuickSort(arr, 0, arr.Length - 1);
            qprintArray(arr, 1);
        }
        private int[] data;
        private IList<IList<int>> digits = new List<IList<int>>();
        private int maxLength = 0;



        public void RadixSort(int[] arr, int flag)
        {
            data = new int[arr.Length];
            Array.Copy(arr, data, arr.Length);
            for (int i = 0; i < 10; i++)
                digits.Add(new List<int>());
            for (int i = 0; i < data.Length; i++)
                if (maxLength < data[i].ToString().Length)
                    maxLength = data[i].ToString().Length;
            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    int digit = (int)((data[j] % Math.Pow(10, i + 1)) / Math.Pow(10, i));
                    digits[digit].Add(data[j]);
                }

                int index = 0;
                for (int k = 0; k < digits.Count; k++)
                {
                    IList<int> selDigit = digits[k];

                    for (int l = 0; l < selDigit.Count; l++)
                        data[index++] = selDigit[l];
                }
                ClearDigits();
            }
            printSortedData(flag);
        }

        private void ClearDigits()
        {
            for (int k = 0; k < digits.Count; k++)
                digits[k].Clear();
        }

        public void printSortedData(int flag)
        {
            string temp = "";
            if (flag == 0)
            {
                for (int i = 0; i < data.Length - 1; i++)
                    temp += data[i] + ",";
                temp += data[data.Length - 1];
            }
            else
            {
                for (int i = data.Length - 1; i > 0; i--)
                    temp += data[i] + ",";
                temp += data[0];
            }
            bubbleSortOutputTextBox.Text = temp;
        }
        private void radixSortAButton_Click(object sender, EventArgs e)
        {
            RadixSort(StringToIntArray(bubbleSortInputTextBox.Text), 0);
        }
        private void radixSortDButton_Click(object sender, EventArgs e)
        {
            RadixSort(StringToIntArray(bubbleSortInputTextBox.Text), 1);
        }
    }
}
