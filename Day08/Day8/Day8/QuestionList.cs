using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day8
{
    class QuestionList : List<Question>
    {
        string[] questionArray = null;

        public string[] QuestionArray { get => questionArray; set => questionArray = value; }

        public string[] toArrayOfStrings()
        {
            QuestionArray = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                QuestionArray[i] = this[i].ToString();
            }
            return QuestionArray;
        }

        public void save()
        {
            
            string createText = "Test" + Environment.NewLine;
            File.WriteAllLines("../../../QuestionsList.txt", toArrayOfStrings());

        }
    }
}
