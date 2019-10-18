﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Web.Script.Serialization;


namespace ASANA_connect_API_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillForm();
        }
        public void FillForm()
        {
           
            UserData ud = new UserData();
            RootObject ro = ud.UserFind("me"); 
            labelUserName.Text = ro.data.name;
            labelEmail.Text = ro.data.email;
            labelProject.Text = ro.data.workspaces[0].name;

            UsersData usd = new UsersData();
            List<Datum> listOfUsers = usd.UsersFind();//краткий перечень пользователей
            foreach (Datum i in listOfUsers)
            {
               // RootObject newI = ud.UserFind(i.gid);//подробная информация на пользователя
                comboBoxUser.Items.Add(i.name);
            }
            ProjectNames pn = new ProjectNames();
            List<Datum> listOfProjects = pn.ProjectsFind();//краткий перечень проектов
            foreach (Datum i in listOfProjects)
            {
                comboBoxProject.Items.Add(i.name);
            }
        }


        private void buttonRun_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label6.Text = "Загрузка перечня...";
            TaskData td = new TaskData();
            UsersData usd = new UsersData();
            List<Datum> listOfUsers = usd.UsersFind();
            ProjectNames pn = new ProjectNames();
            List<Datum> listOfProjects = pn.ProjectsFind();//краткий перечень проектов
            string projectGid;
            if (comboBoxProject.SelectedIndex >= 0) projectGid = listOfProjects[comboBoxProject.SelectedIndex].gid;
            else projectGid = null;
            List<Datum> listOfTasks = td.TasksFind(projectGid);
            string assignee = listOfUsers[comboBoxUser.SelectedIndex].gid;
            TaskFullData tfd = new TaskFullData();
            int n = 1;
            bool yes = false;
            int c1 = listOfTasks.Count();
            int t = 1;
            label6.Text = "Обработка данных...";
            foreach (Datum i in listOfTasks)
            {
                yes = false;
                DataTaskFull dtf = tfd.TasksFind(i.gid);
                string follw ="";
                foreach (TheElement ftf in dtf.followers)
                {
                    follw += ftf.name + "; ";
                }
                string proj = "";
                foreach (TheElement ftf in dtf.projects)
                {
                    proj += ftf.name + "; ";
                }
                if (dtf.assignee!=null) 
                    if(dtf.assignee.gid == assignee) yes = true;
                bool compCheck = false;
                if (checkBoxNotDone.Checked == false) compCheck = true;
                if (yes & (dtf.completed ==compCheck || dtf.completed == false))
                {
                    dataGridView1.Rows.Add(t, i.name, dtf.assignee.name, follw, dtf.due_on, dtf.completed, proj, dtf.notes);
                    t++;
                }

                progressBar1.Value = Convert.ToInt32(n* 100 / c1 );
                n++; 
            }
            label6.Text = "Данные загружены";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            TaskAdd ta = new TaskAdd();
            ta.ShowDialog();
        }
    }
}
