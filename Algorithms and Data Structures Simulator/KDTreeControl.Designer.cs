namespace Project1
{
    partial class KDTreeControl
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
            this.KDTreeButton = new System.Windows.Forms.Button();
            this.postOrderLabel = new System.Windows.Forms.Label();
            this.inOrderLabel = new System.Windows.Forms.Label();
            this.preOrderLabel = new System.Windows.Forms.Label();
            this.inputXLabel = new System.Windows.Forms.Label();
            this.KDTreePostOutputTextBox = new System.Windows.Forms.TextBox();
            this.KDTreeInOutputTextBox = new System.Windows.Forms.TextBox();
            this.KDTreePreOutputTextBox = new System.Windows.Forms.TextBox();
            this.KDTreeInputXTextBox = new System.Windows.Forms.TextBox();
            this.inputYLabel = new System.Windows.Forms.Label();
            this.KDTreeInputYTextBox = new System.Windows.Forms.TextBox();
            this.KDTreePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KDTreePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // KDTreeButton
            // 
            this.KDTreeButton.Location = new System.Drawing.Point(293, 404);
            this.KDTreeButton.Name = "KDTreeButton";
            this.KDTreeButton.Size = new System.Drawing.Size(88, 25);
            this.KDTreeButton.TabIndex = 0;
            this.KDTreeButton.Text = "Traverse";
            this.KDTreeButton.UseVisualStyleBackColor = true;
            this.KDTreeButton.Click += new System.EventHandler(this.KDTreeButton_Click);
            // 
            // postOrderLabel
            // 
            this.postOrderLabel.AutoSize = true;
            this.postOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postOrderLabel.ForeColor = System.Drawing.Color.Silver;
            this.postOrderLabel.Location = new System.Drawing.Point(63, 312);
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
            this.inOrderLabel.Location = new System.Drawing.Point(63, 256);
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
            this.preOrderLabel.Location = new System.Drawing.Point(63, 200);
            this.preOrderLabel.Name = "preOrderLabel";
            this.preOrderLabel.Size = new System.Drawing.Size(202, 25);
            this.preOrderLabel.TabIndex = 52;
            this.preOrderLabel.Text = "Pre-Order Traversal";
            // 
            // inputXLabel
            // 
            this.inputXLabel.AutoSize = true;
            this.inputXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputXLabel.ForeColor = System.Drawing.Color.Silver;
            this.inputXLabel.Location = new System.Drawing.Point(63, 88);
            this.inputXLabel.Name = "inputXLabel";
            this.inputXLabel.Size = new System.Drawing.Size(90, 25);
            this.inputXLabel.TabIndex = 51;
            this.inputXLabel.Text = "Input (x)";
            // 
            // KDTreePostOutputTextBox
            // 
            this.KDTreePostOutputTextBox.Location = new System.Drawing.Point(309, 312);
            this.KDTreePostOutputTextBox.Name = "KDTreePostOutputTextBox";
            this.KDTreePostOutputTextBox.ReadOnly = true;
            this.KDTreePostOutputTextBox.Size = new System.Drawing.Size(302, 20);
            this.KDTreePostOutputTextBox.TabIndex = 50;
            // 
            // KDTreeInOutputTextBox
            // 
            this.KDTreeInOutputTextBox.Location = new System.Drawing.Point(309, 256);
            this.KDTreeInOutputTextBox.Name = "KDTreeInOutputTextBox";
            this.KDTreeInOutputTextBox.ReadOnly = true;
            this.KDTreeInOutputTextBox.Size = new System.Drawing.Size(302, 20);
            this.KDTreeInOutputTextBox.TabIndex = 49;
            // 
            // KDTreePreOutputTextBox
            // 
            this.KDTreePreOutputTextBox.Location = new System.Drawing.Point(309, 200);
            this.KDTreePreOutputTextBox.Name = "KDTreePreOutputTextBox";
            this.KDTreePreOutputTextBox.ReadOnly = true;
            this.KDTreePreOutputTextBox.Size = new System.Drawing.Size(302, 20);
            this.KDTreePreOutputTextBox.TabIndex = 46;
            // 
            // KDTreeInputXTextBox
            // 
            this.KDTreeInputXTextBox.Location = new System.Drawing.Point(309, 93);
            this.KDTreeInputXTextBox.Name = "KDTreeInputXTextBox";
            this.KDTreeInputXTextBox.Size = new System.Drawing.Size(302, 20);
            this.KDTreeInputXTextBox.TabIndex = 45;
            // 
            // inputYLabel
            // 
            this.inputYLabel.AutoSize = true;
            this.inputYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputYLabel.ForeColor = System.Drawing.Color.Silver;
            this.inputYLabel.Location = new System.Drawing.Point(63, 144);
            this.inputYLabel.Name = "inputYLabel";
            this.inputYLabel.Size = new System.Drawing.Size(90, 25);
            this.inputYLabel.TabIndex = 56;
            this.inputYLabel.Text = "Input (y)";
            // 
            // KDTreeInputYTextBox
            // 
            this.KDTreeInputYTextBox.Location = new System.Drawing.Point(309, 144);
            this.KDTreeInputYTextBox.Name = "KDTreeInputYTextBox";
            this.KDTreeInputYTextBox.Size = new System.Drawing.Size(302, 20);
            this.KDTreeInputYTextBox.TabIndex = 55;
            // 
            // KDTreePictureBox
            // 
            this.KDTreePictureBox.Image = global::Project1.Properties.Resources.appbar_arrow_left;
            this.KDTreePictureBox.Location = new System.Drawing.Point(0, 0);
            this.KDTreePictureBox.Name = "KDTreePictureBox";
            this.KDTreePictureBox.Size = new System.Drawing.Size(34, 32);
            this.KDTreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KDTreePictureBox.TabIndex = 48;
            this.KDTreePictureBox.TabStop = false;
            this.KDTreePictureBox.Visible = false;
            this.KDTreePictureBox.Click += new System.EventHandler(this.KDTreePictureBox_Click);
            // 
            // KDTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(666, 500);
            this.Controls.Add(this.inputYLabel);
            this.Controls.Add(this.KDTreeInputYTextBox);
            this.Controls.Add(this.postOrderLabel);
            this.Controls.Add(this.inOrderLabel);
            this.Controls.Add(this.preOrderLabel);
            this.Controls.Add(this.inputXLabel);
            this.Controls.Add(this.KDTreePostOutputTextBox);
            this.Controls.Add(this.KDTreeInOutputTextBox);
            this.Controls.Add(this.KDTreePictureBox);
            this.Controls.Add(this.KDTreePreOutputTextBox);
            this.Controls.Add(this.KDTreeInputXTextBox);
            this.Controls.Add(this.KDTreeButton);
            this.Location = new System.Drawing.Point(442, 114);
            this.Name = "KDTreeForm";
            this.Text = "KD Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KDTreeButton;
        private System.Windows.Forms.Label postOrderLabel;
        private System.Windows.Forms.Label inOrderLabel;
        private System.Windows.Forms.Label preOrderLabel;
        private System.Windows.Forms.Label inputXLabel;
        private System.Windows.Forms.TextBox KDTreePostOutputTextBox;
        private System.Windows.Forms.TextBox KDTreeInOutputTextBox;
        private System.Windows.Forms.PictureBox KDTreePictureBox;
        private System.Windows.Forms.TextBox KDTreePreOutputTextBox;
        private System.Windows.Forms.TextBox KDTreeInputXTextBox;
        private System.Windows.Forms.Label inputYLabel;
        private System.Windows.Forms.TextBox KDTreeInputYTextBox;
    }
}
