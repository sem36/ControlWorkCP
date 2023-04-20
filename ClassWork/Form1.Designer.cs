namespace ClassWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namebox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.TextBox();
            this.BookBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AvarageBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(139, 10);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(154, 27);
            this.namebox.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(139, 43);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(154, 27);
            this.groupBox.TabIndex = 1;
            // 
            // BookBox
            // 
            this.BookBox.Location = new System.Drawing.Point(139, 76);
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(154, 27);
            this.BookBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ф.И.О.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер группы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер зачётки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Средний балл";
            // 
            // AvarageBox
            // 
            this.AvarageBox.Location = new System.Drawing.Point(139, 120);
            this.AvarageBox.Name = "AvarageBox";
            this.AvarageBox.Size = new System.Drawing.Size(154, 27);
            this.AvarageBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(357, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 164);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 10;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(12, 226);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(280, 29);
            this.delBtn.TabIndex = 12;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(12, 191);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(281, 29);
            this.UploadBtn.TabIndex = 13;
            this.UploadBtn.Text = "Обновить";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AvarageBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.namebox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox namebox;
        private TextBox groupBox;
        private TextBox BookBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AvarageBox;
        private Button button1;
        private ListBox listBox1;
        private Label label5;
        private Button delBtn;
        private Button UploadBtn;
    }
}