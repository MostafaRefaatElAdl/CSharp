using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class FinalExam : Exam
    {
        public FinalExam(int _duration, int _numberOfQuestions, Dictionary<Question, AnswerList> _questinAndAnswerList) : base(_duration, _numberOfQuestions, _questinAndAnswerList)
        {
        }

    }
}
