using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Short_Path_Dj
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Refresh();
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            GraphicsNode g = new GraphicsNode();
            g.Location = new Point(e.X - g.Size.Width / 2, e.Y - g.Size.Height / 2);
            ((Control)sender).Controls.Add(g);
        }

        private void runDijkstra_Click(object sender, EventArgs e)
        {

            string startingNode = Interaction.InputBox("Enter Starting Node:", "Starting Node", "", 600, 375);
            int sNode;
            try

            {
                sNode = int.Parse(startingNode);
            }
            catch
            {
                MessageBox.Show("Starting node is invalid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            var r = GraphicsNode.GetAdjListForDijkstra();
            Dijkstra d = new Dijkstra(r);
            var result = d.DijkstraAlgo(sNode);

            richTextBox1.Text = "Result of running the algorithm from Node " + sNode + "\r\n";
            for (int i = 0; i < result.Length; i++)
                if(result[i] != int.MaxValue)
                richTextBox1.Text += "Distance to Node " + i + " is " + result[i] + "\r\n";
            else
                    richTextBox1.Text += "Distance to Node " + i + " is " + "∞" + "\r\n";

        }
    }
}
