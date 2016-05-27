using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KleisnerAdam_Assignment2Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point selected;
        private void tileControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point offset = e.Location;
            offset.X -= tileControl1.AutoScrollPosition.X;
            offset.Y -= tileControl1.AutoScrollPosition.Y;
            selected.X = offset.X / tileControl1.TileSize.Width;
            selected.Y = offset.Y / tileControl1.TileSize.Height;

            if ((selected.X < tileControl1.TileGridSize.Width && selected.Y < tileControl1.TileGridSize.Height))
            {
                tileControl1.selected = selected;
                tileControl1.Invalidate();

                customMapControl1.SelectedTile = tileControl1.selected;
            }

        }

    }
}
