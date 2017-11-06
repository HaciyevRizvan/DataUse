using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataUse
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Name = txtName.Text;
            var password = txtPass.Text;
            if(Name=="Rizvan"&& password == "12345")
            {
                this.Hide();
                var info = new Information();
                info.Show();
            }
        }
    }
}
