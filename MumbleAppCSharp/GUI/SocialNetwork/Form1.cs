using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetwork
{
    public partial class Form1 : Form
    {
        // Define the CS_DROPSHADOW constant
        private const int CS_DROPSHADOW = 0x00020000;

        // Override the CreateParams property
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.feedPnl.AutoScroll = true;
            List<Post> PostList = new List<Post>();
            PopulateItems(ref PostList);
            lstContainer.View = View.List;
            

            foreach (Post item in PostList)
            {
                lstContainer.Items.Add(item.GetContent());
            }
        }

        public void PopulateItems(ref List<Post> temp)
        {
            Post p1 = new Post("Loem Ipsum is Dolar Silam.", "802154");
            Post p2 = new Post("Yummy dummy I am tired of typing.", "569875");
            Post p3 = new Post("Yanki danky doh, raw raw raw.", "214587");
            Post p4 = new Post("I am a cat, meow meown meow.", "965874");
            temp.Add(p1);
            temp.Add(p2);
            temp.Add(p3);
            temp.Add(p4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Panel myPanel = new Panel();
            myPanel.Location = new Point(25, 60);
            myPanel.BackColor = Color.Red;
            this.Controls.Add(myPanel);
        }

        private void feedPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
