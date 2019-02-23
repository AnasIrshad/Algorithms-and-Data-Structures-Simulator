namespace Project1
{
    partial class RedBlackTreeForm
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
            this.postOrderLabel = new System.Windows.Forms.Label();
            this.inOrderLabel = new System.Windows.Forms.Label();
            this.preOrderLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.RedBlackTreePostOutputTextBox = new System.Windows.Forms.TextBox();
            this.RedBlackTreeInOutputTextBox = new System.Windows.Forms.TextBox();
            this.RedBlackTreeButton = new System.Windows.Forms.Button();
            this.RedBlackTreePreOutputTextBox = new System.Windows.Forms.TextBox();
            this.RedBlackTreeInputTextBox = new System.Windows.Forms.TextBox();
            this.RedBlackTreePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedBlackTreePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // postOrderLabel
            // 
            this.postOrderLabel.AutoSize = true;
            this.postOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postOrderLabel.ForeColor = System.Drawing.Color.Silver;
            this.postOrderLabel.Location = new System.Drawing.Point(82, 288);
            this.postOrderLabel.Name = "postOrderLabel";
            this.postOrderLabel.Size = new System.Drawing.Size(211, 25);
            this.postOrderLabel.TabIndex = 54;
            this.postOrderLabel.Text = "Post Order Traversal";
            // 
            // inOrderLabel
            // 
            this.inOrderLabel.AutoSize = true;
            this.inOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inOrderLabel.ForeColor = System.Drawing.Color.Silver;
            this.inOrderLabel.Location = new System.Drawing.Point(82, 243);
            this.inOrderLabel.Name = "inOrderLabel";
            this.inOrderLabel.Size = new System.Drawing.Size(185, 25);
            this.inOrderLabel.TabIndex = 53;
            this.inOrderLabel.Text = "In Order Traversal";
            // 
            // preOrderLabel
            // 
            this.preOrderLabel.AutoSize = true;
            this.preOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preOrderLabel.ForeColor = System.Drawing.Color.Silver;
            this.preOrderLabel.Location = new System.Drawing.Point(82, 198);
            this.preOrderLabel.Name = "preOrderLabel";
            this.preOrderLabel.Size = new System.Drawing.Size(202, 25);
            this.preOrderLabel.TabIndex = 52;
            this.preOrderLabel.Text = "Pre-Order Traversal";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.Silver;
            this.inputLabel.Location = new System.Drawing.Point(82, 147);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(59, 25);
            this.inputLabel.TabIndex = 51;
            this.inputLabel.Text = "Input";
            // 
            // RedBlackTreePostOutputTextBox
            // 
            this.RedBlackTreePostOutputTextBox.Location = new System.Drawing.Point(364, 288);
            this.RedBlackTreePostOutputTextBox.Name = "RedBlackTreePostOutputTextBox";
            this.RedBlackTreePostOutputTextBox.ReadOnly = true;
            this.RedBlackTreePostOutputTextBox.Size = new System.Drawing.Size(186, 20);
            this.RedBlackTreePostOutputTextBox.TabIndex = 50;
            // 
            // RedBlackTreeInOutputTextBox
            // 
            this.RedBlackTreeInOutputTextBox.Location = new System.Drawing.Point(364, 243);
            this.RedBlackTreeInOutputTextBox.Name = "RedBlackTreeInOutputTextBox";
            this.RedBlackTreeInOutputTextBox.ReadOnly = true;
            this.RedBlackTreeInOutputTextBox.Size = new System.Drawing.Size(186, 20);
            this.RedBlackTreeInOutputTextBox.TabIndex = 49;
            // 
            // RedBlackTreeButton
            // 
            this.RedBlackTreeButton.Location = new System.Drawing.Point(282, 379);
            this.RedBlackTreeButton.Name = "RedBlackTreeButton";
            this.RedBlackTreeButton.Size = new System.Drawing.Size(75, 26);
            this.RedBlackTreeButton.TabIndex = 2;
            this.RedBlackTreeButton.Text = "Traverse";
            this.RedBlackTreeButton.UseVisualStyleBackColor = true;
            this.RedBlackTreeButton.Click += new System.EventHandler(this.RedBlackTreeButton_Click);
            // 
            // RedBlackTreePreOutputTextBox
            // 
            this.RedBlackTreePreOutputTextBox.Location = new System.Drawing.Point(364, 198);
            this.RedBlackTreePreOutputTextBox.Name = "RedBlackTreePreOutputTextBox";
            this.RedBlackTreePreOutputTextBox.ReadOnly = true;
            this.RedBlackTreePreOutputTextBox.Size = new System.Drawing.Size(186, 20);
            this.RedBlackTreePreOutputTextBox.TabIndex = 46;
            // 
            // RedBlackTreeInputTextBox
            // 
            this.RedBlackTreeInputTextBox.Location = new System.Drawing.Point(364, 147);
            this.RedBlackTreeInputTextBox.Name = "RedBlackTreeInputTextBox";
            this.RedBlackTreeInputTextBox.Size = new System.Drawing.Size(186, 20);
            this.RedBlackTreeInputTextBox.TabIndex = 1;
            // 
            // RedBlackTreePictureBox
            // 
            this.RedBlackTreePictureBox.Image = global::Project1.Properties.Resources.appbar_arrow_left;
            this.RedBlackTreePictureBox.Location = new System.Drawing.Point(0, -1);
            this.RedBlackTreePictureBox.Name = "RedBlackTreePictureBox";
            this.RedBlackTreePictureBox.Size = new System.Drawing.Size(34, 32);
            this.RedBlackTreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedBlackTreePictureBox.TabIndex = 48;
            this.RedBlackTreePictureBox.TabStop = false;
            this.RedBlackTreePictureBox.Visible = false;
            this.RedBlackTreePictureBox.Click += new System.EventHandler(this.RedBlackTreePictureBox_Click);
            // 
            // RedBlackTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(666, 500);
            this.Controls.Add(this.RedBlackTreePictureBox);
            this.Controls.Add(this.postOrderLabel);
            this.Controls.Add(this.inOrderLabel);
            this.Controls.Add(this.preOrderLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.RedBlackTreePostOutputTextBox);
            this.Controls.Add(this.RedBlackTreeInOutputTextBox);
            this.Controls.Add(this.RedBlackTreeButton);
            this.Controls.Add(this.RedBlackTreePreOutputTextBox);
            this.Controls.Add(this.RedBlackTreeInputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(442, 114);
            this.Name = "RedBlackTreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Red Black Tree";
            this.Deactivate += new System.EventHandler(this.RedBlackTreePictureBox_Click);
            ((System.ComponentModel.ISupportInitialize)(this.RedBlackTreePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label postOrderLabel;
        private System.Windows.Forms.Label inOrderLabel;
        private System.Windows.Forms.Label preOrderLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox RedBlackTreePostOutputTextBox;
        private System.Windows.Forms.TextBox RedBlackTreeInOutputTextBox;
        private System.Windows.Forms.PictureBox RedBlackTreePictureBox;
        private System.Windows.Forms.Button RedBlackTreeButton;
        private System.Windows.Forms.TextBox RedBlackTreePreOutputTextBox;
        private System.Windows.Forms.TextBox RedBlackTreeInputTextBox;
    }
}