namespace KleisnerAdam_Assignment2Exercise3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tileControl2 = new KleisnerAdam_Assignment2Exercise3.TileControl();
            this.customMapControl1 = new KleisnerAdam_Assignment2Exercise3.CustomMapControl();
            this.SuspendLayout();
            // 
            // tileControl2
            // 
            this.tileControl2.AutoScroll = true;
            this.tileControl2.AutoScrollMinSize = new System.Drawing.Size(353, 181);
            this.tileControl2.Location = new System.Drawing.Point(13, 13);
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Size = new System.Drawing.Size(410, 256);
            this.tileControl2.TabIndex = 0;
            this.tileControl2.Text = "tileControl2";
            this.tileControl2.TileImage = ((System.Drawing.Bitmap)(resources.GetObject("tileControl2.TileImage")));
            this.tileControl2.TileSize = new System.Drawing.Size(115, 125);
            // 
            // customMapControl1
            // 
            this.customMapControl1.Location = new System.Drawing.Point(629, 129);
            this.customMapControl1.MapSize = new System.Drawing.Size(3, 3);
            this.customMapControl1.Name = "customMapControl1";
            this.customMapControl1.SelectedTile = new System.Drawing.Point(0, 0);
            this.customMapControl1.Size = new System.Drawing.Size(530, 488);
            this.customMapControl1.TabIndex = 1;
            this.customMapControl1.Text = "customMapControl1";
            this.customMapControl1.TileSize = new System.Drawing.Size(170, 160);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 752);
            this.Controls.Add(this.customMapControl1);
            this.Controls.Add(this.tileControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TileControl tileControl1;
        private TileControl tileControl2;
        private CustomMapControl customMapControl1;
    }
}

