using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ASANA_connect_API_test
{
    public partial class TaskAdd : Form
    {
        ListBoxAdding lbaFollower = new ListBoxAdding();
        ListBoxAdding lbaProjects = new ListBoxAdding();
        List<Datum> listOfUsers;
        List<Datum> listOfProjects;
        public TaskAdd()
        {
            InitializeComponent();
            FormFill();
        }
        public void FormFill()
        {
            //загрузка перечня пользователей
            UsersData usd = new UsersData();
            listOfUsers = usd.UsersFind();
            //загрузка перечня проектов
            ProjectNames pn = new ProjectNames();
            listOfProjects = pn.ProjectsFind();
            foreach (Datum d in listOfUsers)
            {
                comboBox1.Items.Add(d.name);
                comboBox3.Items.Add(d.name);
            }
            foreach (Datum d in listOfProjects)
            {
                comboBox2.Items.Add(d.name);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void TaskAdd_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFollAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.FindStringExact(comboBox1.SelectedItem.ToString()) < 0)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                lbaFollower.AddToList(listOfUsers[comboBox1.SelectedIndex].gid);
            }
        }

        private void buttonProjAdd_Click(object sender, EventArgs e)
        {
            if (listBox2.FindStringExact(comboBox2.SelectedItem.ToString()) < 0)
            {
                listBox2.Items.Add(comboBox2.SelectedItem);
                lbaProjects.AddToList(listOfProjects[comboBox2.SelectedIndex].gid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //добавление в Asan'у
            Connect con = new Connect();
            Dictionary<string, string> paramsDic = new Dictionary<string, string>();
            paramsDic.Add("name", HttpUtility.UrlEncode(textBox1.Text));
            paramsDic.Add("notes", HttpUtility.UrlEncode(textBox2.Text));
            paramsDic.Add("assignee", listOfUsers[comboBox3.SelectedIndex].gid);
            paramsDic.Add("workspace", "680119048803634");
            paramsDic.Add("due_on", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
            string data = "";
            foreach (var item in paramsDic)
            {
                data += "&" + item.Key + "=" + item.Value;
            }
            data = data.Remove(0, 1);
            int itemCount = 0;
            foreach (var item in lbaFollower.DataStorage)
            {
                data += "&followers[" + itemCount + "]=" + item;
                itemCount++;
            }
            itemCount = 0;
            foreach (var item in lbaProjects.DataStorage)
            {
                data += "&projects[" + itemCount + "]=" + item;
                itemCount++;
            }

            string toDesert = con.DownloadToAsana(data);
            DeserializeThiseJson desert = new DeserializeThiseJson();
            RootObjectTaskResponse taskResponse = new RootObjectTaskResponse();
            taskResponse = (RootObjectTaskResponse)desert.DeserializeMe(toDesert, taskResponse);
            label4.Text = taskResponse.data.gid;
            button1.Visible = false;
        }
    }
}
