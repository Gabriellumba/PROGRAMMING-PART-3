namespace WinFormsApp1
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
            label1 = new Label();
            tabMain = new TabControl();
            tabChat = new TabPage();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
<<<<<<< HEAD
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
=======
            button2 = new Button();
            textBox1 = new TextBox();
            tabTask = new TabPage();
            tabQuiz = new TabPage();
            tabLog = new TabPage();
            tabMain.SuspendLayout();
            tabChat.SuspendLayout();
>>>>>>> Re-design of the form1 of the chat bot
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
<<<<<<< HEAD
            button2.Location = new Point(567, 334);
            button2.Name = "button2";
            button2.Size = new Size(101, 37);
            button2.TabIndex = 1;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(28, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 140);
            pictureBox1.TabIndex = 2;
=======
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(318, 24);
            label1.Name = "label1";
            label1.Size = new Size(170, 17);
            label1.TabIndex = 4;
            label1.Text = "CYBERSECURITY CHAT BOT";
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabChat);
            tabMain.Controls.Add(tabTask);
            tabMain.Controls.Add(tabQuiz);
            tabMain.Controls.Add(tabLog);
            tabMain.Location = new Point(5, 44);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(795, 422);
            tabMain.TabIndex = 7;
            // 
            // tabChat
            // 
            tabChat.Controls.Add(label2);
            tabChat.Controls.Add(pictureBox1);
            tabChat.Controls.Add(button1);
            tabChat.Controls.Add(button2);
            tabChat.Controls.Add(textBox1);
            tabChat.Location = new Point(4, 24);
            tabChat.Name = "tabChat";
            tabChat.Padding = new Padding(3);
            tabChat.Size = new Size(787, 394);
            tabChat.TabIndex = 0;
            tabChat.Text = "Chat";
            tabChat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(184, 32);
            label2.Name = "label2";
            label2.Size = new Size(522, 178);
            label2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 140);
            pictureBox1.TabIndex = 9;
>>>>>>> Re-design of the form1 of the chat bot
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
<<<<<<< HEAD
            button1.Location = new Point(114, 334);
            button1.Name = "button1";
            button1.Size = new Size(101, 37);
            button1.TabIndex = 3;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 24);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 4;
            label1.Text = "CYBERSECURITY CHAT BOT";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 202);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 57);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 68);
            label2.Name = "label2";
            label2.Size = new Size(375, 131);
            label2.TabIndex = 6;
=======
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(153, 325);
            button1.Name = "button1";
            button1.Size = new Size(101, 37);
            button1.TabIndex = 8;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(581, 325);
            button2.Name = "button2";
            button2.Size = new Size(101, 37);
            button2.TabIndex = 7;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(223, 243);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 57);
            textBox1.TabIndex = 6;
            // 
            // tabTask
            // 
            tabTask.Location = new Point(4, 24);
            tabTask.Name = "tabTask";
            tabTask.Padding = new Padding(3);
            tabTask.Size = new Size(787, 426);
            tabTask.TabIndex = 1;
            tabTask.Text = "Task Assisstant";
            tabTask.UseVisualStyleBackColor = true;
            // 
            // tabQuiz
            // 
            tabQuiz.Location = new Point(4, 24);
            tabQuiz.Name = "tabQuiz";
            tabQuiz.Size = new Size(787, 426);
            tabQuiz.TabIndex = 2;
            tabQuiz.Text = "Quiz";
            tabQuiz.UseVisualStyleBackColor = true;
            // 
            // tabLog
            // 
            tabLog.Location = new Point(4, 24);
            tabLog.Name = "tabLog";
            tabLog.Size = new Size(787, 426);
            tabLog.TabIndex = 3;
            tabLog.Text = "Activity Log";
            tabLog.UseVisualStyleBackColor = true;
>>>>>>> Re-design of the form1 of the chat bot
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
<<<<<<< HEAD
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
=======
            ClientSize = new Size(800, 478);
            Controls.Add(tabMain);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
>>>>>>> Re-design of the form1 of the chat bot
            Name = "Form1";
            Text = "                          ";
            Load += Form1_Load;
            tabMain.ResumeLayout(false);
            tabChat.ResumeLayout(false);
            tabChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TabControl tabMain;
        private TabPage tabChat;
        private TabPage tabTask;
        private TabPage tabQuiz;
        private TabPage tabLog;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
<<<<<<< HEAD
        private Label label1;
        private TextBox textBox1;
        private Label label2;
=======
        private Button button2;
        private TextBox textBox1;
>>>>>>> Re-design of the form1 of the chat bot
    }
}
