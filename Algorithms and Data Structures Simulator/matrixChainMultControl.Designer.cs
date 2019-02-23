namespace Project1
{
    partial class matrixChainMultControl
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
            this.matrixLabel = new System.Windows.Forms.Label();
            this.noOfMultLabel = new System.Windows.Forms.Label();
            this.noOfMultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matrixTextBox = new System.Windows.Forms.TextBox();
            this.matrixChainMultPictureBox = new System.Windows.Forms.PictureBox();
            this.matrixChainMultButton = new System.Windows.Forms.Button();
            this.DimMatrixLabel = new System.Windows.Forms.Label();
            this.DimMatrixTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixChainMultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixLabel
            // 
            this.matrixLabel.AutoSize = true;
            this.matrixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixLabel.ForeColor = System.Drawing.Color.Silver;
            this.matrixLabel.Location = new System.Drawing.Point(22, 45);
            this.matrixLabel.Name = "matrixLabel";
            this.matrixLabel.Size = new System.Drawing.Size(71, 25);
            this.matrixLabel.TabIndex = 63;
            this.matrixLabel.Text = "Matrix";
            // 
            // noOfMultLabel
            // 
            this.noOfMultLabel.AutoSize = true;
            this.noOfMultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfMultLabel.ForeColor = System.Drawing.Color.Silver;
            this.noOfMultLabel.Location = new System.Drawing.Point(22, 79);
            this.noOfMultLabel.Name = "noOfMultLabel";
            this.noOfMultLabel.Size = new System.Drawing.Size(212, 25);
            this.noOfMultLabel.TabIndex = 64;
            this.noOfMultLabel.Text = "No. of Multiplications";
            this.noOfMultLabel.Click += new System.EventHandler(this.noOfMultLabel_Click);
            // 
            // noOfMultTextBox
            // 
            this.noOfMultTextBox.Location = new System.Drawing.Point(268, 79);
            this.noOfMultTextBox.Name = "noOfMultTextBox";
            this.noOfMultTextBox.ReadOnly = true;
            this.noOfMultTextBox.Size = new System.Drawing.Size(259, 31);
            this.noOfMultTextBox.TabIndex = 59;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matrixTextBox);
            this.groupBox1.Controls.Add(this.matrixLabel);
            this.groupBox1.Controls.Add(this.noOfMultLabel);
            this.groupBox1.Controls.Add(this.noOfMultTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(43, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 124);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optimal Solution";
            // 
            // matrixTextBox
            // 
            this.matrixTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixTextBox.Location = new System.Drawing.Point(268, 45);
            this.matrixTextBox.Name = "matrixTextBox";
            this.matrixTextBox.ReadOnly = true;
            this.matrixTextBox.Size = new System.Drawing.Size(259, 21);
            this.matrixTextBox.TabIndex = 65;
            // 
            // matrixChainMultPictureBox
            // 
            this.matrixChainMultPictureBox.Image = global::Project1.Properties.Resources.appbar_arrow_left;
            this.matrixChainMultPictureBox.Location = new System.Drawing.Point(0, 0);
            this.matrixChainMultPictureBox.Name = "matrixChainMultPictureBox";
            this.matrixChainMultPictureBox.Size = new System.Drawing.Size(34, 32);
            this.matrixChainMultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.matrixChainMultPictureBox.TabIndex = 73;
            this.matrixChainMultPictureBox.TabStop = false;
            this.matrixChainMultPictureBox.Visible = false;
            this.matrixChainMultPictureBox.Click += new System.EventHandler(this.matrixChainMultPictureBox_Click);
            // 
            // matrixChainMultButton
            // 
            this.matrixChainMultButton.Location = new System.Drawing.Point(282, 391);
            this.matrixChainMultButton.Name = "matrixChainMultButton";
            this.matrixChainMultButton.Size = new System.Drawing.Size(75, 30);
            this.matrixChainMultButton.TabIndex = 72;
            this.matrixChainMultButton.Text = "Calculate";
            this.matrixChainMultButton.UseVisualStyleBackColor = true;
            this.matrixChainMultButton.Click += new System.EventHandler(this.matrixChainMultButton_Click);
            // 
            // DimMatrixLabel
            // 
            this.DimMatrixLabel.AutoSize = true;
            this.DimMatrixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DimMatrixLabel.ForeColor = System.Drawing.Color.Silver;
            this.DimMatrixLabel.Location = new System.Drawing.Point(65, 119);
            this.DimMatrixLabel.Name = "DimMatrixLabel";
            this.DimMatrixLabel.Size = new System.Drawing.Size(202, 25);
            this.DimMatrixLabel.TabIndex = 77;
            this.DimMatrixLabel.Text = "Dimension of Matrix";
            // 
            // DimMatrixTextBox
            // 
            this.DimMatrixTextBox.Location = new System.Drawing.Point(311, 119);
            this.DimMatrixTextBox.Name = "DimMatrixTextBox";
            this.DimMatrixTextBox.Size = new System.Drawing.Size(259, 20);
            this.DimMatrixTextBox.TabIndex = 69;
            // 
            // matrixChainMultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(666, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matrixChainMultPictureBox);
            this.Controls.Add(this.matrixChainMultButton);
            this.Controls.Add(this.DimMatrixLabel);
            this.Controls.Add(this.DimMatrixTextBox);
            this.Location = new System.Drawing.Point(442, 114);
            this.Name = "matrixChainMultForm";
            this.Text = "Matrix Chain Multiplication";
            this.Load += new System.EventHandler(this.matrixChainMultForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matrixLabel;
        private System.Windows.Forms.Label noOfMultLabel;
        private System.Windows.Forms.TextBox noOfMultTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox matrixTextBox;
        private System.Windows.Forms.PictureBox matrixChainMultPictureBox;
        private System.Windows.Forms.Button matrixChainMultButton;
        private System.Windows.Forms.Label DimMatrixLabel;
        private System.Windows.Forms.TextBox DimMatrixTextBox;
    }
}
