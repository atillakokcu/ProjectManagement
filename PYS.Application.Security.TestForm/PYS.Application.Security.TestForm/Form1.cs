using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PYS.Application.Security;

namespace PYS.Application.Security.TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           TxtEncryptText.Text= PYSSecurity.Encrypt(TxtCleantext.Text.ToString(), "asdasdas");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDecryptText.Text = PYSSecurity.Decrypt(TxtEncryptText.Text, "asdsa");
        }
    }
}
