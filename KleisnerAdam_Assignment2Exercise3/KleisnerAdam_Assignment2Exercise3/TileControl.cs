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
    public partial class TileControl : ScrollableControl
    {

        Size tileSize = new Size(115, 125);

        [DefaultValue(typeof(Size), "64,64")]
        public Size TileSize
        {
            get { return tileSize; }
            set { tileSize = value; }
        }


        Size tileGridSize = new Size(2, 1);

        [DefaultValue(typeof(Size), "2,1")]
        public Size TileGridSize
        {
            get { return tileGridSize; }
            set { tileGridSize = value; }
        }

        public Bitmap TileImage
        {
            get
            {
                return tileImage;
            }

            set
            {
                tileImage = value;
                AutoScrollMinSize = tileImage.Size;

                Invalidate();
            }
        }

        public Point MouseLocation { get; internal set; }

        Bitmap tileImage = Properties.Resources.fig_xo_icons;


        public TileControl()
        {
            InitializeComponent();
        }
        Rectangle selectedRect = Rectangle.Empty;
        public Point selected;

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.DrawImage(TileImage, AutoScrollPosition);

            Point autoscrollposition = new Point(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);

            Pen black = new Pen(Color.Black, 2);
            Pen red = new Pen(Color.HotPink, 2);

            Rectangle creatingGrid = Rectangle.Empty;


            for (int x = 0; x < TileGridSize.Width; x++)
            {
                for (int y = 0; y < TileGridSize.Height; y++)
                {
                    creatingGrid.X = x * TileSize.Width + autoscrollposition.X;
                    creatingGrid.Y = y * TileSize.Height + autoscrollposition.Y;
                    creatingGrid.Size = TileSize;

                    if (((creatingGrid.X - AutoScrollPosition.X) / TileSize.Width == selected.X) &&
                            (creatingGrid.Y - AutoScrollPosition.Y) / TileSize.Height == selected.Y &&
                            selected.X < tileGridSize.Width && selected.Y < tileGridSize.Height)
                    {
                        selectedRect = creatingGrid;
                    }
                    pe.Graphics.DrawRectangle(black, creatingGrid);
                }
            }
            pe.Graphics.DrawRectangle(red, selectedRect);
        }
    }
}
