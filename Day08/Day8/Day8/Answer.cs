using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Answer
    {
        string answerText;
        public Answer(string _answerText)
        {
            AnswerText = _answerText;
        }

        public string AnswerText { get { return answerText; } set { answerText = value; } }

        public override string ToString()
        {
            return $"{answerText}";
        }
    }
}
