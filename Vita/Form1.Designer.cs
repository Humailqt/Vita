namespace Vita
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
            this.name = new System.Windows.Forms.Label();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.boxLastName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CorrentUser_label = new System.Windows.Forms.Label();
            this.Corrent_user = new System.Windows.Forms.Label();
            this.lableFind = new System.Windows.Forms.Label();
            this.ButtomFind = new System.Windows.Forms.Button();
            this.boxFind = new System.Windows.Forms.TextBox();
            this.lable_Info = new System.Windows.Forms.Label();
            this.infoOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.name.Location = new System.Drawing.Point(57, 32);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Имя";
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(105, 34);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(100, 20);
            this.BoxName.TabIndex = 1;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lastName.Location = new System.Drawing.Point(12, 60);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(87, 20);
            this.lastName.TabIndex = 0;
            this.lastName.Text = "Фамилия";
            // 
            // boxLastName
            // 
            this.boxLastName.Location = new System.Drawing.Point(105, 60);
            this.boxLastName.Name = "boxLastName";
            this.boxLastName.Size = new System.Drawing.Size(100, 20);
            this.boxLastName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CorrentUser_label
            // 
            this.CorrentUser_label.AutoSize = true;
            this.CorrentUser_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CorrentUser_label.Location = new System.Drawing.Point(57, 224);
            this.CorrentUser_label.Name = "CorrentUser_label";
            this.CorrentUser_label.Size = new System.Drawing.Size(113, 20);
            this.CorrentUser_label.TabIndex = 3;
            this.CorrentUser_label.Text = "Текущий лох";
            // 
            // Corrent_user
            // 
            this.Corrent_user.AutoSize = true;
            this.Corrent_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Corrent_user.Location = new System.Drawing.Point(58, 270);
            this.Corrent_user.Name = "Corrent_user";
            this.Corrent_user.Size = new System.Drawing.Size(16, 17);
            this.Corrent_user.TabIndex = 4;
            this.Corrent_user.Text = " :";
            // 
            // lableFind
            // 
            this.lableFind.AutoSize = true;
            this.lableFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lableFind.Location = new System.Drawing.Point(349, 32);
            this.lableFind.Name = "lableFind";
            this.lableFind.Size = new System.Drawing.Size(60, 20);
            this.lableFind.TabIndex = 5;
            this.lableFind.Text = "Поиск";
            // 
            // ButtomFind
            // 
            this.ButtomFind.Location = new System.Drawing.Point(353, 86);
            this.ButtomFind.Name = "ButtomFind";
            this.ButtomFind.Size = new System.Drawing.Size(75, 23);
            this.ButtomFind.TabIndex = 6;
            this.ButtomFind.Text = "Найти";
            this.ButtomFind.UseVisualStyleBackColor = true;
            this.ButtomFind.Click += new System.EventHandler(this.ButtomFind_Click);
            // 
            // boxFind
            // 
            this.boxFind.Location = new System.Drawing.Point(353, 60);
            this.boxFind.Name = "boxFind";
            this.boxFind.Size = new System.Drawing.Size(100, 20);
            this.boxFind.TabIndex = 7;
            // 
            // lable_Info
            // 
            this.lable_Info.AutoSize = true;
            this.lable_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lable_Info.Location = new System.Drawing.Point(514, 32);
            this.lable_Info.Name = "lable_Info";
            this.lable_Info.Size = new System.Drawing.Size(48, 20);
            this.lable_Info.TabIndex = 8;
            this.lable_Info.Text = "INFO";
            // 
            // infoOut
            // 
            this.infoOut.AutoSize = true;
            this.infoOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.infoOut.Location = new System.Drawing.Point(518, 60);
            this.infoOut.Name = "infoOut";
            this.infoOut.Size = new System.Drawing.Size(31, 17);
            this.infoOut.TabIndex = 9;
            this.infoOut.Text = "info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoOut);
            this.Controls.Add(this.lable_Info);
            this.Controls.Add(this.boxFind);
            this.Controls.Add(this.ButtomFind);
            this.Controls.Add(this.lableFind);
            this.Controls.Add(this.Corrent_user);
            this.Controls.Add(this.CorrentUser_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox boxLastName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CorrentUser_label;
        private System.Windows.Forms.Label Corrent_user;
        private System.Windows.Forms.Label lableFind;
        private System.Windows.Forms.Button ButtomFind;
        private System.Windows.Forms.TextBox boxFind;
        private System.Windows.Forms.Label lable_Info;
        private System.Windows.Forms.Label infoOut;
    }
}

