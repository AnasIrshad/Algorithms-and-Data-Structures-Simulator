namespace Project1
{
    partial class BinSearchTreeForm
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
            this.BinSearchTreeButton = new System.Windows.Forms.Button();
            this.BinSearchTreePreOutputTextBox = new System.Windows.Forms.TextBox();
            this.BinSearchTreeInputTextBox = new System.Windows.Forms.TextBox();
            this.BinSearchTreeInOutputTextBox = new System.Windows.Forms.TextBox();
            this.BinSearchTreePostOutputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.preOrderLabel = new System.Windows.Forms.Label();
            this.inOrderLabel = new System.Windows.Forms.Label();
            this.postOrderLabel = new System.Windows.Forms.Label();
            this.BinSearchTreePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BinSearchTreePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BinSearchTreeButton
            // 
            this.BinSearchTreeButton.Location = new System.Drawing.Point(267, 382);
            this.BinSearchTreeButton.Name = "BinSearchTreeButton";
            this.BinSearchTreeButton.Size = new System.Drawing.Size(112, 33);
            this.BinSearchTreeButton.TabIndex = 36;
            this.BinSearchTreeButton.Text = "Traverse";
            this.BinSearchTreeButton.UseVisualStyleBackColor = true;
            this.BinSearchTreeButton.Click += new System.EventHandler(this.BinSearchTreeButton_Click);
            // 
            // BinSearchTreePreOutputTextBox
            // 
            this.BinSearchTreePreOutputTextBox.Location = new System.Drawing.Point(378, 185);
            this.BinSearchTreePreOutputTextBox.Name = "BinSearchTreePreOutputTextBox";
            this.BinSearchTreePreOutputTextBox.ReadOnly = true;
            this.BinSearchTreePreOutputTextBox.Size = new System.Drawing.Size(186, 20);
            this.BinSearchTreePreOutputTextBox.TabIndex = 35;
            // 
            // BinSearchTreeInputTextBox
            // 
            this.BinSearchTreeInputTextBox.Location = new System.Drawing.Point(378, 131);
            this.BinSearchTreeInputTextBox.Name = "BinSearchTreeInputTextBox";
            this.BinSearchTreeInputTextBox.Size = new System.Drawing.Size(186, 20);
            this.BinSearchTreeInputTextBox.TabIndex = 34;
            // 
            // BinSearchTreeInOutputTextBox
            // 
            this.BinSearchTreeInOutputTextBox.Location = new System.Drawing.Point(378, 244);
            this.BinSearchTreeInOutputTextBox.Name = "BinSearchTreeInOutputTextBox";
            this.BinSearchTreeInOutputTextBox.ReadOnly = true;
            this.BinSearchTreeInOutputTextBox.Size = new System.Drawing.Size(186, 20);
            this.BinSearchTreeInOutputTextBox.TabIndex = 39;
            // 
            // BinSearchTreePostOutputTextBox
            // 
            this.BinSearchTreePostOutputTextBox.Location = new System.Drawing.Point(378, 304);
            this.BinSearchTreePostOutputTextBox.Name = "BinSearchTreePostOutputTextBox";
            this.BinSearchTreePostOutputTextBox.ReadOnly = true;
            this.BinSearchTreePostOutputTextBox.Size = new System.Drawing.Size(186, 20);
            this.BinSearchTreePostOutputTextBox.TabIndex = 40;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.Silver;
            this.inputLabel.Location = new System.Drawing.Point(53, 125);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(59, 25);
            this.inputLabel.TabIndex = 41;
            this.inputLabel.Text = "Input";
            // 
            // preOrderLabel
            // 
            this.preOrderLabel.AutoSize = true;
            this.preOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preOrderLabel.ForeColor = System.Drawing.Color.Silver;
            this.preOrderLabel.Location = new System.Drawing.Point(53, 185);
            this.preOrderLabel.Name = "preOrderLabel";
            this.preOrderLabel.Size = new System.Drawing.Size(202, 25);
            this.preOrderLabel.TabIndex = 42;
            this.preOrderLabel.Text = "Pre-Order Traversal";
            // 
            // inOrderLabel
            // 
            this.inOrderLabel.AutoSize = true;
            this.inOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inOrderLabel.ForeColor = System.Drawing.Color.Silver;
            this.inOrderLabel.Location = new System.Drawing.Point(53, 238);
            this.inOrderLabel.Name = "inOrderLabel";
            this.inOrderLabel.Size = new System.Drawing.Size(185, 25);
            this.inOrderLabel.TabIndex = 43;
            this.inOrderLabel.Text = "In Order Traversal";
            // 
            // postOrderLabel
            // 
            this.postOrderLabel.AutoSize = true;
            this.postOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postOrderLabel.ForeColor = System.Drawing.Color.Silver;
            this.postOrderLabel.Location = new System.Drawing.Point(53, 304);
            this.postOrderLabel.Name = "postOrderLabel";
            this.postOrderLabel.Size = new System.Drawing.Size(211, 25);
            this.postOrderLabel.TabIndex = 44;
            this.postOrderLabel.Text = "Post Order Traversal";
            // 
            // BinSearchTreePictureBox
            // 
            this.BinSearchTreePictureBox.Image = global::Project1.Properties.Resources.appbar_arrow_left;
            this.BinSearchTreePictureBox.Location = new System.Drawing.Point(0, -1);
            this.BinSearchTreePictureBox.Name = "BinSearchTreePictureBox";
            this.BinSearchTreePictureBox.Size = new System.Drawing.Size(34, 32);
            this.BinSearchTreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BinSearchTreePictureBox.TabIndex = 38;
            this.BinSearchTreePictureBox.TabStop = false;
            this.BinSearchTreePictureBox.Visible = false;
            this.BinSearchTreePictureBox.Click += new System.EventHandler(this.BinSearchTreePictureBox_Click);
            // 
            // BinSearchTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(666, 500);
            this.Controls.Add(this.postOrderLabel);
            this.Controls.Add(this.inOrderLabel);
            this.Controls.Add(this.preOrderLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.BinSearchTreePostOutputTextBox);
            this.Controls.Add(this.BinSearchTreeInOutputTextBox);
            this.Controls.Add(this.BinSearchTreePictureBox);
            this.Controls.Add(this.BinSearchTreeButton);
            this.Controls.Add(this.BinSearchTreePreOutputTextBox);
            this.Controls.Add(this.BinSearchTreeInputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(442, 114);
            this.MaximizeBox = false;
            this.Name = "BinSearchTreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Binary Search Tree";
            this.Deactivate += new System.EventHandler(this.BinSearchTreePictureBox_Click);
            ((System.ComponentModel.ISupportInitialize)(this.BinSearchTreePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BinSearchTreePictureBox;
        private System.Windows.Forms.Button BinSearchTreeButton;
        private System.Windows.Forms.TextBox BinSearchTreePreOutputTextBox;
        private System.Windows.Forms.TextBox BinSearchTreeInputTextBox;
        private System.Windows.Forms.TextBox BinSearchTreeInOutputTextBox;
        private System.Windows.Forms.TextBox BinSearchTreePostOutputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label preOrderLabel;
        private System.Windows.Forms.Label inOrderLabel;
        private System.Windows.Forms.Label postOrderLabel;
    }
}