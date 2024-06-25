namespace santex
{
    partial class adminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.price = new System.Windows.Forms.TextBox();
            this.task = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.RichTextBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.TaskData = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.UserData = new System.Windows.Forms.DataGridView();
            this.addUser = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TaskData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(152, 365);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 1;
            // 
            // task
            // 
            this.task.Location = new System.Drawing.Point(17, 365);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(100, 20);
            this.task.TabIndex = 2;
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(17, 80);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(201, 169);
            this.comment.TabIndex = 3;
            this.comment.Text = "";
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Ожидание",
            "Выполнено"});
            this.Status.Location = new System.Drawing.Point(294, 363);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(121, 21);
            this.Status.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(458, 365);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // TaskData
            // 
            this.TaskData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskData.Location = new System.Drawing.Point(241, 17);
            this.TaskData.Name = "TaskData";
            this.TaskData.Size = new System.Drawing.Size(509, 331);
            this.TaskData.TabIndex = 6;
            this.TaskData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskData_CellContentClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(6, 17);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 7;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 426);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.del);
            this.tabPage2.Controls.Add(this.UserData);
            this.tabPage2.Controls.Add(this.addUser);
            this.tabPage2.Controls.Add(this.role);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Controls.Add(this.pass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(237, 339);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 5;
            this.del.Text = "удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // UserData
            // 
            this.UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserData.Location = new System.Drawing.Point(53, 39);
            this.UserData.Name = "UserData";
            this.UserData.Size = new System.Drawing.Size(662, 189);
            this.UserData.TabIndex = 4;
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(53, 339);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 23);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "button1";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.role.Location = new System.Drawing.Point(375, 261);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(121, 21);
            this.role.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(53, 261);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(199, 261);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Add);
            this.tabPage1.Controls.Add(this.TaskData);
            this.tabPage1.Controls.Add(this.Status);
            this.tabPage1.Controls.Add(this.Back);
            this.tabPage1.Controls.Add(this.price);
            this.tabPage1.Controls.Add(this.task);
            this.tabPage1.Controls.Add(this.comment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.RichTextBox comment;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView TaskData;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.DataGridView UserData;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}