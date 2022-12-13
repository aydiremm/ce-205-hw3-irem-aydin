using AVL_Tree;
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
    public partial class AVL : Form
    {
        AVLTree tree;
        public AVL()
        {
            InitializeComponent();
            this.Text = "AVL Visualization";
            tree = new AVLTree(this);
            tree.preOrder(tree.root);
            foreach (var item in tree.lingkaran)
            {
                Console.WriteLine("X : " + item.Value.x + " Y: " + item.Value.y);

            }

        }

        public void mbox(String text)
        {
            MessageBox.Show(text);
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            tree.root = tree.InsertHelper(tree.root, Convert.ToString(valueBox.Text));
            tree.inOrderHelper();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            tree.root = tree.deleteNode(tree.root, Convert.ToString(valueBox.Text));
            tree.inOrderHelper();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            tree.find(Convert.ToString(valueBox.Text));
        }

        private void InOrder_Click(object sender, EventArgs e)
        {
            tree.inOrder(tree.root);
            MessageBox.Show("InOrder : " + tree.inOrderResult);
            tree.inOrderResult = "";
            tree.inOrderHelper();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            foreach (var item in tree.garis.Values)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), item.x1, item.y1, item.x2, item.y2);
            }
            foreach (var item in tree.lingkaran.Values)
            {
                e.Graphics.FillEllipse(item.brush, item.x, item.y, 90, 50);
                e.Graphics.DrawString(item.value, new Font("Arial", 12), new SolidBrush(Color.White), new Point(item.x + 8, item.y + 10));

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string data = "Interdum et malesuada fames ac ante ipsum primis in faucibus. In eu lorem sodales, feugiat ipsum molestie, scelerisque risus. Ut commodo aliquam dictum. Suspendisse ultrices mauris vel sapien dapibus efficitur. Cras ut odio tristique, mattis tellus sit amet, ullamcorper augue. Mauris eu augue metus. Donec congue iaculis nibh, id vehicula lacus. Aliquam consectetur nisl at neque luctus rhoncus vitae eget libero. Sed vel sem at libero congue vehicula a a ex. Donec vitae massa quis mauris sodales egestas. Maecenas viverra lacinia nibh at viverra. Maecenas non rutrum dui. Proin mauris justo, sodales nec auctor sed, varius at lectus. Fusce vel libero id dui tristique consequat sed at dolor.Ut at magna euismod, congue mi eget, vulputate mi. Sed eget purus ac magna euismod ornare. Pellentesque nisi nibh, porta et ornare maximus, fermentum quis sapien. Nullam eget nulla vitae diam dictum tincidunt eget et purus. Nulla placerat lectus nec orci consequat, eu finibus orci congue. Suspendisse vehicula tellus erat, eu varius purus bibendum ac. Nunc et quam ac turpis faucibus commodo non a leo. Morbi eu erat a quam luctus condimentum. Donec sed lorem sed nunc maximus facilisis. Vestibulum eu dui nisl. Quisque elit metus, faucibus ut arcu a, malesuada tincidunt mauris. Mauris mollis dui tortor, eu placerat risus convallis tincidunt. Etiam fringilla semper metus nec semper. In tincidunt eros dui, in vulputate ipsum dictum et.Ut dui dolor, rhoncus sit amet lacus et, malesuada ornare odio. Aliquam laoreet nisl non est tristique, et consequat dolor rutrum. Nulla et ligula libero. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam molestie nisi vitae eros maximus maximus. Vivamus convallis consequat congue. Vestibulum a lacus eleifend, fermentum tellus non, vehicula quam. Duis ac ex mi. Integer aliquet lacinia lorem eget tincidunt. Curabitur nibh lacus, tristique quis tempus ut, lacinia non sem. Suspendisse suscipit justo eu diam hendrerit commodo. Pellentesque ornare luctus malesuada. Aliquam lobortis iaculis sagittis.";

            string[] words = data.Split(' ');
            Random rnd = new Random();
            int num = rnd.Next(0,300);

            valueBox.Text = words[num];



        }
    }
}
