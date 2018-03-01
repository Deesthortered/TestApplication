namespace Test_Application
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_number_answers = new System.Windows.Forms.TextBox();
            this.tb_answer1 = new System.Windows.Forms.TextBox();
            this.tb_answer2 = new System.Windows.Forms.TextBox();
            this.tb_answer3 = new System.Windows.Forms.TextBox();
            this.tb_answer6 = new System.Windows.Forms.TextBox();
            this.tb_answer5 = new System.Windows.Forms.TextBox();
            this.tb_answer4 = new System.Windows.Forms.TextBox();
            this.tb_answer9 = new System.Windows.Forms.TextBox();
            this.tb_answer8 = new System.Windows.Forms.TextBox();
            this.tb_answer7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_answer1 = new System.Windows.Forms.CheckBox();
            this.cb_answer2 = new System.Windows.Forms.CheckBox();
            this.cb_answer3 = new System.Windows.Forms.CheckBox();
            this.cb_answer4 = new System.Windows.Forms.CheckBox();
            this.cb_answer5 = new System.Windows.Forms.CheckBox();
            this.cb_answer6 = new System.Windows.Forms.CheckBox();
            this.cb_answer7 = new System.Windows.Forms.CheckBox();
            this.cb_answer8 = new System.Windows.Forms.CheckBox();
            this.cb_answer9 = new System.Windows.Forms.CheckBox();
            this.bt_forward = new System.Windows.Forms.Button();
            this.bt_end = new System.Windows.Forms.Button();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.b_ok_name = new System.Windows.Forms.Button();
            this.tb_max_number_answers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b_ok_number = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание тестов.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(78, 34);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(428, 20);
            this.tb_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вопрос:";
            // 
            // tb_question
            // 
            this.tb_question.Enabled = false;
            this.tb_question.Location = new System.Drawing.Point(78, 84);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(509, 101);
            this.tb_question.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество возможных ответов(3-9):";
            // 
            // tb_number_answers
            // 
            this.tb_number_answers.Enabled = false;
            this.tb_number_answers.Location = new System.Drawing.Point(281, 191);
            this.tb_number_answers.MaxLength = 1;
            this.tb_number_answers.Name = "tb_number_answers";
            this.tb_number_answers.Size = new System.Drawing.Size(20, 20);
            this.tb_number_answers.TabIndex = 6;
            this.tb_number_answers.TextChanged += new System.EventHandler(this.tb_number_answers_TextChanged);
            // 
            // tb_answer1
            // 
            this.tb_answer1.Enabled = false;
            this.tb_answer1.Location = new System.Drawing.Point(98, 221);
            this.tb_answer1.Name = "tb_answer1";
            this.tb_answer1.Size = new System.Drawing.Size(100, 20);
            this.tb_answer1.TabIndex = 10;
            // 
            // tb_answer2
            // 
            this.tb_answer2.Enabled = false;
            this.tb_answer2.Location = new System.Drawing.Point(98, 260);
            this.tb_answer2.Name = "tb_answer2";
            this.tb_answer2.Size = new System.Drawing.Size(100, 20);
            this.tb_answer2.TabIndex = 12;
            // 
            // tb_answer3
            // 
            this.tb_answer3.Enabled = false;
            this.tb_answer3.Location = new System.Drawing.Point(98, 300);
            this.tb_answer3.Name = "tb_answer3";
            this.tb_answer3.Size = new System.Drawing.Size(100, 20);
            this.tb_answer3.TabIndex = 14;
            // 
            // tb_answer6
            // 
            this.tb_answer6.Enabled = false;
            this.tb_answer6.Location = new System.Drawing.Point(292, 300);
            this.tb_answer6.Name = "tb_answer6";
            this.tb_answer6.Size = new System.Drawing.Size(100, 20);
            this.tb_answer6.TabIndex = 20;
            // 
            // tb_answer5
            // 
            this.tb_answer5.Enabled = false;
            this.tb_answer5.Location = new System.Drawing.Point(292, 260);
            this.tb_answer5.Name = "tb_answer5";
            this.tb_answer5.Size = new System.Drawing.Size(100, 20);
            this.tb_answer5.TabIndex = 18;
            // 
            // tb_answer4
            // 
            this.tb_answer4.Enabled = false;
            this.tb_answer4.Location = new System.Drawing.Point(292, 221);
            this.tb_answer4.Name = "tb_answer4";
            this.tb_answer4.Size = new System.Drawing.Size(100, 20);
            this.tb_answer4.TabIndex = 16;
            // 
            // tb_answer9
            // 
            this.tb_answer9.Enabled = false;
            this.tb_answer9.Location = new System.Drawing.Point(487, 300);
            this.tb_answer9.Name = "tb_answer9";
            this.tb_answer9.Size = new System.Drawing.Size(100, 20);
            this.tb_answer9.TabIndex = 29;
            // 
            // tb_answer8
            // 
            this.tb_answer8.Enabled = false;
            this.tb_answer8.Location = new System.Drawing.Point(487, 260);
            this.tb_answer8.Name = "tb_answer8";
            this.tb_answer8.Size = new System.Drawing.Size(100, 20);
            this.tb_answer8.TabIndex = 27;
            // 
            // tb_answer7
            // 
            this.tb_answer7.Enabled = false;
            this.tb_answer7.Location = new System.Drawing.Point(487, 221);
            this.tb_answer7.Name = "tb_answer7";
            this.tb_answer7.Size = new System.Drawing.Size(100, 20);
            this.tb_answer7.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Номер:";
            // 
            // cb_answer1
            // 
            this.cb_answer1.AutoSize = true;
            this.cb_answer1.Enabled = false;
            this.cb_answer1.Location = new System.Drawing.Point(77, 224);
            this.cb_answer1.Name = "cb_answer1";
            this.cb_answer1.Size = new System.Drawing.Size(15, 14);
            this.cb_answer1.TabIndex = 33;
            this.cb_answer1.UseVisualStyleBackColor = true;
            // 
            // cb_answer2
            // 
            this.cb_answer2.AutoSize = true;
            this.cb_answer2.Enabled = false;
            this.cb_answer2.Location = new System.Drawing.Point(77, 263);
            this.cb_answer2.Name = "cb_answer2";
            this.cb_answer2.Size = new System.Drawing.Size(15, 14);
            this.cb_answer2.TabIndex = 34;
            this.cb_answer2.UseVisualStyleBackColor = true;
            // 
            // cb_answer3
            // 
            this.cb_answer3.AutoSize = true;
            this.cb_answer3.Enabled = false;
            this.cb_answer3.Location = new System.Drawing.Point(77, 303);
            this.cb_answer3.Name = "cb_answer3";
            this.cb_answer3.Size = new System.Drawing.Size(15, 14);
            this.cb_answer3.TabIndex = 35;
            this.cb_answer3.UseVisualStyleBackColor = true;
            // 
            // cb_answer4
            // 
            this.cb_answer4.AutoSize = true;
            this.cb_answer4.Enabled = false;
            this.cb_answer4.Location = new System.Drawing.Point(271, 224);
            this.cb_answer4.Name = "cb_answer4";
            this.cb_answer4.Size = new System.Drawing.Size(15, 14);
            this.cb_answer4.TabIndex = 36;
            this.cb_answer4.UseVisualStyleBackColor = true;
            // 
            // cb_answer5
            // 
            this.cb_answer5.AutoSize = true;
            this.cb_answer5.Enabled = false;
            this.cb_answer5.Location = new System.Drawing.Point(271, 263);
            this.cb_answer5.Name = "cb_answer5";
            this.cb_answer5.Size = new System.Drawing.Size(15, 14);
            this.cb_answer5.TabIndex = 37;
            this.cb_answer5.UseVisualStyleBackColor = true;
            // 
            // cb_answer6
            // 
            this.cb_answer6.AutoSize = true;
            this.cb_answer6.Enabled = false;
            this.cb_answer6.Location = new System.Drawing.Point(271, 303);
            this.cb_answer6.Name = "cb_answer6";
            this.cb_answer6.Size = new System.Drawing.Size(15, 14);
            this.cb_answer6.TabIndex = 38;
            this.cb_answer6.UseVisualStyleBackColor = true;
            // 
            // cb_answer7
            // 
            this.cb_answer7.AutoSize = true;
            this.cb_answer7.Enabled = false;
            this.cb_answer7.Location = new System.Drawing.Point(466, 224);
            this.cb_answer7.Name = "cb_answer7";
            this.cb_answer7.Size = new System.Drawing.Size(15, 14);
            this.cb_answer7.TabIndex = 39;
            this.cb_answer7.UseVisualStyleBackColor = true;
            // 
            // cb_answer8
            // 
            this.cb_answer8.AutoSize = true;
            this.cb_answer8.Enabled = false;
            this.cb_answer8.Location = new System.Drawing.Point(466, 263);
            this.cb_answer8.Name = "cb_answer8";
            this.cb_answer8.Size = new System.Drawing.Size(15, 14);
            this.cb_answer8.TabIndex = 40;
            this.cb_answer8.UseVisualStyleBackColor = true;
            // 
            // cb_answer9
            // 
            this.cb_answer9.AutoSize = true;
            this.cb_answer9.Enabled = false;
            this.cb_answer9.Location = new System.Drawing.Point(466, 303);
            this.cb_answer9.Name = "cb_answer9";
            this.cb_answer9.Size = new System.Drawing.Size(15, 14);
            this.cb_answer9.TabIndex = 41;
            this.cb_answer9.UseVisualStyleBackColor = true;
            // 
            // bt_forward
            // 
            this.bt_forward.Enabled = false;
            this.bt_forward.Location = new System.Drawing.Point(15, 335);
            this.bt_forward.Name = "bt_forward";
            this.bt_forward.Size = new System.Drawing.Size(286, 37);
            this.bt_forward.TabIndex = 42;
            this.bt_forward.Text = "Следующий вопрос";
            this.bt_forward.UseVisualStyleBackColor = true;
            this.bt_forward.Click += new System.EventHandler(this.bt_forward_Click);
            // 
            // bt_end
            // 
            this.bt_end.Enabled = false;
            this.bt_end.Location = new System.Drawing.Point(307, 335);
            this.bt_end.Name = "bt_end";
            this.bt_end.Size = new System.Drawing.Size(291, 37);
            this.bt_end.TabIndex = 43;
            this.bt_end.Text = "Закончить тест!";
            this.bt_end.UseVisualStyleBackColor = true;
            this.bt_end.Click += new System.EventHandler(this.bt_end_Click);
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(78, 58);
            this.tb_number.Name = "tb_number";
            this.tb_number.ReadOnly = true;
            this.tb_number.Size = new System.Drawing.Size(197, 20);
            this.tb_number.TabIndex = 32;
            // 
            // b_ok_name
            // 
            this.b_ok_name.Location = new System.Drawing.Point(512, 32);
            this.b_ok_name.Name = "b_ok_name";
            this.b_ok_name.Size = new System.Drawing.Size(75, 23);
            this.b_ok_name.TabIndex = 45;
            this.b_ok_name.Text = "OK";
            this.b_ok_name.UseVisualStyleBackColor = true;
            this.b_ok_name.Click += new System.EventHandler(this.b_ok_name_Click);
            // 
            // tb_max_number_answers
            // 
            this.tb_max_number_answers.Enabled = false;
            this.tb_max_number_answers.Location = new System.Drawing.Point(406, 58);
            this.tb_max_number_answers.MaxLength = 3;
            this.tb_max_number_answers.Name = "tb_max_number_answers";
            this.tb_max_number_answers.Size = new System.Drawing.Size(100, 20);
            this.tb_max_number_answers.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Макс. кол-во вопросов: ";
            // 
            // b_ok_number
            // 
            this.b_ok_number.Enabled = false;
            this.b_ok_number.Location = new System.Drawing.Point(512, 56);
            this.b_ok_number.Name = "b_ok_number";
            this.b_ok_number.Size = new System.Drawing.Size(75, 23);
            this.b_ok_number.TabIndex = 48;
            this.b_ok_number.Text = "OK";
            this.b_ok_number.UseVisualStyleBackColor = true;
            this.b_ok_number.Click += new System.EventHandler(this.b_ok_number_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 384);
            this.Controls.Add(this.b_ok_number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_max_number_answers);
            this.Controls.Add(this.b_ok_name);
            this.Controls.Add(this.bt_end);
            this.Controls.Add(this.bt_forward);
            this.Controls.Add(this.cb_answer9);
            this.Controls.Add(this.cb_answer8);
            this.Controls.Add(this.cb_answer7);
            this.Controls.Add(this.cb_answer6);
            this.Controls.Add(this.cb_answer5);
            this.Controls.Add(this.cb_answer4);
            this.Controls.Add(this.cb_answer3);
            this.Controls.Add(this.cb_answer2);
            this.Controls.Add(this.cb_answer1);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_answer9);
            this.Controls.Add(this.tb_answer8);
            this.Controls.Add(this.tb_answer7);
            this.Controls.Add(this.tb_answer6);
            this.Controls.Add(this.tb_answer5);
            this.Controls.Add(this.tb_answer4);
            this.Controls.Add(this.tb_answer3);
            this.Controls.Add(this.tb_answer2);
            this.Controls.Add(this.tb_answer1);
            this.Controls.Add(this.tb_number_answers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Test Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_number_answers;
        private System.Windows.Forms.TextBox tb_answer1;
        private System.Windows.Forms.TextBox tb_answer2;
        private System.Windows.Forms.TextBox tb_answer3;
        private System.Windows.Forms.TextBox tb_answer6;
        private System.Windows.Forms.TextBox tb_answer5;
        private System.Windows.Forms.TextBox tb_answer4;
        private System.Windows.Forms.TextBox tb_answer9;
        private System.Windows.Forms.TextBox tb_answer8;
        private System.Windows.Forms.TextBox tb_answer7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cb_answer1;
        private System.Windows.Forms.CheckBox cb_answer2;
        private System.Windows.Forms.CheckBox cb_answer3;
        private System.Windows.Forms.CheckBox cb_answer4;
        private System.Windows.Forms.CheckBox cb_answer5;
        private System.Windows.Forms.CheckBox cb_answer6;
        private System.Windows.Forms.CheckBox cb_answer7;
        private System.Windows.Forms.CheckBox cb_answer8;
        private System.Windows.Forms.CheckBox cb_answer9;
        private System.Windows.Forms.Button bt_forward;
        private System.Windows.Forms.Button bt_end;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Button b_ok_name;
        private System.Windows.Forms.TextBox tb_max_number_answers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_ok_number;
    }
}