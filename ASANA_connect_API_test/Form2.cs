using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASANA_connect_API_test
{
    public partial class Form2 : Form
    {
        public bool Err { get; set; }
        public Form2()
        {
            InitializeComponent();
            Err = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length == 34)
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["token"].Value = textBox2.Text.Trim();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            else Err = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Err = true;
            this.Close();
        }
    }
}
