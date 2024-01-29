using System;
using System.Windows.Forms;

namespace Short_Path_Dj
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.adjmatrix1 = new System.Windows.Forms.TableLayoutPanel();
            this.graphGroupBox = new System.Windows.Forms.GroupBox();
            this.drawingArea1 = new Short_Path_Dj.DrawingArea();
            this.runDijkstra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.adjListDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.adjmatrix1.SuspendLayout();
            this.graphGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // adjmatrix1
            // 
            this.adjmatrix1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.adjmatrix1.ColumnCount = 2;
            this.adjmatrix1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adjmatrix1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adjmatrix1.Controls.Add(this.graphGroupBox, 0, 0);
            this.adjmatrix1.Controls.Add(this.runDijkstra, 1, 2);
            this.adjmatrix1.Controls.Add(this.groupBox1, 1, 1);
            this.adjmatrix1.Controls.Add(this.groupBox2, 1, 0);
            this.adjmatrix1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adjmatrix1.Location = new System.Drawing.Point(0, 0);
            this.adjmatrix1.Name = "adjmatrix1";
            this.adjmatrix1.RowCount = 3;
            this.adjmatrix1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.adjmatrix1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.adjmatrix1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.adjmatrix1.Size = new System.Drawing.Size(780, 463);
            this.adjmatrix1.TabIndex = 0;
            this.adjmatrix1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // graphGroupBox
            // 
            this.graphGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.graphGroupBox.Controls.Add(this.drawingArea1);
            this.graphGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphGroupBox.ForeColor = System.Drawing.Color.Red;
            this.graphGroupBox.Location = new System.Drawing.Point(6, 6);
            this.graphGroupBox.Name = "graphGroupBox";
            this.adjmatrix1.SetRowSpan(this.graphGroupBox, 3);
            this.graphGroupBox.Size = new System.Drawing.Size(379, 451);
            this.graphGroupBox.TabIndex = 0;
            this.graphGroupBox.TabStop = false;
            this.graphGroupBox.Text = "Graph Area";
            this.graphGroupBox.Enter += new System.EventHandler(this.graphGroupBox_Enter);
            // 
            // drawingArea1
            // 
            this.drawingArea1.AutoScroll = true;
            this.drawingArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drawingArea1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawingArea1.Location = new System.Drawing.Point(3, 19);
            this.drawingArea1.Name = "drawingArea1";
            this.drawingArea1.Size = new System.Drawing.Size(373, 429);
            this.drawingArea1.TabIndex = 0;
            this.drawingArea1.Load += new System.EventHandler(this.drawingArea1_Load);
            // 
            // runDijkstra
            // 
            this.runDijkstra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.runDijkstra.BackColor = System.Drawing.Color.SlateBlue;
            this.runDijkstra.Location = new System.Drawing.Point(394, 419);
            this.runDijkstra.Name = "runDijkstra";
            this.runDijkstra.Size = new System.Drawing.Size(380, 38);
            this.runDijkstra.TabIndex = 2;
            this.runDijkstra.Text = "RUN";
            this.runDijkstra.UseVisualStyleBackColor = false;
            this.runDijkstra.Click += new System.EventHandler(this.runDijkstra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(394, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(3, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(374, 155);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.adjListDataGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(394, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adjacency Matrix";
            // 
            // adjListDataGrid
            // 
            this.adjListDataGrid.AllowUserToAddRows = false;
            this.adjListDataGrid.AllowUserToDeleteRows = false;
            this.adjListDataGrid.AllowUserToResizeColumns = false;
            this.adjListDataGrid.AllowUserToResizeRows = false;
            this.adjListDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adjListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adjListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adjListDataGrid.Location = new System.Drawing.Point(3, 19);
            this.adjListDataGrid.Name = "adjListDataGrid";
            this.adjListDataGrid.RowHeadersWidth = 51;
            this.adjListDataGrid.RowTemplate.Height = 24;
            this.adjListDataGrid.Size = new System.Drawing.Size(374, 196);
            this.adjListDataGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 463);
            this.Controls.Add(this.adjmatrix1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Gilroy ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijkstra Shortest Path";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.adjmatrix1.ResumeLayout(false);
            this.graphGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adjListDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void graphGroupBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void drawingArea1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion


        private GraphicsNode graphicsNode1;
        private System.Windows.Forms.TableLayoutPanel adjmatrix1;
        private System.Windows.Forms.GroupBox graphGroupBox;
        public DrawingArea drawingArea1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button runDijkstra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView adjListDataGrid;
    }
}

