using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ASANA_connect_API_test
{
    public partial class Form1 : Form
    {           
        public Form1()
        {
            InitializeComponent();
            UserData ud = new UserData();
            labelUser.Text = ud.UserFind();
        }

        private void buttonToAsanaCreate_Click(object sender, EventArgs e)
        {
            

        }

        private void ConnectionText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
