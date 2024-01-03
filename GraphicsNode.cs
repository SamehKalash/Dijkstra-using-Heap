using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Short_Path_Dj
{
    class GraphicsNode : Panel
    {
        //private float scaleFactor = 1.0f;
        public static Dictionary<int, List<(int, int)>> graph = new Dictionary<int, List<(int, int)>>();
        public static List<GraphicsNode> nodes = new List<GraphicsNode>();
        public static int nodeID = 0;
        public int ID;

        public bool isSelected = false;

        bool isMouseDown = false;

        public static GraphicsNode linkFrom = null;
        public static GraphicsNode linkTo = null;
        public static MainForm activeForm = null;

        public GraphicsNode()
        {
            // this.BorderStyle = BorderStyle.None;
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            this.Size = new Size(46, 46);
            this.MouseDown += GraphicsNode_MouseDown;
            this.MouseUp += GraphicsNode_MouseUp;
            this.MouseMove += GraphicsNode_MouseMove;

            ID = nodeID++;
            //Add the newly created node to the dictionary
            graph.Add(ID, new List<(int, int)>());
            nodes.Add(this);

            //Cick Event
            this.Click += GraphicsNode_Click;
        }


        private void GraphicsNode_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseDown = false;

            Control parentControl = ((Control)sender).Parent;
            if (parentControl != null)
            {
                parentControl.Invalidate();
                parentControl.Refresh();
            }

            //((Control)sender).Parent.Invalidate();
            //((Control)sender).Parent.Refresh();

        }
        public static List<(int, int)>[] GetAdjListForDijkstra()
        {
            List<(int, int)>[] adjList = new List<(int, int)>[nodes.Count];
            for (int i = 0; i < graph.Keys.Count; i++)
            {
                adjList[i] = new List<(int, int)>();
                adjList[i] = graph.ElementAt(i).Value;
            }
            return adjList;
        }
        public static void UpdateAdjMatrixGrid()
        {
            DataGridView adjMatrix = activeForm.adjListDataGrid;

            adjMatrix.Rows.Clear();
            adjMatrix.Columns.Clear();

            var _graph = GetAdjListForDijkstra();

            for (int i = 0; i < nodes.Count; i++)
            {
                adjMatrix.Columns.Add("N " + i, "N " + i);
            }

            foreach (var r in _graph)
            {
                object[] rData = new object[nodes.Count];
                foreach (var cell in r)
                {
                    rData[cell.Item1] = cell.Item2;
                }
                adjMatrix.Rows.Add(rData);
            }

            //Fix layout
            for (int i = 0; i < nodes.Count; i++)
            {
                adjMatrix.Rows[i].HeaderCell.Value = "N " + i;
            }
            adjMatrix.RowHeadersWidth = 77;
            //adjMatrix.AutoResizeColumns();
            adjMatrix.AllowUserToAddRows = false;
            adjMatrix.ReadOnly = true;

            adjMatrix.AutoSize = true;
            adjMatrix.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            adjMatrix.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            adjMatrix.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




        }

        public void ModifyEdge(int src, int dst, int weight, bool isRemove = false)
        {
            List<(int, int)> row = graph[src];
            if (row == null)
                row = new List<(int, int)>();

            var entry = row.FirstOrDefault(tmp => tmp.Item1 == dst);

            if (entry != default)
                row.Remove(entry);

            if (!isRemove)
                row.Add((dst, weight));

            List<(int, int)> row2 = graph[dst];
            if (row2 == null)
                row2 = new List<(int, int)>();

            var entry2 = row2.FirstOrDefault(tmp => tmp.Item1 == src);
            if (entry2 != default)
                row2.Remove(entry2);

            if (!isRemove)

                row2.Add((src, weight));

            UpdateAdjMatrixGrid();

        }
        private void GraphicsNode_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Control parent = ((Control)sender).Parent;
                Point newPos = parent.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
                newPos.X -= Size.Width / 2;
                newPos.Y -= Size.Height / 2;

                this.Location = newPos;

                ((Control)sender).Parent.Invalidate();
                ((Control)sender).Parent.Refresh();

            }
        }

        private void GraphicsNode_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!Control.ModifierKeys.HasFlag(Keys.Alt))
                    isMouseDown = true;
                if (Control.ModifierKeys.HasFlag(Keys.Control))
                {
                    RemoveNodeAndEdges(ID);
                }


            }
            else if (e.Button == MouseButtons.Right)
            {
                if (linkFrom == null)
                    linkFrom = this;
                else
                    linkTo = this;
                isSelected = true;
                Invalidate();
                Refresh();
                if (linkFrom != null && linkTo != null)
                {
                    string weight = Interaction.InputBox(" Enter Weight Value OR Type 'R' to remove :", "Weight Linking from Node " +
                        linkFrom.ID + " to Node " + linkTo.ID, "", 600, 375);
                    /*if (int.Parse(weight) < 0)
                    {
                        MessageBox.Show("Weight Should be Zero or Postive integer !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        linkFrom.isSelected = linkTo.isSelected = false;
                        linkFrom.Invalidate();
                        linkTo.Invalidate();
                        linkFrom = linkTo = null;
                        return;*/
                    //}
                    //   Console.WriteLine(linkFrom.ID + " " + linkTo.ID + " is " + weight);

                    if (weight.ToUpper() == "R")
                        ModifyEdge(linkFrom.ID, linkTo.ID, 0, true);
                    else
                    {
                        try
                        {
                            if (int.Parse(weight) >= 0)
                                ModifyEdge(linkFrom.ID, linkTo.ID, int.Parse(weight));
                            else
                            {
                                MessageBox.Show("Weight Should be Zero or a Postive integer !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                linkFrom.isSelected = linkTo.isSelected = false;
                                linkFrom.Invalidate();
                                linkTo.Invalidate();
                                linkFrom = linkTo = null;
                                return;
                            }
                        }
                        catch
                        {

                        }
                    }

                    // var row = graph[linkFrom.ID];

                    linkFrom.isSelected = linkTo.isSelected = false;
                    linkFrom.Invalidate();
                    linkTo.Invalidate();
                    linkFrom = linkTo = null;
                }

            }
            Control parentControl = ((Control)sender).Parent;
            if (parentControl != null)
            {
                parentControl.Invalidate();
                parentControl.Refresh();
            }
            //((Control)sender).Parent.Invalidate();
            //((Control)sender).Parent.Refresh();



        }

        private void GraphicsNode_Click(object sender, EventArgs e)
        {
            //invert = !invert;
            //Invalidate();
            //Refresh();
        }
        private void RemoveNodeAndEdges(int nodeId)
        {
            if (graph.ContainsKey(nodeId))
            {
                // Remove edges associated with the node
                foreach (var adjacentNodeId in graph[nodeId])
                {
                    graph[adjacentNodeId.Item1].RemoveAll(edge => edge.Item1 == nodeId);
                }
                // Remove the node from the graph and the UI
                graph.Remove(nodeId);
                var nodeToRemove = nodes.FirstOrDefault(node => node.ID == nodeId);
                if (nodeToRemove != null)
                {
                    nodes.Remove(nodeToRemove);
                    Parent.Controls.Remove(nodeToRemove);
                }
                UpdateAdjMatrixGrid();
            }
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            Pen SamehPen = new Pen(Color.DarkRed, 2);
            if (!isSelected)
                g.FillEllipse(Brushes.DarkRed, 5, 5, 40, 40);
            else
                g.DrawEllipse(SamehPen, 5, 5, 40, 40);


            g.DrawString(ID.ToString(), new Font(SystemFonts.DefaultFont.FontFamily, 14), Brushes.Silver, new Rectangle(5, 5, 40, 40), sf);

        }



    }
}
