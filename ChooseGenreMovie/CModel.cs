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

        public Dictionary<string, int> genre;
        public Dictionary<string, List<string>> questions;
        public int[] result;

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
                    int id = -1;
                    while (line != null)
                    {
                        id = (int) Char.GetNumericValue(line[line.Length-1]);
                        line = line.Substring(0, line.Length - 1);
                        genre.Add(line, id);
                        line = reader.ReadLine();
                    }
                    result = new int[genre.Count];
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
            int idMax = -1;
            for (int i = 0; i < result.Length; i++) 
            {
                if (max < result[i]) 
                {
                    max = result[i];
                    idMax = i;
                }
                else if (max == result[i]) 
                {
                    //TO DO: Сделать рандомныую выдачу при одинаковом кол-ве баллов разных жанров
                }
            }
            return genre.Where(x => x.Value == idMax).FirstOrDefault().Key;
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
                                    answers.Add(reader.ReadLine());
                                
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

        public void Reset() 
        {
            result = new int[genre.Count];
        }
    }
}
