namespace ASANA_connect_API_test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.followers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxNotDone = new System.Windows.Forms.CheckBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.comboBoxWs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пользователь: ";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(152, 13);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(13, 13);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "email:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(322, 13);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(13, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Workspace:";
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Location = new System.Drawing.Point(544, 13);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(13, 13);
            this.labelProject.TabIndex = 7;
            this.labelProject.Text = "..";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.taskName,
            this.assignee,
            this.followers,
            this.doDate,
            this.completed,
            this.project,
            this.comment});
            this.dataGridView1.Location = new System.Drawing.Point(60, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(999, 362);
            this.dataGridView1.TabIndex = 8;
            // 
            // number
            // 
            this.number.HeaderText = "№";
            this.number.Name = "number";
            // 
            // taskName
            // 
            this.taskName.HeaderText = "Задача";
            this.taskName.Name = "taskName";
            // 
            // assignee
            // 
            this.assignee.HeaderText = "Исполнитель";
            this.assignee.Name = "assignee";
            // 
            // followers
            // 
            this.followers.HeaderText = "Подписчики";
            this.followers.Name = "followers";
            // 
            // doDate
            // 
            this.doDate.HeaderText = "Дата готовности";
            this.doDate.Name = "doDate";
            // 
            // completed
            // 
            this.completed.HeaderText = "Готово";
            this.completed.Name = "completed";
            // 
            // project
            // 
            this.project.HeaderText = "Проект";
            this.project.Name = "project";
            // 
            // comment
            // 
            this.comment.HeaderText = "Комментарий";
            this.comment.Name = "comment";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(547, 64);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(221, 21);
            this.comboBoxUser.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выбор исполнителя";
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(301, 64);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(222, 21);
            this.comboBoxProject.TabIndex = 11;
            this.comboBoxProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxProject_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Выбор проекта";
            // 
            // checkBoxNotDone
            // 
            this.checkBoxNotDone.AutoSize = true;
            this.checkBoxNotDone.Checked = true;
            this.checkBoxNotDone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNotDone.Location = new System.Drawing.Point(840, 64);
            this.checkBoxNotDone.Name = "checkBoxNotDone";
            this.checkBoxNotDone.Size = new System.Drawing.Size(145, 17);
            this.checkBoxNotDone.TabIndex = 13;
            this.checkBoxNotDone.Text = "Только незаконченные";
            this.checkBoxNotDone.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxNotDone.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(60, 117);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(221, 26);
            this.buttonRun.TabIndex = 14;
            this.buttonRun.Text = "Найти задачи";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(301, 119);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(739, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 16;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(60, 563);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(256, 23);
            this.buttonAddTask.TabIndex = 17;
            this.buttonAddTask.Text = "Добавить задачу";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // comboBoxWs
            // 
            this.comboBoxWs.FormattingEnabled = true;
            this.comboBoxWs.Location = new System.Drawing.Point(63, 64);
            this.comboBoxWs.Name = "comboBoxWs";
            this.comboBoxWs.Size = new System.Drawing.Size(211, 21);
            this.comboBoxWs.TabIndex = 18;
            this.comboBoxWs.SelectedIndexChanged += new System.EventHandler(this.comboBoxWs_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Выбор Workspace";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 598);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxWs);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.checkBoxNotDone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxNotDone;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignee;
        private System.Windows.Forms.DataGridViewTextBoxColumn followers;
        private System.Windows.Forms.DataGridViewTextBoxColumn doDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.ComboBox comboBoxWs;
        private System.Windows.Forms.Label label7;
    }
}

