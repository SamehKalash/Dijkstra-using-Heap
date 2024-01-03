using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Short_Path_Dj
{
    public partial class DrawingArea : UserControl
    {
        //private float scaleFactor = 1.0f; 
        public DrawingArea()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            //this.MouseWheel += DrawingArea_MouseWheel;


        }

       /* public void ZoomIn()
        {
            scaleFactor += 0.1f; // Increase scale factor for zoom in
            Refresh(); // Redraw the control
        }

        public void ZoomOut()
        {
            scaleFactor -= 0.1f; // Decrease scale factor for zoom out
            Refresh(); // Redraw the control
        }*/

        private void DrawingArea_MouseClick(object sender, MouseEventArgs e)
        {
            GraphicsNode g = new GraphicsNode();
            g.Location = new Point(e.X - g.Size.Width / 2, e.Y - g.Size.Height / 2);
            ((Control)sender).Controls.Add(g);

            GraphicsNode.UpdateAdjMatrixGrid();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //  base.OnPaint(e);
            //e.Graphics.ScaleTransform(scaleFactor, scaleFactor);

            for (int i = 0; i < GraphicsNode.graph.Count; i++)
            {
                int srcID = GraphicsNode.graph.ElementAt(i).Key;
                GraphicsNode src = GraphicsNode.nodes.First(x => x.ID == srcID);

                for (int j = 0; j < GraphicsNode.graph[i].Count; j++)
                {
                    int dstID = GraphicsNode.graph[i][j].Item1;
                    int weight = GraphicsNode.graph[i][j].Item2;
                    GraphicsNode dst = GraphicsNode.nodes.First(y => y.ID == dstID);
                   
                    Point c1 = new Point(src.Location.X + src.Size.Width / 2,
                        src.Location.Y + src.Size.Height / 2);

                    Point c2 = new Point(dst.Location.X + dst.Size.Width / 2,
                        dst.Location.Y + src.Size.Height / 2);

                    Point mid = new Point((c1.X + c2.X - 20) / 2, (c1.Y + c2.Y - 34) / 2);

                    Font customFont = new Font("Berlin Sans FB", 11, FontStyle.Regular);
                    e.Graphics.DrawString(weight.ToString(), customFont, Brushes.DarkGoldenrod, mid);

                    Pen Samehpen = new Pen(Brushes.DarkRed, 2);
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawLine(Samehpen, new Point(src.Location.X+5 + src.Size.Width / 2,
                        src.Location.Y + src.Size.Height / 2), new Point(dst.Location.X+5 + dst.Size.Width / 2,
                        dst.Location.Y + src.Size.Height / 2));

                }

            }
        }


       /* private void DrawingArea_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }*/
    }
}
