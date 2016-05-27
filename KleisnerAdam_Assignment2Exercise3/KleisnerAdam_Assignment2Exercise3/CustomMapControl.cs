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
    public partial class CustomMapControl : ScrollableControl
    {
        public CustomMapControl()
        {
            InitializeComponent();
        }

        //size of each tile
        Size tileSize = new Size(170, 160);
        //columns and rows of the map
        //by default Points are initialized to 0,0 which is exactly...
        Point[,] map = new Point[3, 3];
        Point[,] temp;
        //the tileset image to use
        Bitmap tileSet = Properties.Resources.fig_xo_icons;
        //which part of the tilset represents a selected tile, changing this changes...
        Point selectedTile = new Point(0, 0);

        /// <summary>
        /// This is the property for getting the map sizes
        /// </summary>
        /// <param name="pe">This is a parameter</param>
        [Category("Map")]
        public Size MapSize
        {
            get
            {   //getllength(0) = width, getlenth(1) = height since it is a 2d array,
                return new Size(map.GetLength(0), map.GetLength(1));
            }
            set
            {
                temp = map;
                map = new Point[value.Width, value.Height];

                if (temp.GetLength(0) > map.GetLength(0) || temp.GetLength(1) > map.GetLength(1))
                {
                    for (int x = 0; x < map.GetLength(0); x++)
                    {
                        for (int y = 0; y < map.GetLength(1); y++)
                        {
                            map[x, y] = temp[x, y];
                        }
                    }
                }

                else if (temp.GetLength(0) < map.GetLength(0) || temp.GetLength(1) < map.GetLength(1))
                {
                    for (int x = 0; x < temp.GetLength(0); x++)
                    {
                        for (int y = 0; y < temp.GetLength(1); y++)
                        {
                            map[x, y] = temp[x, y];
                        }
                    }
                }

                SetScrollRange();
                Invalidate();
            }
        }

        [Category("Map")]
        public Size TileSize
        {
            get { return tileSize; }
            set
            {
                tileSize = value;
                SetScrollRange();
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Bitmap Tilese
        {
            get { return tileSet; }
            set
            {
                tileSet = value;
                SetScrollRange();
                Invalidate();
            }
        }

        public Point SelectedTile
        {
            get { return selectedTile; }
            set { selectedTile = value; }
        }



        protected override void OnPaint(PaintEventArgs pe)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    Rectangle destRect = Rectangle.Empty;
                    destRect.X = x * tileSize.Width;
                    destRect.Y = y * tileSize.Height;
                    destRect.Size = tileSize;
                    destRect.Offset(this.AutoScrollPosition);

                    Rectangle srcRect = Rectangle.Empty;
                    srcRect.X = map[x, y].X * tileSize.Width;
                    srcRect.Y = map[x, y].Y * tileSize.Height;
                    srcRect.Size = tileSize;

                    pe.Graphics.DrawImage(tileSet, destRect, srcRect, GraphicsUnit.Pixel);

                    pe.Graphics.DrawRectangle(Pens.HotPink, destRect);
                }
            }
        }

        private void SetScrollRange()
        {
            Size scrollSize = Size.Empty;

            scrollSize.Width = map.GetLength(0) * tileSize.Width;
            scrollSize.Height = map.GetLength(1) * tileSize.Height;

            this.AutoScrollMinSize = scrollSize;
        }

    }
}
