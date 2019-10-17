﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Script.Serialization;

namespace ASANA_connect_API_test
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    //получение перечня задач
    public class TaskData
    {
        public List<Datum> TasksFind(string project)
        {
            string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/projects/" + project+"/tasks";
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            //*******только для одного запроса про пользователя**********
            RootObjectUsers meClass = new RootObjectUsers();
            meClass = (RootObjectUsers)deser.DeserializeMe(result, meClass);
            return meClass.data;
        }
    }
    //получение подробных данных по задаче
    public class TaskFullData
    {
        public DataTaskFull TasksFind(string gid)
        {
            string fullLine = "/" + gid;
            string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/tasks" + fullLine+ "?opt_fields=gid,completed,due_on,followers.name,name,notes,projects.name";
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            //*******только для одного запроса про пользователя**********
            RootObjectTaskFull meClass = new RootObjectTaskFull();
            meClass = (RootObjectTaskFull)deser.DeserializeMe(result, meClass);
            return meClass.data;
        }
    }
    public class ProjectNames
    {
        public List<Datum> ProjectsFind()
        {
            string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/projects";
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            //*******только для одного запроса про пользователя**********
            RootObjectUsers meClass = new RootObjectUsers();
            meClass = (RootObjectUsers)deser.DeserializeMe(result, meClass);
            return meClass.data;
        }
    }
    //**************получение данных по пользователю*******
    public class UserData
    {
        public RootObject UserFind(string userid)
        {
            string connectionLine;
            Connect conection = new Connect();
            connectionLine = "https://app.asana.com/api/1.0/users/" + userid;
            string result = conection.ConnectToLinq(connectionLine);
            DeserializeThiseJson deser = new DeserializeThiseJson();
            RootObject meClass = new RootObject();
            meClass = (RootObject)deser.DeserializeMe(result, meClass);
            return meClass;
        }
    }
    //***************получение данных по всем пользователям(перечень)
    public class UsersData
    {
        public List<Datum> UsersFind()
        {
            string connectionLine = "https://app.asana.com/api/1.0/users";
            Connect conection = new Connect();
            string result = conection.ConnectToLinq(connectionLine);
            RootObjectUsers meClassUSD = new RootObjectUsers();
            try
            {
                DeserializeThiseJson deser = new DeserializeThiseJson();
                meClassUSD = (RootObjectUsers)deser.DeserializeMe(result, meClassUSD);
            }
            catch (Exception e)
            {
            }
            List<Datum> dat = meClassUSD.data;
            return meClassUSD.data;
        }
    }
    //********десериализация***********
    public class DeserializeThiseJson
    {
        public object DeserializeMe(string json, object deserialized)//, string findKey)
        {
            try
            {
                JavaScriptSerializer serial = new JavaScriptSerializer();
                deserialized = serial.Deserialize(json, deserialized.GetType());
            }
            catch (Exception e)
            {

            }
            return deserialized;

        }
    }
    public class Connect
    {
        //public Connect(string conline)
        //{
        //    ConnectToLinq(conline);
        //}
        public string ConnectToLinq(string conline)
        {
            string token = Properties.Settings.Default.token;
            token = "Bearer " + token;
            //HttpRequestHeader. WwwAuthenticate
            WebHeaderCollection webHeaderCollection = new WebHeaderCollection();
            webHeaderCollection.Add(HttpRequestHeader.Authorization, token);

            WebRequest newRequest = WebRequest.Create(conline);
            newRequest.Headers = webHeaderCollection;
            WebResponse newResponse = newRequest.GetResponse();
            Stream newStream = newResponse.GetResponseStream();
            StreamReader reader = new StreamReader(newStream);
            string outline = reader.ReadToEnd();
            return outline;
        }
    }
}
