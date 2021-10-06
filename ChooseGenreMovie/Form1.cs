using System;
using System.Linq;
using System.Windows.Forms;

namespace ChooseGenreMovie
{
    public partial class Form1 : Form
    {
        private const string DEFAULT = "Пока нет открытого теста";
        private string desc;
        private int count;
        private string result = "Комедия";

        private CController controller;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p_Test.Visible = false;
            p_Result.Visible = false;
            p_MainMenu.Visible = true;

            controller = new CController();
            desc = DEFAULT;
            l_Desc.Text = desc;
            count = 0;
        }

        private void b_Test_Click(object sender, EventArgs e)
        {
            if(controller.questions != null) 
            {
                p_Test.Visible = true;
                ShowQuestion(count);
            }
            else
                MessageBox.Show("Подключите файл с тестом!","Внимание");
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            p_Test.Visible = false;
            p_MainMenu.Visible = true;
        }

        private void b_Settings_Click(object sender, EventArgs e)
        {
            controller.OpenTest();
            if (controller.desc != null) 
            {
                desc = controller.desc;
                l_Desc.Text = desc;
            }
        }

        private void b_Further_Click(object sender, EventArgs e)
        {
            if (count == controller.questions.Count - 1)
            {
                p_Result.Visible = true;
                gb_Desc.Visible = false;
                l_Result.Text = $"На сегодняшний вечер, мы вам предлагаем выбрать жанр кино:\n {result}";
            }
            else 
            {
                count++;
                ShowQuestion(count);
            }
        }

        private void b_Back_Click(object sender, EventArgs e)
        {
            count--;
            if (count < 0)
            {
                b_Exit_Click(null, new EventArgs());
                count = 0;
            }
            else
                ShowQuestion(count);
        }

        private void ShowQuestion(int idx) 
        {
            string question;
            string[] answers;
            controller.GetQuestion(idx, out question, out answers);
            l_TextOfQuestion.Text = question.Length > 48 ? $"{question.Substring(0, 48)}\n{question.Substring(48)}" : question;
            radioButton1.Text = answers[0];
            radioButton1.Checked = true;
            radioButton2.Text = answers[1];
            gb_Desc.Text = $"{count+1} вопрос из {controller.questions.Count}";
            switch (answers.Length) 
            {
                case 2:
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    break;
                case 3:
                    if (!radioButton3.Visible)
                        radioButton3.Visible = !radioButton3.Visible;
                    if (radioButton4.Visible)
                        radioButton4.Visible = !radioButton4.Visible;

                    radioButton3.Text = answers[2];
                    break;
                case 4:
                    if (!radioButton3.Visible)
                        radioButton3.Visible = !radioButton3.Visible;
                    if (!radioButton4.Visible)
                        radioButton4.Visible = !radioButton4.Visible;

                    radioButton3.Text = answers[2];
                    radioButton4.Text = answers[3];
                    break;
            }
        }

        private void b_End_Click(object sender, EventArgs e)
        {
            p_Test.Visible = false;
            p_Result.Visible = false;
            p_MainMenu.Visible = true;
        }
    }
}