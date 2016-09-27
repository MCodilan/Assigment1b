using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Can you read? Here, I'll give you another chance. Dont screw this up.";
        }

        private void frmHelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void btnPressb_Click(object sender, EventArgs e)
        {
            lblResult2.Text = "What did I just say!? Last chance, don't be stupid.";
        }

        private void btnPressc_Click(object sender, EventArgs e)
        {
            lblResult3.Text = "I knew you wouldn't listen. That's why the last couple of buttons were fakes! HA TRY ME NOW!!!";
        }

        private void btnPressd_Click(object sender, EventArgs e)
        {
            lblResult4.Text = "Oh my lord... you are like a child, here play with this.";
        }

        private void btnPresse_Click(object sender, EventArgs e)
        {
            lblResult5.Text = "...";
        }

        private void btnPressf_Click(object sender, EventArgs e)
        {
            lblResult6.Text = "Fine, if that doesn't keep you entertained then I've got a joke for you. \n Knock Knock.";
        }

        private void btnPressg_Click(object sender, EventArgs e)
        {
            lblResult7.Text = "Interupting Dog.";
        }

        private void btnPressh_Click(object sender, EventArgs e)
        {
            lblResult8.Text = "BARK BARK BARK BARK BARK BARK BARK BARK BARK!!!";
        }
    }
}
