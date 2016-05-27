namespace KleisnerAdam_Assignment1Exercise1
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.needList = new System.Windows.Forms.ListBox();
            this.haveList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.haveMoveButton = new System.Windows.Forms.Button();
            this.haveDeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.needRadioButton = new System.Windows.Forms.RadioButton();
            this.haveRadioButton = new System.Windows.Forms.RadioButton();
            this.needMoveButton = new System.Windows.Forms.Button();
            this.needDeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "GroceryList";
            // 
            // needList
            // 
            this.needList.FormattingEnabled = true;
            this.needList.ItemHeight = 16;
            this.needList.Location = new System.Drawing.Point(12, 68);
            this.needList.Name = "needList";
            this.needList.Size = new System.Drawing.Size(120, 84);
            this.needList.TabIndex = 3;
            this.needList.SelectedIndexChanged += new System.EventHandler(this.needList_SelectedIndexChanged);
            // 
            // haveList
            // 
            this.haveList.FormattingEnabled = true;
            this.haveList.ItemHeight = 16;
            this.haveList.Location = new System.Drawing.Point(212, 68);
            this.haveList.Name = "haveList";
            this.haveList.Size = new System.Drawing.Size(120, 84);
            this.haveList.TabIndex = 4;
            this.haveList.SelectedIndexChanged += new System.EventHandler(this.haveList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Need:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Have:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(124, 285);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // haveMoveButton
            // 
            this.haveMoveButton.Location = new System.Drawing.Point(212, 311);
            this.haveMoveButton.Name = "haveMoveButton";
            this.haveMoveButton.Size = new System.Drawing.Size(75, 23);
            this.haveMoveButton.TabIndex = 8;
            this.haveMoveButton.Text = "Move";
            this.haveMoveButton.UseVisualStyleBackColor = true;
            this.haveMoveButton.Visible = false;
            this.haveMoveButton.Click += new System.EventHandler(this.haveMoveButton_Click);
            // 
            // haveDeleteButton
            // 
            this.haveDeleteButton.Location = new System.Drawing.Point(41, 311);
            this.haveDeleteButton.Name = "haveDeleteButton";
            this.haveDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.haveDeleteButton.TabIndex = 9;
            this.haveDeleteButton.Text = "Delete";
            this.haveDeleteButton.UseVisualStyleBackColor = true;
            this.haveDeleteButton.Visible = false;
            this.haveDeleteButton.Click += new System.EventHandler(this.haveDeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.haveRadioButton);
            this.groupBox1.Controls.Add(this.needRadioButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.itemNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(20, 32);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemNameTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Item Name";
            // 
            // needRadioButton
            // 
            this.needRadioButton.AutoSize = true;
            this.needRadioButton.Location = new System.Drawing.Point(72, 73);
            this.needRadioButton.Name = "needRadioButton";
            this.needRadioButton.Size = new System.Drawing.Size(63, 21);
            this.needRadioButton.TabIndex = 15;
            this.needRadioButton.TabStop = true;
            this.needRadioButton.Text = "Need";
            this.needRadioButton.UseVisualStyleBackColor = true;
            // 
            // haveRadioButton
            // 
            this.haveRadioButton.AutoSize = true;
            this.haveRadioButton.Location = new System.Drawing.Point(180, 73);
            this.haveRadioButton.Name = "haveRadioButton";
            this.haveRadioButton.Size = new System.Drawing.Size(62, 21);
            this.haveRadioButton.TabIndex = 16;
            this.haveRadioButton.TabStop = true;
            this.haveRadioButton.Text = "Have";
            this.haveRadioButton.UseVisualStyleBackColor = true;
            // 
            // needMoveButton
            // 
            this.needMoveButton.Location = new System.Drawing.Point(212, 311);
            this.needMoveButton.Name = "needMoveButton";
            this.needMoveButton.Size = new System.Drawing.Size(75, 23);
            this.needMoveButton.TabIndex = 11;
            this.needMoveButton.Text = "Move";
            this.needMoveButton.UseVisualStyleBackColor = true;
            this.needMoveButton.Visible = false;
            this.needMoveButton.Click += new System.EventHandler(this.needMoveButton_Click);
            // 
            // needDeleteButton
            // 
            this.needDeleteButton.Location = new System.Drawing.Point(41, 311);
            this.needDeleteButton.Name = "needDeleteButton";
            this.needDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.needDeleteButton.TabIndex = 12;
            this.needDeleteButton.Text = "Delete";
            this.needDeleteButton.UseVisualStyleBackColor = true;
            this.needDeleteButton.Visible = false;
            this.needDeleteButton.Click += new System.EventHandler(this.needDeleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 369);
            this.Controls.Add(this.needDeleteButton);
            this.Controls.Add(this.needMoveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.haveDeleteButton);
            this.Controls.Add(this.haveMoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.haveList);
            this.Controls.Add(this.needList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox needList;
        private System.Windows.Forms.ListBox haveList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button haveMoveButton;
        private System.Windows.Forms.Button haveDeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton haveRadioButton;
        private System.Windows.Forms.RadioButton needRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Button needMoveButton;
        private System.Windows.Forms.Button needDeleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

