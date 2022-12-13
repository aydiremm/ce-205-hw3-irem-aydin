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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AVL_Click(object sender, EventArgs e)
        {
            AVL avl = new AVL();
            avl.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            RB rb = new RB();
            rb.Show();
        }
    }
}
