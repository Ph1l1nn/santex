namespace santex
{
    partial class userForm
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
            this.TaskData = new System.Windows.Forms.DataGridView();
            this.changeStatus = new System.Windows.Forms.ComboBox();
            this.change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaskData)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskData
            // 
            this.TaskData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskData.Location = new System.Drawing.Point(50, 12);
            this.TaskData.Name = "TaskData";
            this.TaskData.Size = new System.Drawing.Size(691, 241);
            this.TaskData.TabIndex = 0;
            // 
            // changeStatus
            // 
            this.changeStatus.FormattingEnabled = true;
            this.changeStatus.Items.AddRange(new object[] {
            "Ожидает",
            "Выполнено"});
            this.changeStatus.Location = new System.Drawing.Point(240, 295);
            this.changeStatus.Name = "changeStatus";
            this.changeStatus.Size = new System.Drawing.Size(121, 21);
            this.changeStatus.TabIndex = 1;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(440, 292);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 2;
            this.change.Text = "button1";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.change);
            this.Controls.Add(this.changeStatus);
            this.Controls.Add(this.TaskData);
            this.Name = "userForm";
            this.Text = "userForm";
            this.Load += new System.EventHandler(this.userForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TaskData;
        private System.Windows.Forms.ComboBox changeStatus;
        private System.Windows.Forms.Button change;
    }
}