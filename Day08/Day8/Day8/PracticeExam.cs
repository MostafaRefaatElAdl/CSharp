using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(int _duration, int _numberOfQuestions, Dictionary<Question, AnswerList> _questinAndAnswerList) : base(_duration, _numberOfQuestions, _questinAndAnswerList)
        {
        }

        public override string ToString()
        {
            string practiceExam = "";
            for (int i = 0; i < QuestinAnswerDictionary.Count; i++)
            {
                practiceExam += $"Q:{i+1} {QuestinAnswerDictionary.ElementAt(i).Key}\n" +
                                    $"==========================================\n"+
                                    $"And The correct answer is : ( {QuestinAnswerDictionary.ElementAt(i).Key.Answer?.ToString()} )\n" +
                                     $"And your answer is : ( {Userinput[i]?.ToLower().ToString()} )\n\n";
            }
            return $"{practiceExam}";
        }

    }
}
