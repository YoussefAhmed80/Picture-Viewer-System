using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Project_c_Sharp
{
    public partial class Form1 : Form
    {
        static string[] ar = new string[1000];
        static OpenFileDialog ofd = new OpenFileDialog();
        static int c=0;
        
        public string InitialDirectory { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                ofd.Title = "Please Choose Picture";


                string s;

                ofd.Multiselect = true;
                ofd.Filter = "pictures|*.JPG;*.jpg;*.JPEG;*.jpeg;*.GIF;*.gif;*.PNG;*.png";
                ofd.ShowDialog();
                foreach (string t in ofd.FileNames)
                {
                    if (!listBox1.Items.Contains(Path.GetFileName(t)))
                    {
                        listBox1.Items.Add(Path.GetFileName(t));
                        ar[c] = t;
                        c++;
                        s = t;
                    }

                }
            }
            catch(Exception ex)
            {

            }
        }
        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        static int b= 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
               
                if (b < listBox1.Items.Count)
                {
                    pic1.Image = Image.FromFile(ar[b]);
                   
                    string str= Path.GetFileName(listBox1.Items[b].ToString());
                    statusBar1.Panels[0].Text = str;
                    b++;
                }
                else
                {
                    b = 0;
                    t1.Enabled = false;
                    multiPictureToolStripMenuItem.Enabled = true;
                    singlePictureToolStripMenuItem.Enabled = true;
                    exitToolStripMenuItem.Enabled = true;
                    slideShowToolStripMenuItem.Enabled = true;
                }
                
            }
            catch(Exception ex)
            {

            }
            
        }
        private void singlePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                pan.Controls.Clear();
                pic1.Image = null;
                pic1.Invalidate();
                pan.Visible = false;
                statusBar1.Visible = false;

                if (listBox1.SelectedIndex != -1)
                {
                    int i;
                    i = listBox1.SelectedIndex;
                    pic1.Image = Image.FromFile(ar[i]);
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch(Exception ex)
            {

            }
        }
        private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                pan.Controls.Clear();
                pic1.Image = null;
                statusBar1.Visible = true;
                pic1.Invalidate();
                multiPictureToolStripMenuItem.Enabled = false;
                singlePictureToolStripMenuItem.Enabled = false;
                exitToolStripMenuItem.Enabled = false;
                slideShowToolStripMenuItem.Enabled = false;
                t1.Enabled = true;
                
                
            }
            catch(Exception ex)
            {

            }

        }  
        private void multiPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                pan.Controls.Clear();
                pic1.Image = null;
                pic1.Invalidate();
                pan.Visible = true;
                statusBar1.Visible = false;

                if (listBox1.SelectedIndex != -1)
                {
                    int count = 1;
                    int x = 10;
                    int y = 10;
                    int maxheight = -1;
                    foreach (int i in listBox1.SelectedIndices)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(ar[i]);
                        pic.SetBounds(x, y, 100, 70);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        x += 105;
                        if(count%5==0)
                        {
                            y += 75;
                            x = 10;
                        }
                        count++;
                        this.pan.Controls.Add(pic);

                    }
                }
            }
           
            catch(Exception ex)
            {
                
            }
        }
        private void pan_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void pic1_Click(object sender, EventArgs e)
        {

        }
        private void c1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
