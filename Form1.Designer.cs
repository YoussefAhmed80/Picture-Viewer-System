namespace Project_c_Sharp
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.b1 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.c1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.singlePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan = new System.Windows.Forms.Panel();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.c1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(14, 5);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(218, 345);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.GreenYellow;
            this.b1.Location = new System.Drawing.Point(14, 360);
            this.b1.Margin = new System.Windows.Forms.Padding(5);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(218, 54);
            this.b1.TabIndex = 2;
            this.b1.Text = "Add";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.c1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.c1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePictureToolStripMenuItem,
            this.slideShowToolStripMenuItem,
            this.multiPictureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(169, 100);
            this.c1.Opening += new System.ComponentModel.CancelEventHandler(this.c1_Opening);
            // 
            // singlePictureToolStripMenuItem
            // 
            this.singlePictureToolStripMenuItem.Name = "singlePictureToolStripMenuItem";
            this.singlePictureToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.singlePictureToolStripMenuItem.Text = "Single Picture";
            this.singlePictureToolStripMenuItem.Click += new System.EventHandler(this.singlePictureToolStripMenuItem_Click);
            // 
            // slideShowToolStripMenuItem
            // 
            this.slideShowToolStripMenuItem.Name = "slideShowToolStripMenuItem";
            this.slideShowToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.slideShowToolStripMenuItem.Text = "Slide Show";
            this.slideShowToolStripMenuItem.Click += new System.EventHandler(this.slideShowToolStripMenuItem_Click);
            // 
            // multiPictureToolStripMenuItem
            // 
            this.multiPictureToolStripMenuItem.Name = "multiPictureToolStripMenuItem";
            this.multiPictureToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.multiPictureToolStripMenuItem.Text = "Multi Picture";
            this.multiPictureToolStripMenuItem.Click += new System.EventHandler(this.multiPictureToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pan
            // 
            this.pan.AutoScroll = true;
            this.pan.Location = new System.Drawing.Point(448, 5);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(583, 473);
            this.pan.TabIndex = 7;
            this.pan.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_Paint);
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(240, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(200, 200);
            this.pic1.TabIndex = 8;
            this.pic1.TabStop = false;
            // 
            // statusBar1
            // 
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar1.Location = new System.Drawing.Point(240, 213);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(202, 39);
            this.statusBar1.TabIndex = 10;
            this.statusBar1.Text = "statusBar1";
            this.statusBar1.Visible = false;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 2000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1195, 553);
            this.ContextMenuStrip = this.c1;
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.c1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.ContextMenuStrip c1;
        private System.Windows.Forms.ToolStripMenuItem singlePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
    }
}

