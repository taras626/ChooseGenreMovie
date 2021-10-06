using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChooseGenreMovie
{
    class CModel
    {
        private string filePathForGenre = "C:\\Users\\user\\Desktop\\Проекты\\ChooseGenreMovie\\genres.txt";

        public Dictionary<string, List<string>> questions;
        public Dictionary<string, int> genre;
        public string desc;

        public CModel()
        {
            genre = TakeGenre();
        }

        private Dictionary<string, int> TakeGenre() 
        {
            Dictionary<string, int> genre = new Dictionary<string, int>();
            try
            {
                using (StreamReader reader = new StreamReader(filePathForGenre))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        genre.Add(line, 0);
                        line = reader.ReadLine();
                    }
                    return genre;
                }
            }
            catch (IOException) 
            {
                MessageBox.Show("Файл с жанрами не найден!", "Ошибка");
                Application.Exit();
                return null;
            }
        }

        public string GetResult() 
        {
            int max = 0;
            foreach (KeyValuePair<string, int> p in genre)
                if (p.Value > max)
                    max = p.Value;
            return genre.FirstOrDefault(x => x.Value.Equals(max)).Key;
        }

        public void OpenTest() 
        {
            //Формат теста:
            // *Строка с вопросом*?*Число ответов*
            // Пример: Вы мужчина?2
            // Да
            // Нет
            //TO DO: Продумать механику работы теста, а точнее обработку ответов
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "txt files (*.txt)|*.txt";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    string filePath = file.FileName;
                    desc = $"Открыт тест: {filePath}";

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        questions = new Dictionary<string, List<string>>();

                        string question;
                        List<string> answers;

                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            if (line.Contains("?"))
                            {
                                int countOfQ = Convert.ToInt32(line.Substring(line.Length - 1));
                                question = line.Substring(0, line.Length - 1);
                                answers = new List<string>();

                                for (int i = 0; i < countOfQ; i++)
                                {
                                    answers.Add(reader.ReadLine());
                                }
                                questions.Add(question, answers);
                            }

                            line = reader.ReadLine();
                        }
                    }
                }
            }
        }

        public void GetQuestion(int idx, out string question, out string[] answers)
        {
            var item = questions.ElementAt(idx);
            question = item.Key;
            answers = item.Value.ToArray();
        }
    }
}
