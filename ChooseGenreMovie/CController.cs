using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChooseGenreMovie
{
    class CController
    {
        private CModel model;
        public Dictionary<string, List<string>> Questions { get { return model.questions; } private set { value = model.questions; } }
        public string Desc { get { return model.desc; } private set { value = model.desc; } }
        public int[] Result { get { return model.result; } set { value = model.result; } }

        public CController()
        {
            model = new CModel();
            Result = model.result;
        }

        /// <summary>
        /// Открывает текстовый файл с тестом
        /// </summary>
        public void OpenTest() 
        {
            model.OpenTest();
        }

        public void GetQuestion(int idx, out string question, out string[] answers)
        {
            model.GetQuestion(idx, out question, out answers);
        }

        public string GetResult() 
        {
            return model.GetResult();
        }

        public void Reset() 
        {
            model.Reset();
        }
    }
}