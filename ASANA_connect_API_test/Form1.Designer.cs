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
            this.inTextbox = new System.Windows.Forms.TextBox();
            this.RunRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inTextbox
            // 
            this.inTextbox.Location = new System.Drawing.Point(60, 38);
            this.inTextbox.Multiline = true;
            this.inTextbox.Name = "inTextbox";
            this.inTextbox.Size = new System.Drawing.Size(702, 146);
            this.inTextbox.TabIndex = 0;
            this.inTextbox.TextChanged += new System.EventHandler(this.ConnectionText_TextChanged);
            // 
            // RunRequest
            // 
            this.RunRequest.Location = new System.Drawing.Point(60, 201);
            this.RunRequest.Name = "RunRequest";
            this.RunRequest.Size = new System.Drawing.Size(159, 37);
            this.RunRequest.TabIndex = 1;
            this.RunRequest.Text = "Выполнить ";
            this.RunRequest.UseVisualStyleBackColor = true;
            this.RunRequest.Click += new System.EventHandler(this.buttonToAsanaCreate_Click);
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
            // outTextBox
            // 
            this.outTextBox.Location = new System.Drawing.Point(60, 267);
            this.outTextBox.Multiline = true;
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.Size = new System.Drawing.Size(702, 159);
            this.outTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат отработки запроса";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(153, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 13);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunRequest);
            this.Controls.Add(this.inTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inTextbox;
        private System.Windows.Forms.Button RunRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUser;
    }
}

