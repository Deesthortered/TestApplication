using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Test_Application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string name;
        string n;
        XmlTextWriter writer;
        int number = 1;
        bool k = false;
        int Checked = 0;
        XmlDocument document = new XmlDocument();
        string check;
        

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tb_number_answers_TextChanged(object sender, EventArgs e)
        {
            AnswerEnable();
        }

        public void AnswerEnable()
        {
            switch (tb_number_answers.Text)
            {
                case "3":
                    {
                        tb_answer1.Enabled = true; cb_answer1.Enabled = true;
                        tb_answer2.Enabled = true; cb_answer2.Enabled = true;
                        tb_answer3.Enabled = true; cb_answer3.Enabled = true;
                        tb_answer4.Enabled = false; cb_answer4.Enabled = false;
                        tb_answer5.Enabled = false; cb_answer5.Enabled = false;
                        tb_answer6.Enabled = false; cb_answer6.Enabled = false;
                        tb_answer7.Enabled = false; cb_answer7.Enabled = false;
                        tb_answer8.Enabled = false; cb_answer8.Enabled = false;
                        tb_answer9.Enabled = false; cb_answer9.Enabled = false;
                    } break;
                case "4":
                    {
                        tb_answer1.Enabled = true; cb_answer1.Enabled = true;
                        tb_answer2.Enabled = true; cb_answer2.Enabled = true;
                        tb_answer3.Enabled = true; cb_answer3.Enabled = true;
                        tb_answer4.Enabled = true; cb_answer4.Enabled = true;
                        tb_answer5.Enabled = false; cb_answer5.Enabled = false;
                        tb_answer6.Enabled = false; cb_answer6.Enabled = false;
                        tb_answer7.Enabled = false; cb_answer7.Enabled = false;
                        tb_answer8.Enabled = false; cb_answer8.Enabled = false;
                        tb_answer9.Enabled = false; cb_answer9.Enabled = false;
                    } break;
                case "5":
                    {
                        tb_answer1.Enabled = true; cb_answer1.Enabled = true;
                        tb_answer2.Enabled = true; cb_answer2.Enabled = true;
                        tb_answer3.Enabled = true; cb_answer3.Enabled = true;
                        tb_answer4.Enabled = true; cb_answer4.Enabled = true;
                        tb_answer5.Enabled = true; cb_answer5.Enabled = true;
                        tb_answer6.Enabled = false; cb_answer6.Enabled = false;
                        tb_answer7.Enabled = false; cb_answer7.Enabled = false;
                        tb_answer8.Enabled = false; cb_answer8.Enabled = false;
                        tb_answer9.Enabled = false; cb_answer9.Enabled = false;
                    } break;
                case "6":
                    {
                        tb_answer1.Enabled = true; cb_answer1.Enabled = true;
                        tb_answer2.Enabled = true; cb_answer2.Enabled = true;
                        tb_answer3.Enabled = true; cb_answer3.Enabled = true;
                        tb_answer4.Enabled = true; cb_answer4.Enabled = true;
                        tb_answer5.Enabled = true; cb_answer5.Enabled = true;
                        tb_answer6.Enabled = true; cb_answer6.Enabled = true;
                        tb_answer7.Enabled = false; cb_answer7.Enabled = false;
                        tb_answer8.Enabled = false; cb_answer8.Enabled = false;
                        tb_answer9.Enabled = false; cb_answer9.Enabled = false;
                    } break;
                case "7":
                    {
                        tb_answer1.Enabled = true; cb_answer1.Enabled = true;
                        tb_answer2.Enabled = true; cb_answer2.Enabled = true;
                        tb_answer3.Enabled = true; cb_answer3.Enabled = true;
                        tb_answer4.Enabled = true; cb_answer4.Enabled = true;
                        tb_answer5.Enabled = true; cb_answer5.Enabled = true;
                        tb_answer6.Enabled = true; cb_answer6.Enabled = true;
                        tb_answer7.Enabled = true; cb_answer7.Enabled = true;
                        tb_answer8.Enabled = false; cb_answer8.Enabled = false;
                        tb_answer9.Enabled = false; cb_answer9.Enabled = false;
                    } break;
                case "8":
                    {
                        tb_answer1.Enabled = true; cb_answer1.Enabled = true;
                        tb_answer2.Enabled = true; cb_answer2.Enabled = true;
                        tb_answer3.Enabled = true; cb_answer3.Enabled = true;
                        tb_answer4.Enabled = true; cb_answer4.Enabled = true;
                        tb_answer5.Enabled = true; cb_answer5.Enabled = true;
                        tb_answer6.Enabled = true; cb_answer6.Enabled = true;
                        tb_answer7.Enabled = true; cb_answer7.Enabled = true;
                        tb_answer8.Enabled = true; cb_answer8.Enabled = true;
                        tb_answer9.Enabled = false; cb_answer9.Enabled = false;
                    } break;
                case "9":
                    {
                        tb_answer1.Enabled = true; cb_answer1.Enabled = true;
                        tb_answer2.Enabled = true; cb_answer2.Enabled = true;
                        tb_answer3.Enabled = true; cb_answer3.Enabled = true;
                        tb_answer4.Enabled = true; cb_answer4.Enabled = true;
                        tb_answer5.Enabled = true; cb_answer5.Enabled = true;
                        tb_answer6.Enabled = true; cb_answer6.Enabled = true;
                        tb_answer7.Enabled = true; cb_answer7.Enabled = true;
                        tb_answer8.Enabled = true; cb_answer8.Enabled = true;
                        tb_answer9.Enabled = true; cb_answer9.Enabled = true;
                    } break;
                default:
                    {
                        tb_answer1.Enabled = false; cb_answer1.Enabled = false;
                        tb_answer2.Enabled = false; cb_answer2.Enabled = false;
                        tb_answer3.Enabled = false; cb_answer3.Enabled = false;
                        tb_answer4.Enabled = false; cb_answer4.Enabled = false;
                        tb_answer5.Enabled = false; cb_answer5.Enabled = false;
                        tb_answer6.Enabled = false; cb_answer6.Enabled = false;
                        tb_answer7.Enabled = false; cb_answer7.Enabled = false;
                        tb_answer8.Enabled = false; cb_answer8.Enabled = false;
                        tb_answer9.Enabled = false; cb_answer9.Enabled = false;
                    } break;
            }
        }

        private void b_ok_name_Click(object sender, EventArgs e)
        {
            name = tb_name.Text;
            if (name != "")
            {
                do
                {
                    n = name.Remove(0, name.Length - 1);
                    if (n == " ")
                        name = name.Remove(name.Length - 1, 1);
                } while (n == " " && name.Length > 1);
            }

            if (name == "" || name == " ")
            {
                MessageBox.Show("Введите название для теста.", "Неверное название!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_name.Text = "";
            }
            else
            {
                tb_name.Text = name + ".xml";
                b_ok_name.Enabled = false;
                tb_name.ReadOnly = true;
                b_ok_number.Enabled = true;
                tb_max_number_answers.Enabled = true;
            }
        }

        private void b_ok_number_Click(object sender, EventArgs e)
        {
            name = tb_max_number_answers.Text;
            if (name == "")
                MessageBox.Show("Введите максимальное кол-во вопросов.", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                do
                {
                    n = name.Remove(1, name.Length - 1);
                    name = name.Remove(0, 1);
                    k = true;
                    if (!Char.IsDigit(Convert.ToChar(n)))
                    {
                        tb_max_number_answers.Text = "";
                        MessageBox.Show("Введите правильное число.", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        k = false;
                        break;
                    }
                } while (name.Length > 0);
                if (k)
                {
                    tb_max_number_answers.ReadOnly = true;
                    b_ok_number.Enabled = false;
                    tb_question.Enabled = true;
                    tb_number.Text = "1";
                    tb_number_answers.Enabled = true;
                    bt_end.Enabled = true;
                    bt_forward.Enabled = true;
                    if (number == Convert.ToInt32(tb_max_number_answers.Text))
                        bt_forward.Enabled = false;
                    else bt_end.Enabled = false;
                    writer = new XmlTextWriter(tb_name.Text, Encoding.UTF8);
                    writer.WriteStartDocument();
                    writer.WriteStartElement("test");
                    writer.WriteEndElement();
                    writer.Close();
                    document.Load(tb_name.Text);
                    XmlNode max_question = document.CreateElement("max_question");
                    max_question.InnerText = tb_max_number_answers.Text;
                    document.DocumentElement.AppendChild(max_question);
                    document.Save(tb_name.Text);
                }
            }
        }

        private void bt_forward_Click(object sender, EventArgs e)
        {
            ButtonFunction(false);
            if (number != Convert.ToInt32(tb_max_number_answers.Text))
                bt_end.Enabled = false;
            else bt_end.Enabled = true;
        }

        private void bt_end_Click(object sender, EventArgs e)
        {
            ButtonFunction(true);
        }

        public void ButtonFunction(bool b)
        {
            if (tb_question.Text == "")
                MessageBox.Show("Поле вопроса не заполнено! Введите ваш вопрос.", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tb_number_answers.Text != "3" && tb_number_answers.Text != "4" && tb_number_answers.Text != "5" && tb_number_answers.Text != "6" && tb_number_answers.Text != "7" && tb_number_answers.Text != "8" && tb_number_answers.Text != "9")
                MessageBox.Show("Введите количество возможных вопросов", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tb_answer1.Text == "" || tb_answer2.Text == "" || tb_answer3.Text == "" || (tb_answer4.Text == "" && tb_answer4.Enabled == true) || (tb_answer5.Text == "" && tb_answer5.Enabled == true) || (tb_answer6.Text == "" && tb_answer6.Enabled == true) || (tb_answer7.Text == "" && tb_answer7.Enabled == true) || (tb_answer8.Text == "" && tb_answer8.Enabled == true) || (tb_answer9.Text == "" && tb_answer9.Enabled == true))
                MessageBox.Show("Введите варианты ответов.", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cb_answer1.Checked == false && cb_answer2.Checked == false && cb_answer3.Checked == false && cb_answer4.Checked == false && cb_answer5.Checked == false && cb_answer6.Checked == false && cb_answer7.Checked == false && cb_answer8.Checked == false && cb_answer9.Checked == false)
                MessageBox.Show("Выберите правильные ответы.", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Checked = 0;
                if (cb_answer1.Checked == true) Checked++;
                if (cb_answer2.Checked == true) Checked++;
                if (cb_answer3.Checked == true) Checked++;
                if (cb_answer4.Checked == true) Checked++;
                if (cb_answer5.Checked == true) Checked++;
                if (cb_answer6.Checked == true) Checked++;
                if (cb_answer7.Checked == true) Checked++;
                if (cb_answer8.Checked == true) Checked++;
                if (cb_answer9.Checked == true) Checked++;
                CreatingXML();
                number++;
                tb_number.Text = Convert.ToString(number);
                check = "";
                tb_question.Text = "";
                tb_number_answers.Text = "";
                tb_answer1.Text = "";
                tb_answer2.Text = "";
                tb_answer3.Text = "";
                tb_answer4.Text = "";
                tb_answer5.Text = "";
                tb_answer6.Text = "";
                tb_answer7.Text = "";
                tb_answer8.Text = ""; 
                tb_answer9.Text = "";
                cb_answer1.Checked = false;
                cb_answer2.Checked = false;
                cb_answer3.Checked = false;
                cb_answer4.Checked = false;
                cb_answer5.Checked = false;
                cb_answer6.Checked = false;
                cb_answer7.Checked = false;
                cb_answer8.Checked = false;
                cb_answer9.Checked = false;
                if (b)
                {
                    MessageBox.Show("Тест успешно составлен и сохранен в файле "+tb_name.Text+".", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                if (number == Convert.ToInt32(tb_max_number_answers.Text))
                    bt_forward.Enabled = false;
            }
        }

        public void CreatingXML()
        {
            document.Load(tb_name.Text);
            XmlNode question_n = document.CreateElement("question" + Convert.ToString(number));
            document.DocumentElement.AppendChild(question_n);

            XmlNode question = document.CreateElement("question");
            question.InnerText = tb_question.Text;
            question_n.AppendChild(question);

            XmlNode answers = document.CreateElement("answers");
            answers.InnerText = tb_number_answers.Text;
            question_n.AppendChild(answers);

            XmlNode right_answers = document.CreateElement("right_answers");
            right_answers.InnerText = Convert.ToString(Checked);
            question_n.AppendChild(right_answers);

            XmlNode right = document.CreateElement("right");
            question_n.AppendChild(right);
            if (cb_answer1.Checked)
                check += "1";
            if (cb_answer2.Checked)
                check += "2";
            if (cb_answer3.Checked)
                check += "3";
            if (cb_answer4.Checked)
                check += "4";
            if (cb_answer5.Checked)
                check += "5";
            if (cb_answer6.Checked)
                check += "6";
            if (cb_answer7.Checked)
                check += "7";
            if (cb_answer8.Checked)
                check += "8";
            if (cb_answer9.Checked)
                check += "9";
            right.InnerText = check;

            if (tb_answer1.Text != "")
            {
                XmlNode answer1 = document.CreateElement("answer1");
                question_n.AppendChild(answer1);
                answer1.InnerText = tb_answer1.Text;
            }
            if (tb_answer2.Text != "")
            {
                XmlNode answer2 = document.CreateElement("answer2");
                question_n.AppendChild(answer2);
                answer2.InnerText = tb_answer2.Text;
            }
            if (tb_answer3.Text != "")
            {
                XmlNode answer3 = document.CreateElement("answer3");
                question_n.AppendChild(answer3);
                answer3.InnerText = tb_answer3.Text;
            }
            if (tb_answer4.Text != "")
            {
                XmlNode answer4 = document.CreateElement("answer4");
                question_n.AppendChild(answer4);
                answer4.InnerText = tb_answer4.Text;
            }
            if (tb_answer5.Text != "")
            {
                XmlNode answer5 = document.CreateElement("answer5");
                question_n.AppendChild(answer5);
                answer5.InnerText = tb_answer5.Text;
            }
            if (tb_answer6.Text != "")
            {
                XmlNode answer6 = document.CreateElement("answer6");
                question_n.AppendChild(answer6);
                answer6.InnerText = tb_answer6.Text;
            }
            if (tb_answer7.Text != "")
            {
                XmlNode answer7 = document.CreateElement("answer7");
                question_n.AppendChild(answer7);
                answer7.InnerText = tb_answer7.Text;
            }
            if (tb_answer8.Text != "")
            {
                XmlNode answer8 = document.CreateElement("answer8");
                question_n.AppendChild(answer8);
                answer8.InnerText = tb_answer8.Text;
            }
            if (tb_answer9.Text != "")
            {
                XmlNode answer9 = document.CreateElement("answer9");
                question_n.AppendChild(answer9);
                answer9.InnerText = tb_answer9.Text;
            }
            document.Save(tb_name.Text);
        }

    }
}
