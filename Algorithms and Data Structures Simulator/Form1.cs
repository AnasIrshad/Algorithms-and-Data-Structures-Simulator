using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Project1
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            try
            {
                base.Hide();
                Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppArgb);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(base.Location.X, base.Location.Y, 0, 0, base.Size, CopyPixelOperation.SourceCopy);
                bitmap.Save("spls.bin", ImageFormat.Png);
                this.BackgroundImage = bitmap;
                base.Show();
            }
            catch (Exception)
            {

            }
        }

        private void form1_Load(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }

        int step = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (step)
            {
                case 0:
                    this.Opacity = 1;
                    //timer1.Interval = 1000;
                    break;
                case 1:
                    lbl.Text = "Loading.";
                    break;
                case 2:
                    lbl.Text = "Loading..";
                    break;
                case 3:
                    lbl.Text = "Loading...";
                    break;
                case 4:
                    lbl.Text = "Loading.";
                    break;
                case 5:
                    lbl.Text = "Loading..";
                    break;
                case 6:
                    lbl.Text = "Loading...";
                    break;
                case 7:
                    lbl.Text = "Initializing Modules...100%";
                    break;
                case 8:
                    lbl.Text = "Initializing UI...100%";
                    break;
                case 9:
                    lbl.Text = "Initializing Plugins...100%";
                    break;
                case 10:
                    lbl.Text = "Sorting Algorithms...100%";
                    break;
                case 11:
                    lbl.Text = "Data Structures...100%";
                    break;
                case 12:
                    lbl.Text = "Trees...100%";
                    break;
                case 13:
                    lbl.Text = "Knap Sack...100%";
                    break;
                case 14:
                    lbl.Text = "Chain Multiplication...100%";
                    break;
                case 15:
                    //timer1.Stop();
                    this.Hide();
                    Form2 form2=new Form2();
                    form2.Show();
                    break;
            }
            this.Enabled = false;

            step++;
        }
    }
}
