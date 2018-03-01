using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Test_Application
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        bool testing = false;
        int number = 1;
        string element;
        string max_questions;
        string right_answers;
        string answers;
        bool[] complete;
        bool[] right_;
        StreamWriter strWriter;

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void b_load_file_Click(object sender, EventArgs e)
        {
            if (testing)
            {
                DialogResult result = MessageBox.Show("Выбрав новый тест вы потеряете данные текущего. Вы действительно хотите выбрать новый тестовый XML-файл?", "Внимание!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    testing = true;
                    file_dialog.ShowDialog();
                    tb_name.Text = file_dialog.FileName;
                    tb_number.Text = "1";
                    number = 1;
                    ReadingXML(-1);
                    ReadingXML(number);
                    bt_forward.Enabled = true;
                    bt_forward.Text = "Следующий вопрос.";
                    bt_back.Enabled = false;
                    complete = new bool[Convert.ToInt32(max_questions)];
                    right_ = new bool[Convert.ToInt32(max_questions)];
                    b_ok_answer.Enabled = true;
                }
            }
            else
            {
                testing = true;
                file_dialog.ShowDialog();
                tb_name.Text = file_dialog.FileName;
                if (tb_name.Text != "openFileDialog1")
                {
                    bt_forward.Enabled = true;
                    b_ok_answer.Enabled = true;
                    tb_number.Text = "1";
                    number = 1;
                    ReadingXML(number);
                    complete = new bool[Convert.ToInt32(max_questions)];
                    right_ = new bool[Convert.ToInt32(max_questions)];
                    b_ok_answer.Enabled = true;
                }
                else
                {
                    testing = false;
                    tb_name.Text = "";
                }
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            number -= 1;
            tb_number.Text = Convert.ToString(number);
            if (number == 1)
                bt_back.Enabled = false;
            bt_forward.Enabled = true;
            ReadingXML(number);
            bt_forward.Text = "Следующий вопрос.";
            if (complete[number - 1])
            {
                b_ok_answer.Enabled = false;
                cb_answer1.Enabled = false;
                cb_answer2.Enabled = false;
                cb_answer3.Enabled = false;
                cb_answer4.Enabled = false;
                cb_answer5.Enabled = false;
                cb_answer6.Enabled = false;
                cb_answer7.Enabled = false;
                cb_answer8.Enabled = false;
                cb_answer9.Enabled = false;
            }
            else b_ok_answer.Enabled = true;
        }

        private void bt_forward_Click(object sender, EventArgs e)
        {
            if (bt_forward.Text == "Следующий вопрос.")
            {
                number += 1;
                tb_number.Text = Convert.ToString(number);
                if (number == Convert.ToInt32(max_questions))
                {
                    bt_forward.Text = "Закончить тест!";
                    bt_forward.Enabled = false;
                }
                bt_back.Enabled = true;
                ReadingXML(number);
                if (complete[number - 1])
                {
                    b_ok_answer.Enabled = false;
                    cb_answer1.Enabled = false;
                    cb_answer2.Enabled = false;
                    cb_answer3.Enabled = false;
                    cb_answer4.Enabled = false;
                    cb_answer5.Enabled = false;
                    cb_answer6.Enabled = false;
                    cb_answer7.Enabled = false;
                    cb_answer8.Enabled = false;
                    cb_answer9.Enabled = false;
                }
                else b_ok_answer.Enabled = true;
                int compl = 0;
                for (int i = 0; i < Convert.ToInt32(max_questions); i++)
                    if (complete[i]) compl++;
                if (compl == Convert.ToInt32(max_questions))
                    bt_forward.Enabled = true;
            }
            else Result();
        }

        public void ReadingXML(int num)
        {
            XmlTextReader reader = new XmlTextReader(tb_name.Text);
            FormUpdate1();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        {
                            element = reader.Name;
                            if (element == "question" + Convert.ToString(num + 1))
                                break;
                        }
                        break;
                    case XmlNodeType.Text:
                        {
                            switch (element)
                            {
                                case "max_question": max_questions = reader.Value; break;
                                case "question": tb_question.Text = reader.Value; break;
                                case "answers": answers = reader.Value; break;
                                case "right_answers": tb_number_answers.Text = reader.Value; break;
                                case "right": right_answers = reader.Value; break;
                                case "answer1": tb_answer1.Text = reader.Value; break;
                                case "answer2": tb_answer2.Text = reader.Value; break;
                                case "answer3": tb_answer3.Text = reader.Value; break;
                                case "answer4": tb_answer4.Text = reader.Value; break;
                                case "answer5": tb_answer5.Text = reader.Value; break;
                                case "answer6": tb_answer6.Text = reader.Value; break;
                                case "answer7": tb_answer7.Text = reader.Value; break;
                                case "answer8": tb_answer8.Text = reader.Value; break;
                                case "answer9": tb_answer9.Text = reader.Value; break;
                            }
                        }
                        break;
                }
                if (element == "question" + Convert.ToString(num + 1))
                    break;
            }
            FormUpdate(answers);
            tb_number.Text = Convert.ToString(number) + "/" + max_questions;
        }

        public void FormUpdate(string _answers)
        {
            if (_answers == "1") cb_answer1.Enabled = true;
            if (_answers == "2")
            {
                cb_answer1.Enabled = true;
                cb_answer2.Enabled = true;
            }
            if (_answers == "3")
            {
                cb_answer1.Enabled = true;
                cb_answer2.Enabled = true;
                cb_answer3.Enabled = true;
            }
            if (_answers == "4")
            {
                cb_answer1.Enabled = true;
                cb_answer2.Enabled = true;
                cb_answer3.Enabled = true;
                cb_answer4.Enabled = true;
            }
            if (_answers == "5")
            {
                cb_answer1.Enabled = true;
                cb_answer2.Enabled = true;
                cb_answer3.Enabled = true;
                cb_answer4.Enabled = true;
                cb_answer5.Enabled = true;
            }
            if (_answers == "6")
            {
                cb_answer1.Enabled = true;
                cb_answer2.Enabled = true;
                cb_answer3.Enabled = true;
                cb_answer4.Enabled = true;
                cb_answer5.Enabled = true;
                cb_answer6.Enabled = true;
            }
            if (_answers == "7")
            {
                cb_answer1.Enabled = true;
                cb_answer2.Enabled = true;
                cb_answer3.Enabled = true;
                cb_answer4.Enabled = true;
                cb_answer5.Enabled = true;
                cb_answer6.Enabled = true;
                cb_answer7.Enabled = true;
            }
            if (_answers == "8")
            {
                cb_answer1.Enabled = true;
                cb_answer2.Enabled = true;
                cb_answer3.Enabled = true;
                cb_answer4.Enabled = true;
                cb_answer5.Enabled = true;
                cb_answer6.Enabled = true;
                cb_answer7.Enabled = true;
                cb_answer8.Enabled = true;
            }
            if (_answers == "9")
            {
                cb_answer1.Enabled = true;
                cb_answer2.Enabled = true;
                cb_answer3.Enabled = true;
                cb_answer4.Enabled = true;
                cb_answer5.Enabled = true;
                cb_answer6.Enabled = true;
                cb_answer7.Enabled = true;
                cb_answer8.Enabled = true;
                cb_answer9.Enabled = true;
            }

        }

        public void FormUpdate1()
        {
            cb_answer1.Enabled = false;
            cb_answer2.Enabled = false;
            cb_answer3.Enabled = false;
            cb_answer4.Enabled = false;
            cb_answer5.Enabled = false;
            cb_answer6.Enabled = false;
            cb_answer7.Enabled = false;
            cb_answer8.Enabled = false;
            cb_answer9.Enabled = false;

            cb_answer1.Checked = false;
            cb_answer2.Checked = false;
            cb_answer3.Checked = false;
            cb_answer4.Checked = false;
            cb_answer5.Checked = false;
            cb_answer6.Checked = false;
            cb_answer7.Checked = false;
            cb_answer8.Checked = false;

            tb_answer1.Text = "";
            tb_answer2.Text = "";
            tb_answer3.Text = "";
            tb_answer4.Text = "";
            tb_answer5.Text = "";
            tb_answer6.Text = "";
            tb_answer7.Text = "";
            tb_answer8.Text = "";
            tb_answer9.Text = "";
        }

        private void b_ok_answer_Click(object sender, EventArgs e)
        {
            int Checked = 0;
            if (cb_answer1.Checked) Checked++;
            if (cb_answer2.Checked) Checked++;
            if (cb_answer3.Checked) Checked++;
            if (cb_answer4.Checked) Checked++;
            if (cb_answer5.Checked) Checked++;
            if (cb_answer6.Checked) Checked++;
            if (cb_answer7.Checked) Checked++;
            if (cb_answer8.Checked) Checked++;
            if (cb_answer9.Checked) Checked++;
            if (Convert.ToInt32(tb_number_answers.Text) != Checked)
                MessageBox.Show("Выберите правильное количество ответов.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                complete[number - 1] = true;
                b_ok_answer.Enabled = false;
                cb_answer1.Enabled = false;
                cb_answer2.Enabled = false;
                cb_answer3.Enabled = false;
                cb_answer4.Enabled = false;
                cb_answer5.Enabled = false;
                cb_answer6.Enabled = false;
                cb_answer7.Enabled = false;
                cb_answer8.Enabled = false;
                cb_answer9.Enabled = false;
                char[] ch = new char[right_answers.Length];
                for (int i = 0; i < right_answers.Length; i++)
                    ch[i] = right_answers[i];
                bool right = true;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] == '1' && cb_answer1.Checked == false)
                        right = false;
                    if (ch[i] == '2' && cb_answer2.Checked == false)
                        right = false;
                    if (ch[i] == '3' && cb_answer3.Checked == false)
                        right = false;
                    if (ch[i] == '4' && cb_answer4.Checked == false)
                        right = false;
                    if (ch[i] == '5' && cb_answer5.Checked == false)
                        right = false;
                    if (ch[i] == '6' && cb_answer6.Checked == false)
                        right = false;
                    if (ch[i] == '7' && cb_answer7.Checked == false)
                        right = false;
                    if (ch[i] == '8' && cb_answer8.Checked == false)
                        right = false;
                    if (ch[i] == '9' && cb_answer9.Checked == false)
                        right = false;
                }
                right_[number - 1] = right;
                int compl = 0;
                for (int i = 0; i < complete.Length; i++)
                    if (complete[i]) compl++;
                if (compl == complete.Length)
                    bt_forward.Enabled = true;

            }
        }

        public void Result()
        {
            int r = 0;
            for (int i = 0; i < right_.Length; i++)
                if (right_[i]) r++;

            string str = tb_name.Text;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == '\\')
                   str =  str.Remove(0, i + 1);

            int proc = 0;
            proc = Convert.ToInt32((r+1)*100/Convert.ToInt32(max_questions));
            

            strWriter = new StreamWriter("results.txt", true);
            strWriter.WriteLine("Название теста: " + str);
            strWriter.WriteLine("Количество вопросов: " + max_questions);
            strWriter.WriteLine("Количество правильных ответов: " + Convert.ToString(r + 1));
            strWriter.WriteLine("Процент правильных :" + Convert.ToString(proc) + "%");

            strWriter.WriteLine();
            strWriter.WriteLine();
            strWriter.Close();
            MessageBox.Show("Данные о пройденом тесте успешно записаны в файл results.txt", "Тест окончен.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
