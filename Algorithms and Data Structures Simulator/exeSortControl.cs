using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project1
{
    public partial class exeSortControl : UserControl
    {
        public exeSortControl()
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

        private int[] sort(int[] arr, int first, int last)
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
            sortOutput.Text = toChar;
            return toChar;
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
           // if (heapButton.Checked)
           // {
                int[] arrayToSort = StringToIntArray(sortInput.Text);
                int[] sortedArray = sort(arrayToSort, 0, arrayToSort.Length - 1);
                showArray(arrayToSort, 0);
                
            //}
        }

        private void accessFile()
        {
            if (File.Exists("sortNumbers.txt"))
            {
                string content = File.ReadAllText("sortNumbers.txt");
                int[] arrayToSort = StringToIntArray(content);
                int[] sortedArray = sort(arrayToSort, 0, arrayToSort.Length - 1);
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
        private void uploadButton_Click(object sender, EventArgs e)
        {
            accessFile();
        }
    }
}
