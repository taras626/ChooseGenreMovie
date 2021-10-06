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
        public Dictionary<string, List<string>> questions;
        public string desc;

        public CController()
        {
            model = new CModel();
        }

        /// <summary>
        /// Открывает текстовый файл с тестом
        /// </summary>
        public void OpenTest() 
        {
            model.OpenTest();
            UpdateData();
        }

        public void GetQuestion(int idx, out string question, out string[] answers)
        {
            model.GetQuestion(idx, out question, out answers);
        }

        public string GetResult() 
        {
            return model.GetResult();
        }

        private void UpdateData() 
        {
            questions = model.questions;
            desc = model.desc;
        }
    }
}