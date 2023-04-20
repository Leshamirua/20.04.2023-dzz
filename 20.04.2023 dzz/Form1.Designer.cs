namespace _20._04._2023_dzz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TaskManeger = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.TaskManeger);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 461);
            this.panel1.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.StartButton.Location = new System.Drawing.Point(492, 23);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(111, 45);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.RefreshButton.Location = new System.Drawing.Point(33, 404);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(111, 45);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.CloseButton.Location = new System.Drawing.Point(492, 404);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(111, 45);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TaskManeger
            // 
            this.TaskManeger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.TaskManeger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.TaskManeger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TaskManeger.HideSelection = false;
            this.TaskManeger.Location = new System.Drawing.Point(33, 74);
            this.TaskManeger.Name = "TaskManeger";
            this.TaskManeger.Size = new System.Drawing.Size(570, 324);
            this.TaskManeger.TabIndex = 1;
            this.TaskManeger.UseCompatibleStateImageBehavior = false;
            this.TaskManeger.View = System.Windows.Forms.View.Details;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(33, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(453, 22);
            this.textBox2.TabIndex = 2;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RAM";
            this.columnHeader3.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView TaskManeger;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button StartButton;
    }
}

