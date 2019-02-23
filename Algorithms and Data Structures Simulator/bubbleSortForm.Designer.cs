namespace Project1
{
    partial class bubbleSortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bubbleSortInputTextBox = new System.Windows.Forms.TextBox();
            this.bubbleSortOutputTextBox = new System.Windows.Forms.TextBox();
            this.bubbleSortAButton = new System.Windows.Forms.Button();
            this.bubbleSortDButton = new System.Windows.Forms.Button();
            this.bubbleSortFileButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countingButton = new System.Windows.Forms.RadioButton();
            this.bucketButton = new System.Windows.Forms.RadioButton();
            this.radixButton = new System.Windows.Forms.RadioButton();
            this.mergeButton = new System.Windows.Forms.RadioButton();
            this.heapButton = new System.Windows.Forms.RadioButton();
            this.quickButton = new System.Windows.Forms.RadioButton();
            this.bubbleButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bubbleSortInputTextBox
            // 
            this.bubbleSortInputTextBox.Location = new System.Drawing.Point(225, 87);
            this.bubbleSortInputTextBox.Name = "bubbleSortInputTextBox";
            this.bubbleSortInputTextBox.Size = new System.Drawing.Size(186, 20);
            this.bubbleSortInputTextBox.TabIndex = 0;
            this.bubbleSortInputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bubbleSortOutputTextBox
            // 
            this.bubbleSortOutputTextBox.Location = new System.Drawing.Point(225, 136);
            this.bubbleSortOutputTextBox.Name = "bubbleSortOutputTextBox";
            this.bubbleSortOutputTextBox.ReadOnly = true;
            this.bubbleSortOutputTextBox.Size = new System.Drawing.Size(186, 20);
            this.bubbleSortOutputTextBox.TabIndex = 1;
            // 
            // bubbleSortAButton
            // 
            this.bubbleSortAButton.Location = new System.Drawing.Point(209, 196);
            this.bubbleSortAButton.Name = "bubbleSortAButton";
            this.bubbleSortAButton.Size = new System.Drawing.Size(91, 22);
            this.bubbleSortAButton.TabIndex = 2;
            this.bubbleSortAButton.Text = "Ascending Sort";
            this.bubbleSortAButton.UseVisualStyleBackColor = true;
            this.bubbleSortAButton.Click += new System.EventHandler(this.bubbleSortAButton_Click);
            // 
            // bubbleSortDButton
            // 
            this.bubbleSortDButton.Location = new System.Drawing.Point(355, 196);
            this.bubbleSortDButton.Name = "bubbleSortDButton";
            this.bubbleSortDButton.Size = new System.Drawing.Size(95, 22);
            this.bubbleSortDButton.TabIndex = 3;
            this.bubbleSortDButton.Text = "Descending Sort";
            this.bubbleSortDButton.UseVisualStyleBackColor = true;
            this.bubbleSortDButton.Click += new System.EventHandler(this.bubbleSortDButton_Click);
            // 
            // bubbleSortFileButton
            // 
            this.bubbleSortFileButton.Location = new System.Drawing.Point(225, 402);
            this.bubbleSortFileButton.Name = "bubbleSortFileButton";
            this.bubbleSortFileButton.Size = new System.Drawing.Size(186, 39);
            this.bubbleSortFileButton.TabIndex = 10;
            this.bubbleSortFileButton.Text = "File Upload";
            this.bubbleSortFileButton.UseVisualStyleBackColor = true;
            this.bubbleSortFileButton.Click += new System.EventHandler(this.bubbleSortFileButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project1.Properties.Resources.appbar_arrow_left;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // countingButton
            // 
            this.countingButton.AutoSize = true;
            this.countingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countingButton.ForeColor = System.Drawing.Color.Silver;
            this.countingButton.Location = new System.Drawing.Point(272, 341);
            this.countingButton.Name = "countingButton";
            this.countingButton.Size = new System.Drawing.Size(118, 20);
            this.countingButton.TabIndex = 17;
            this.countingButton.Text = "Counting Sort";
            this.countingButton.UseVisualStyleBackColor = true;
            // 
            // bucketButton
            // 
            this.bucketButton.AutoSize = true;
            this.bucketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucketButton.ForeColor = System.Drawing.Color.Silver;
            this.bucketButton.Location = new System.Drawing.Point(121, 341);
            this.bucketButton.Name = "bucketButton";
            this.bucketButton.Size = new System.Drawing.Size(105, 20);
            this.bucketButton.TabIndex = 16;
            this.bucketButton.Text = "Bucket Sort";
            this.bucketButton.UseVisualStyleBackColor = true;
            // 
            // radixButton
            // 
            this.radixButton.AutoSize = true;
            this.radixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radixButton.ForeColor = System.Drawing.Color.Silver;
            this.radixButton.Location = new System.Drawing.Point(506, 284);
            this.radixButton.Name = "radixButton";
            this.radixButton.Size = new System.Drawing.Size(98, 20);
            this.radixButton.TabIndex = 15;
            this.radixButton.Text = "Radix Sort";
            this.radixButton.UseVisualStyleBackColor = true;
            // 
            // mergeButton
            // 
            this.mergeButton.AutoSize = true;
            this.mergeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeButton.ForeColor = System.Drawing.Color.Silver;
            this.mergeButton.Location = new System.Drawing.Point(355, 284);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(102, 20);
            this.mergeButton.TabIndex = 14;
            this.mergeButton.Text = "Merge Sort";
            this.mergeButton.UseVisualStyleBackColor = true;
            // 
            // heapButton
            // 
            this.heapButton.AutoSize = true;
            this.heapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heapButton.ForeColor = System.Drawing.Color.Silver;
            this.heapButton.Location = new System.Drawing.Point(204, 284);
            this.heapButton.Name = "heapButton";
            this.heapButton.Size = new System.Drawing.Size(96, 20);
            this.heapButton.TabIndex = 13;
            this.heapButton.Text = "Heap Sort";
            this.heapButton.UseVisualStyleBackColor = true;
            // 
            // quickButton
            // 
            this.quickButton.AutoSize = true;
            this.quickButton.Checked = true;
            this.quickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickButton.ForeColor = System.Drawing.Color.Silver;
            this.quickButton.Location = new System.Drawing.Point(53, 284);
            this.quickButton.Name = "quickButton";
            this.quickButton.Size = new System.Drawing.Size(97, 20);
            this.quickButton.TabIndex = 12;
            this.quickButton.TabStop = true;
            this.quickButton.Text = "Quick Sort";
            this.quickButton.UseVisualStyleBackColor = true;
            // 
            // bubbleButton
            // 
            this.bubbleButton.AutoSize = true;
            this.bubbleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleButton.ForeColor = System.Drawing.Color.Silver;
            this.bubbleButton.Location = new System.Drawing.Point(436, 341);
            this.bubbleButton.Name = "bubbleButton";
            this.bubbleButton.Size = new System.Drawing.Size(107, 20);
            this.bubbleButton.TabIndex = 18;
            this.bubbleButton.Text = "Bubble Sort";
            this.bubbleButton.UseVisualStyleBackColor = true;
            // 
            // bubbleSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(666, 500);
            this.Controls.Add(this.bubbleButton);
            this.Controls.Add(this.countingButton);
            this.Controls.Add(this.bucketButton);
            this.Controls.Add(this.radixButton);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.heapButton);
            this.Controls.Add(this.quickButton);
            this.Controls.Add(this.bubbleSortFileButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bubbleSortDButton);
            this.Controls.Add(this.bubbleSortAButton);
            this.Controls.Add(this.bubbleSortOutputTextBox);
            this.Controls.Add(this.bubbleSortInputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(442, 114);
            this.MaximizeBox = false;
            this.Name = "bubbleSortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sort";
            this.Deactivate += new System.EventHandler(this.pictureBox1_Click);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bubbleSortForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bubbleSortInputTextBox;
        private System.Windows.Forms.TextBox bubbleSortOutputTextBox;
        private System.Windows.Forms.Button bubbleSortAButton;
        private System.Windows.Forms.Button bubbleSortDButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bubbleSortFileButton;
        private System.Windows.Forms.RadioButton countingButton;
        private System.Windows.Forms.RadioButton bucketButton;
        private System.Windows.Forms.RadioButton radixButton;
        private System.Windows.Forms.RadioButton mergeButton;
        private System.Windows.Forms.RadioButton heapButton;
        private System.Windows.Forms.RadioButton quickButton;
        private System.Windows.Forms.RadioButton bubbleButton;
    }
}