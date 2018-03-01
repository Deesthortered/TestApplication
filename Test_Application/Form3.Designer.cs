namespace Test_Application
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_number_answers = new System.Windows.Forms.TextBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_forward = new System.Windows.Forms.Button();
            this.cb_answer9 = new System.Windows.Forms.CheckBox();
            this.cb_answer8 = new System.Windows.Forms.CheckBox();
            this.cb_answer7 = new System.Windows.Forms.CheckBox();
            this.cb_answer6 = new System.Windows.Forms.CheckBox();
            this.cb_answer5 = new System.Windows.Forms.CheckBox();
            this.cb_answer4 = new System.Windows.Forms.CheckBox();
            this.cb_answer3 = new System.Windows.Forms.CheckBox();
            this.cb_answer2 = new System.Windows.Forms.CheckBox();
            this.cb_answer1 = new System.Windows.Forms.CheckBox();
            this.tb_answer9 = new System.Windows.Forms.TextBox();
            this.tb_answer8 = new System.Windows.Forms.TextBox();
            this.tb_answer7 = new System.Windows.Forms.TextBox();
            this.tb_answer6 = new System.Windows.Forms.TextBox();
            this.tb_answer5 = new System.Windows.Forms.TextBox();
            this.tb_answer4 = new System.Windows.Forms.TextBox();
            this.tb_answer3 = new System.Windows.Forms.TextBox();
            this.tb_answer2 = new System.Windows.Forms.TextBox();
            this.tb_answer1 = new System.Windows.Forms.TextBox();
            this.b_load_file = new System.Windows.Forms.Button();
            this.file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.b_ok_answer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прохождение тестов.";
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(80, 63);
            this.tb_number.Name = "tb_number";
            this.tb_number.ReadOnly = true;
            this.tb_number.Size = new System.Drawing.Size(509, 20);
            this.tb_number.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Номер:";
            // 
            // tb_question
            // 
            this.tb_question.Location = new System.Drawing.Point(80, 89);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.Size = new System.Drawing.Size(509, 101);
            this.tb_question.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Вопрос:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(80, 39);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(509, 20);
            this.tb_name.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Количество правильных ответов:";
            // 
            // tb_number_answers
            // 
            this.tb_number_answers.Location = new System.Drawing.Point(259, 193);
            this.tb_number_answers.MaxLength = 1;
            this.tb_number_answers.Name = "tb_number_answers";
            this.tb_number_answers.ReadOnly = true;
            this.tb_number_answers.Size = new System.Drawing.Size(20, 20);
            this.tb_number_answers.TabIndex = 40;
            // 
            // bt_back
            // 
            this.bt_back.Enabled = false;
            this.bt_back.Location = new System.Drawing.Point(12, 344);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(288, 37);
            this.bt_back.TabIndex = 65;
            this.bt_back.Text = "Предыдущий вопрос";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_forward
            // 
            this.bt_forward.Enabled = false;
            this.bt_forward.Location = new System.Drawing.Point(306, 344);
            this.bt_forward.Name = "bt_forward";
            this.bt_forward.Size = new System.Drawing.Size(283, 37);
            this.bt_forward.TabIndex = 63;
            this.bt_forward.Text = "Следующий вопрос.";
            this.bt_forward.UseVisualStyleBackColor = true;
            this.bt_forward.Click += new System.EventHandler(this.bt_forward_Click);
            // 
            // cb_answer9
            // 
            this.cb_answer9.AutoSize = true;
            this.cb_answer9.Enabled = false;
            this.cb_answer9.Location = new System.Drawing.Point(407, 308);
            this.cb_answer9.Name = "cb_answer9";
            this.cb_answer9.Size = new System.Drawing.Size(15, 14);
            this.cb_answer9.TabIndex = 62;
            this.cb_answer9.UseVisualStyleBackColor = true;
            // 
            // cb_answer8
            // 
            this.cb_answer8.AutoSize = true;
            this.cb_answer8.Enabled = false;
            this.cb_answer8.Location = new System.Drawing.Point(407, 268);
            this.cb_answer8.Name = "cb_answer8";
            this.cb_answer8.Size = new System.Drawing.Size(15, 14);
            this.cb_answer8.TabIndex = 61;
            this.cb_answer8.UseVisualStyleBackColor = true;
            // 
            // cb_answer7
            // 
            this.cb_answer7.AutoSize = true;
            this.cb_answer7.Enabled = false;
            this.cb_answer7.Location = new System.Drawing.Point(407, 229);
            this.cb_answer7.Name = "cb_answer7";
            this.cb_answer7.Size = new System.Drawing.Size(15, 14);
            this.cb_answer7.TabIndex = 60;
            this.cb_answer7.UseVisualStyleBackColor = true;
            // 
            // cb_answer6
            // 
            this.cb_answer6.AutoSize = true;
            this.cb_answer6.Enabled = false;
            this.cb_answer6.Location = new System.Drawing.Point(212, 308);
            this.cb_answer6.Name = "cb_answer6";
            this.cb_answer6.Size = new System.Drawing.Size(15, 14);
            this.cb_answer6.TabIndex = 59;
            this.cb_answer6.UseVisualStyleBackColor = true;
            // 
            // cb_answer5
            // 
            this.cb_answer5.AutoSize = true;
            this.cb_answer5.Enabled = false;
            this.cb_answer5.Location = new System.Drawing.Point(212, 268);
            this.cb_answer5.Name = "cb_answer5";
            this.cb_answer5.Size = new System.Drawing.Size(15, 14);
            this.cb_answer5.TabIndex = 58;
            this.cb_answer5.UseVisualStyleBackColor = true;
            // 
            // cb_answer4
            // 
            this.cb_answer4.AutoSize = true;
            this.cb_answer4.Enabled = false;
            this.cb_answer4.Location = new System.Drawing.Point(212, 229);
            this.cb_answer4.Name = "cb_answer4";
            this.cb_answer4.Size = new System.Drawing.Size(15, 14);
            this.cb_answer4.TabIndex = 57;
            this.cb_answer4.UseVisualStyleBackColor = true;
            // 
            // cb_answer3
            // 
            this.cb_answer3.AutoSize = true;
            this.cb_answer3.Enabled = false;
            this.cb_answer3.Location = new System.Drawing.Point(18, 308);
            this.cb_answer3.Name = "cb_answer3";
            this.cb_answer3.Size = new System.Drawing.Size(15, 14);
            this.cb_answer3.TabIndex = 56;
            this.cb_answer3.UseVisualStyleBackColor = true;
            // 
            // cb_answer2
            // 
            this.cb_answer2.AutoSize = true;
            this.cb_answer2.Enabled = false;
            this.cb_answer2.Location = new System.Drawing.Point(18, 268);
            this.cb_answer2.Name = "cb_answer2";
            this.cb_answer2.Size = new System.Drawing.Size(15, 14);
            this.cb_answer2.TabIndex = 55;
            this.cb_answer2.UseVisualStyleBackColor = true;
            // 
            // cb_answer1
            // 
            this.cb_answer1.AutoSize = true;
            this.cb_answer1.Enabled = false;
            this.cb_answer1.Location = new System.Drawing.Point(18, 229);
            this.cb_answer1.Name = "cb_answer1";
            this.cb_answer1.Size = new System.Drawing.Size(15, 14);
            this.cb_answer1.TabIndex = 54;
            this.cb_answer1.UseVisualStyleBackColor = true;
            // 
            // tb_answer9
            // 
            this.tb_answer9.Location = new System.Drawing.Point(428, 305);
            this.tb_answer9.Name = "tb_answer9";
            this.tb_answer9.ReadOnly = true;
            this.tb_answer9.Size = new System.Drawing.Size(100, 20);
            this.tb_answer9.TabIndex = 53;
            // 
            // tb_answer8
            // 
            this.tb_answer8.Location = new System.Drawing.Point(428, 265);
            this.tb_answer8.Name = "tb_answer8";
            this.tb_answer8.ReadOnly = true;
            this.tb_answer8.Size = new System.Drawing.Size(100, 20);
            this.tb_answer8.TabIndex = 52;
            // 
            // tb_answer7
            // 
            this.tb_answer7.Location = new System.Drawing.Point(428, 226);
            this.tb_answer7.Name = "tb_answer7";
            this.tb_answer7.ReadOnly = true;
            this.tb_answer7.Size = new System.Drawing.Size(100, 20);
            this.tb_answer7.TabIndex = 51;
            // 
            // tb_answer6
            // 
            this.tb_answer6.Location = new System.Drawing.Point(233, 305);
            this.tb_answer6.Name = "tb_answer6";
            this.tb_answer6.ReadOnly = true;
            this.tb_answer6.Size = new System.Drawing.Size(100, 20);
            this.tb_answer6.TabIndex = 50;
            // 
            // tb_answer5
            // 
            this.tb_answer5.Location = new System.Drawing.Point(233, 265);
            this.tb_answer5.Name = "tb_answer5";
            this.tb_answer5.ReadOnly = true;
            this.tb_answer5.Size = new System.Drawing.Size(100, 20);
            this.tb_answer5.TabIndex = 49;
            // 
            // tb_answer4
            // 
            this.tb_answer4.Location = new System.Drawing.Point(233, 226);
            this.tb_answer4.Name = "tb_answer4";
            this.tb_answer4.ReadOnly = true;
            this.tb_answer4.Size = new System.Drawing.Size(100, 20);
            this.tb_answer4.TabIndex = 48;
            // 
            // tb_answer3
            // 
            this.tb_answer3.Location = new System.Drawing.Point(39, 305);
            this.tb_answer3.Name = "tb_answer3";
            this.tb_answer3.ReadOnly = true;
            this.tb_answer3.Size = new System.Drawing.Size(100, 20);
            this.tb_answer3.TabIndex = 47;
            // 
            // tb_answer2
            // 
            this.tb_answer2.Location = new System.Drawing.Point(39, 265);
            this.tb_answer2.Name = "tb_answer2";
            this.tb_answer2.ReadOnly = true;
            this.tb_answer2.Size = new System.Drawing.Size(100, 20);
            this.tb_answer2.TabIndex = 46;
            // 
            // tb_answer1
            // 
            this.tb_answer1.Location = new System.Drawing.Point(39, 226);
            this.tb_answer1.Name = "tb_answer1";
            this.tb_answer1.ReadOnly = true;
            this.tb_answer1.Size = new System.Drawing.Size(100, 20);
            this.tb_answer1.TabIndex = 45;
            // 
            // b_load_file
            // 
            this.b_load_file.Location = new System.Drawing.Point(144, 9);
            this.b_load_file.Name = "b_load_file";
            this.b_load_file.Size = new System.Drawing.Size(445, 23);
            this.b_load_file.TabIndex = 66;
            this.b_load_file.Text = "Загрузить XML-файл тестового задания";
            this.b_load_file.UseVisualStyleBackColor = true;
            this.b_load_file.Click += new System.EventHandler(this.b_load_file_Click);
            // 
            // file_dialog
            // 
            this.file_dialog.FileName = "openFileDialog1";
            this.file_dialog.Filter = "\"XML файлы (*.xml)|*.xml|Все файлы (*.*)|*.*\"";
            // 
            // b_ok_answer
            // 
            this.b_ok_answer.Enabled = false;
            this.b_ok_answer.Location = new System.Drawing.Point(534, 226);
            this.b_ok_answer.Name = "b_ok_answer";
            this.b_ok_answer.Size = new System.Drawing.Size(55, 99);
            this.b_ok_answer.TabIndex = 67;
            this.b_ok_answer.Text = "OK";
            this.b_ok_answer.UseVisualStyleBackColor = true;
            this.b_ok_answer.Click += new System.EventHandler(this.b_ok_answer_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 393);
            this.Controls.Add(this.b_ok_answer);
            this.Controls.Add(this.b_load_file);
            this.Controls.Add(this.bt_back);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Test Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_number_answers;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_forward;
        private System.Windows.Forms.CheckBox cb_answer9;
        private System.Windows.Forms.CheckBox cb_answer8;
        private System.Windows.Forms.CheckBox cb_answer7;
        private System.Windows.Forms.CheckBox cb_answer6;
        private System.Windows.Forms.CheckBox cb_answer5;
        private System.Windows.Forms.CheckBox cb_answer4;
        private System.Windows.Forms.CheckBox cb_answer3;
        private System.Windows.Forms.CheckBox cb_answer2;
        private System.Windows.Forms.CheckBox cb_answer1;
        private System.Windows.Forms.TextBox tb_answer9;
        private System.Windows.Forms.TextBox tb_answer8;
        private System.Windows.Forms.TextBox tb_answer7;
        private System.Windows.Forms.TextBox tb_answer6;
        private System.Windows.Forms.TextBox tb_answer5;
        private System.Windows.Forms.TextBox tb_answer4;
        private System.Windows.Forms.TextBox tb_answer3;
        private System.Windows.Forms.TextBox tb_answer2;
        private System.Windows.Forms.TextBox tb_answer1;
        private System.Windows.Forms.Button b_load_file;
        private System.Windows.Forms.OpenFileDialog file_dialog;
        private System.Windows.Forms.Button b_ok_answer;
    }
}