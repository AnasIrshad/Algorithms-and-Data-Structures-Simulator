namespace Project1
{
    partial class knapsackControl
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
            this.weightInputLabel = new System.Windows.Forms.Label();
            this.valueInputLabel = new System.Windows.Forms.Label();
            this.knapsackButton = new System.Windows.Forms.Button();
            this.valueInputTextBox = new System.Windows.Forms.TextBox();
            this.weightInputTextBox = new System.Windows.Forms.TextBox();
            this.WLabel = new System.Windows.Forms.Label();
            this.WTextBox = new System.Windows.Forms.TextBox();
            this.weightOutputTextBox = new System.Windows.Forms.TextBox();
            this.valueOutputTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemOutputTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.knapsackPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knapsackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // weightInputLabel
            // 
            this.weightInputLabel.AutoSize = true;
            this.weightInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightInputLabel.ForeColor = System.Drawing.Color.Silver;
            this.weightInputLabel.Location = new System.Drawing.Point(95, 154);
            this.weightInputLabel.Name = "weightInputLabel";
            this.weightInputLabel.Size = new System.Drawing.Size(79, 25);
            this.weightInputLabel.TabIndex = 62;
            this.weightInputLabel.Text = "Weight";
            // 
            // valueInputLabel
            // 
            this.valueInputLabel.AutoSize = true;
            this.valueInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueInputLabel.ForeColor = System.Drawing.Color.Silver;
            this.valueInputLabel.Location = new System.Drawing.Point(95, 114);
            this.valueInputLabel.Name = "valueInputLabel";
            this.valueInputLabel.Size = new System.Drawing.Size(67, 25);
            this.valueInputLabel.TabIndex = 61;
            this.valueInputLabel.Text = "Value";
            // 
            // knapsackButton
            // 
            this.knapsackButton.Location = new System.Drawing.Point(288, 414);
            this.knapsackButton.Name = "knapsackButton";
            this.knapsackButton.Size = new System.Drawing.Size(75, 27);
            this.knapsackButton.TabIndex = 3;
            this.knapsackButton.Text = "Calculate";
            this.knapsackButton.UseVisualStyleBackColor = true;
            this.knapsackButton.Click += new System.EventHandler(this.knapsackButton_Click);
            // 
            // valueInputTextBox
            // 
            this.valueInputTextBox.Location = new System.Drawing.Point(357, 117);
            this.valueInputTextBox.Name = "valueInputTextBox";
            this.valueInputTextBox.Size = new System.Drawing.Size(186, 20);
            this.valueInputTextBox.TabIndex = 1;
            // 
            // weightInputTextBox
            // 
            this.weightInputTextBox.Location = new System.Drawing.Point(357, 157);
            this.weightInputTextBox.Name = "weightInputTextBox";
            this.weightInputTextBox.Size = new System.Drawing.Size(186, 20);
            this.weightInputTextBox.TabIndex = 2;
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLabel.ForeColor = System.Drawing.Color.Silver;
            this.WLabel.Location = new System.Drawing.Point(95, 74);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(234, 25);
            this.WLabel.TabIndex = 68;
            this.WLabel.Text = "Maximum Capacity (W)";
            // 
            // WTextBox
            // 
            this.WTextBox.Location = new System.Drawing.Point(357, 77);
            this.WTextBox.Name = "WTextBox";
            this.WTextBox.Size = new System.Drawing.Size(186, 20);
            this.WTextBox.TabIndex = 0;
            // 
            // weightOutputTextBox
            // 
            this.weightOutputTextBox.Location = new System.Drawing.Point(244, 113);
            this.weightOutputTextBox.Name = "weightOutputTextBox";
            this.weightOutputTextBox.ReadOnly = true;
            this.weightOutputTextBox.Size = new System.Drawing.Size(186, 31);
            this.weightOutputTextBox.TabIndex = 60;
            // 
            // valueOutputTextBox
            // 
            this.valueOutputTextBox.Location = new System.Drawing.Point(244, 76);
            this.valueOutputTextBox.Name = "valueOutputTextBox";
            this.valueOutputTextBox.ReadOnly = true;
            this.valueOutputTextBox.Size = new System.Drawing.Size(186, 31);
            this.valueOutputTextBox.TabIndex = 59;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.Color.Silver;
            this.valueLabel.Location = new System.Drawing.Point(12, 85);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(67, 25);
            this.valueLabel.TabIndex = 64;
            this.valueLabel.Text = "Value";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.ForeColor = System.Drawing.Color.Silver;
            this.itemLabel.Location = new System.Drawing.Point(12, 45);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(52, 25);
            this.itemLabel.TabIndex = 63;
            this.itemLabel.Text = "Item";
            // 
            // itemOutputTextBox
            // 
            this.itemOutputTextBox.Location = new System.Drawing.Point(244, 39);
            this.itemOutputTextBox.Name = "itemOutputTextBox";
            this.itemOutputTextBox.ReadOnly = true;
            this.itemOutputTextBox.Size = new System.Drawing.Size(186, 31);
            this.itemOutputTextBox.TabIndex = 65;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.ForeColor = System.Drawing.Color.Silver;
            this.weightLabel.Location = new System.Drawing.Point(12, 125);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(79, 25);
            this.weightLabel.TabIndex = 66;
            this.weightLabel.Text = "Weight";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weightLabel);
            this.groupBox1.Controls.Add(this.itemOutputTextBox);
            this.groupBox1.Controls.Add(this.itemLabel);
            this.groupBox1.Controls.Add(this.valueLabel);
            this.groupBox1.Controls.Add(this.valueOutputTextBox);
            this.groupBox1.Controls.Add(this.weightOutputTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(100, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 163);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optimal Solution";
            // 
            // knapsackPictureBox
            // 
            this.knapsackPictureBox.Image = global::Project1.Properties.Resources.appbar_arrow_left;
            this.knapsackPictureBox.Location = new System.Drawing.Point(0, 0);
            this.knapsackPictureBox.Name = "knapsackPictureBox";
            this.knapsackPictureBox.Size = new System.Drawing.Size(34, 32);
            this.knapsackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.knapsackPictureBox.TabIndex = 58;
            this.knapsackPictureBox.TabStop = false;
            this.knapsackPictureBox.Visible = false;
            this.knapsackPictureBox.Click += new System.EventHandler(this.knapsackPictureBox_Click);
            // 
            // knapsackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.WTextBox);
            this.Controls.Add(this.weightInputTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.weightInputLabel);
            this.Controls.Add(this.valueInputLabel);
            this.Controls.Add(this.knapsackPictureBox);
            this.Controls.Add(this.knapsackButton);
            this.Controls.Add(this.valueInputTextBox);
            this.Location = new System.Drawing.Point(442, 114);
            this.Name = "knapsackControl";
            this.Size = new System.Drawing.Size(666, 500);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knapsackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label weightInputLabel;
        private System.Windows.Forms.Label valueInputLabel;
        private System.Windows.Forms.PictureBox knapsackPictureBox;
        private System.Windows.Forms.Button knapsackButton;
        private System.Windows.Forms.TextBox valueInputTextBox;
        private System.Windows.Forms.TextBox weightInputTextBox;
        private System.Windows.Forms.Label WLabel;
        private System.Windows.Forms.TextBox WTextBox;
        private System.Windows.Forms.TextBox weightOutputTextBox;
        private System.Windows.Forms.TextBox valueOutputTextBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox itemOutputTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
