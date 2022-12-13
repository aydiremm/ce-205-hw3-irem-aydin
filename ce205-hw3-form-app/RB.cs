using ProjectSDL2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ce205_hw3_form_app
{
    public partial class RB : Form
    {
        RBTree avl;
        Brush temp; 
        public RB()
        {
            InitializeComponent();
            avl = new RBTree(this);
            temp = new SolidBrush(Color.White);
            pictureBox1.Width = this.Width;
        }

        private void valueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            avl.insertion(ref avl.root, Convert.ToString(valueBox.Text.ToString()), this.Width / 2, 50);
            valueBox.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            avl.delete(ref avl.root, Convert.ToString(valueBox.Text.ToString()));
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            avl.search(ref avl.root, Convert.ToString(valueBox.Text.ToString()));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (line x in avl.garis)
            {
                Pen p = new Pen(x.warna);
                e.Graphics.DrawLine(p, x.x1, x.y1, x.x2, x.y2);
            }
            foreach (var item in avl.lingkaran)
            {
                e.Graphics.FillEllipse(item.brush, item.x, item.y, 90, 30);
                e.Graphics.DrawString(item.value, new Font("Arial", 12), temp, new Point(item.x + 10, item.y + 5));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "Interdum et malesuada fames ac ante ipsum primis in faucibus. In eu lorem sodales, feugiat ipsum molestie, scelerisque risus. Ut commodo aliquam dictum. Suspendisse ultrices mauris vel sapien dapibus efficitur. Cras ut odio tristique, mattis tellus sit amet, ullamcorper augue. Mauris eu augue metus. Donec congue iaculis nibh, id vehicula lacus. Aliquam consectetur nisl at neque luctus rhoncus vitae eget libero. Sed vel sem at libero congue vehicula a a ex. Donec vitae massa quis mauris sodales egestas. Maecenas viverra lacinia nibh at viverra. Maecenas non rutrum dui. Proin mauris justo, sodales nec auctor sed, varius at lectus. Fusce vel libero id dui tristique consequat sed at dolor.Ut at magna euismod, congue mi eget, vulputate mi. Sed eget purus ac magna euismod ornare. Pellentesque nisi nibh, porta et ornare maximus, fermentum quis sapien. Nullam eget nulla vitae diam dictum tincidunt eget et purus. Nulla placerat lectus nec orci consequat, eu finibus orci congue. Suspendisse vehicula tellus erat, eu varius purus bibendum ac. Nunc et quam ac turpis faucibus commodo non a leo. Morbi eu erat a quam luctus condimentum. Donec sed lorem sed nunc maximus facilisis. Vestibulum eu dui nisl. Quisque elit metus, faucibus ut arcu a, malesuada tincidunt mauris. Mauris mollis dui tortor, eu placerat risus convallis tincidunt. Etiam fringilla semper metus nec semper. In tincidunt eros dui, in vulputate ipsum dictum et.Ut dui dolor, rhoncus sit amet lacus et, malesuada ornare odio. Aliquam laoreet nisl non est tristique, et consequat dolor rutrum. Nulla et ligula libero. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam molestie nisi vitae eros maximus maximus. Vivamus convallis consequat congue. Vestibulum a lacus eleifend, fermentum tellus non, vehicula quam. Duis ac ex mi. Integer aliquet lacinia lorem eget tincidunt. Curabitur nibh lacus, tristique quis tempus ut, lacinia non sem. Suspendisse suscipit justo eu diam hendrerit commodo. Pellentesque ornare luctus malesuada. Aliquam lobortis iaculis sagittis.";

            string[] words = data.Split(' ');
            Random rnd = new Random();
            int num = rnd.Next(0, 300);

            valueBox.Text = words[num];
        }
    }
}
