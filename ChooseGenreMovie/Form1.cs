using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChooseGenreMovie
{
    public partial class Form1 : Form
    {
        private const string DEFAULT = "Пока нет открытого теста";
        private string desc;
        private int count;
        private List<RadioButton> answersRB;

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
            answersRB = new List<RadioButton>();

            desc = DEFAULT;
            l_Desc.Text = desc;
            count = 0;
        }

        private void b_Test_Click(object sender, EventArgs e)
        {
            if(controller.Questions != null) 
            {
                p_Test.Visible = true;
                ShowQuestion(count);
            }
            else
                MessageBox.Show("Подключите файл с тестом!","Внимание");
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            exitFromTest();
        }

        private void b_Settings_Click(object sender, EventArgs e)
        {
            controller.OpenTest();
            if (controller.Desc != null) 
            {
                desc = controller.Desc;
                l_Desc.Text = desc;
            }
        }

        private void b_Further_Click(object sender, EventArgs e)
        {
            if (answersRB.Count == count)
                SaveAnswer();
            else if (count < answersRB.Count)
            {
                UpdateAnswer();
            }

            if (count == controller.Questions.Count - 1)
            {
                gb_Desc.Visible = false;
                p_Result.Visible = true;
                l_Result.Text = $"На сегодняшний вечер, мы вам предлагаем выбрать жанр кино:\n {controller.GetResult()}";
            }
            else 
            {
                count++;
                ShowQuestion(count);
            }
        }

        private void SaveAnswer() 
        {
            if (radioButton1.Checked)
            {
                SaveScore(radioButton1);
            }
            else if (radioButton2.Checked)
            {
                SaveScore(radioButton2);
            }
            else if (radioButton3.Checked)
            {
                SaveScore(radioButton3);
            }
            else if (radioButton4.Checked)
            {
                SaveScore(radioButton4);
            }
            else if (radioButton5.Checked)
            {
                SaveScore(radioButton5);
            }

            void SaveScore(RadioButton rb)
            {
                answersRB.Add(rb);
                if (takeScore(rb.Text).Length == 1)
                    controller.Result[takeScore(rb.Text)[0]]++;
                else
                    for (int i = 0; i < takeScore(rb.Text).Length; i++)
                        controller.Result[takeScore(rb.Text)[i]]++;
            }
        }

        private void UpdateAnswer() 
        {
            if (radioButton1.Checked)
            {
                UpdateScore(radioButton1);
            }
            else if (radioButton2.Checked)
            {
                UpdateScore(radioButton2);
            }
            else if (radioButton3.Checked)
            {
                UpdateScore(radioButton3);
            }
            else if (radioButton4.Checked)
            {
                UpdateScore(radioButton4);
            }
            else if (radioButton5.Checked)
            {
                UpdateScore(radioButton5);
            }

            void UpdateScore(RadioButton rb) 
            {
                if (!rb.Text.Equals(answersRB[count].Text)) 
                {
                    if (takeScore(rb.Text).Length == 1)
                    {
                        controller.Result[takeScore(rb.Text)[0]]++;
                        controller.Result[takeScore(answersRB[count].Text)[0]]--;
                    }
                    else 
                    {
                        for (int i = 0; i < takeScore(rb.Text).Length; i++) 
                        {
                            controller.Result[takeScore(rb.Text)[i]]++;
                        }
                        for (int i = 0; i < takeScore(answersRB[count].Text).Length; i++) 
                        {
                            controller.Result[takeScore(answersRB[count].Text)[i]]--;
                        }
                    }

                    answersRB[count] = rb;
                }
            }
        }

        private void b_Back_Click(object sender, EventArgs e)
        {
            if (answersRB.Count == count)
                SaveAnswer();
            else if (count < answersRB.Count) 
            {
                UpdateAnswer();
            }

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
            radioButton1.Text = parseAnswer(answers[0]);
            if (idx == answersRB.Count || answersRB.Count == 0)
                radioButton1.Checked = true;
            else
                answersRB[idx].Checked = true;
            radioButton2.Text = parseAnswer(answers[1]);
            gb_Desc.Text = $"{count+1} вопрос из {controller.Questions.Count}";
            switch (answers.Length) 
            {
                case 2:
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    break;
                case 3:
                    if (!radioButton3.Visible)
                        radioButton3.Visible = !radioButton3.Visible;
                    if (radioButton4.Visible)
                        radioButton4.Visible = !radioButton4.Visible;
                    if (radioButton5.Visible)
                        radioButton5.Visible = !radioButton5.Visible;

                    radioButton3.Text = parseAnswer(answers[2]);
                    break;
                case 4:
                    if (!radioButton3.Visible)
                        radioButton3.Visible = !radioButton3.Visible;
                    if (!radioButton4.Visible)
                        radioButton4.Visible = !radioButton4.Visible;
                    if (radioButton5.Visible)
                        radioButton5.Visible = !radioButton5.Visible;

                    radioButton3.Text = parseAnswer(answers[2]);
                    radioButton4.Text = parseAnswer(answers[3]);
                    break;
                case 5:
                    if (!radioButton3.Visible)
                        radioButton3.Visible = !radioButton3.Visible;
                    if (!radioButton4.Visible)
                        radioButton4.Visible = !radioButton4.Visible;
                    if (!radioButton5.Visible)
                        radioButton5.Visible = !radioButton5.Visible;
                    radioButton3.Text = parseAnswer(answers[2]);
                    radioButton4.Text = parseAnswer(answers[3]);
                    radioButton5.Text = parseAnswer(answers[4]);
                    break;
            }
        }

        private string parseAnswer(string answer) 
        {
            string score = answer.Substring(answer.IndexOf("_") + 1);
            return answer.Replace("_"+score, "");
        }

        private int[] takeScore(string answer) 
        {
            var q = controller.Questions.Values.ToArray();
            var answ = q[count];

            for (int i = 0; i < answ.Count; i++) 
            {
                if (answ[i].Contains(answer))
                {
                    answer = answ[i];
                    break;
                }
            }
            
            string score = answer.Substring(answer.IndexOf("_") + 1);
            string[] values = score.Split(',');
            int[] scoreInt = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
                scoreInt[i] = Int32.Parse(values[i]);
            return scoreInt;
        }

        private void b_End_Click(object sender, EventArgs e)
        {
            exitFromTest();
        }

        private void exitFromTest() 
        {
            //if (!radioButton1.Visible)
            //    radioButton1.Visible = !radioButton1.Visible;
            //if (!radioButton2.Visible)
            //    radioButton2.Visible = !radioButton2.Visible;
            //if (!radioButton3.Visible)
            //    radioButton3.Visible = !radioButton3.Visible;
            //if (!radioButton4.Visible)
            //    radioButton4.Visible = !radioButton4.Visible;
            //if (!radioButton5.Visible)
            //    radioButton5.Visible = !radioButton5.Visible;
            gb_Desc.Visible = true;
            p_Result.Visible = false;
            p_Test.Visible = false;
            p_MainMenu.Visible = true;
            answersRB.Clear();
            count = 0;
            controller.Reset();
        }
    }
}