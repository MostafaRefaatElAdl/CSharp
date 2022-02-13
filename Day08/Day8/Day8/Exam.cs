using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Exam
    {

        int duration, numberOfQuestions;
        Dictionary<Question, AnswerList> questionAndAnswerList = new Dictionary<Question, AnswerList>();
        Subject subject;
        string[] userinput;


        public Exam(int _duration, int _numberOfQuestions, Dictionary<Question, AnswerList> _questinAndAnswerList)
        {
            duration = _duration;
            numberOfQuestions = _numberOfQuestions;
            questionAndAnswerList = _questinAndAnswerList;
            userinput = new string[numberOfQuestions];
        }
        // public string ConcerningTheExam { get; set; }
        public int Duration { set { duration = value; } get { return duration; } }
        public int NumberOfQuestion { set { numberOfQuestions = value; } get { return numberOfQuestions; } }
        public Subject Subject { set { subject = value; } get { return subject; } }
        public Dictionary<Question, AnswerList> QuestinAnswerDictionary
        {
            set { questionAndAnswerList = value; }
            get { return questionAndAnswerList; }
        }

        public string[] Userinput { get => userinput; set => userinput = value; }

        public virtual void ShowExam() {
            for (int i = 0; i < QuestinAnswerDictionary.Count; i++)
            {
                Console.WriteLine(QuestinAnswerDictionary.ElementAt(i).Key);
                Console.WriteLine("==========================================");
                Console.WriteLine(QuestinAnswerDictionary.ElementAt(i).Value);
                Console.Write("Enter you answer please : ");
                userinput[i] = Console.ReadLine();
                Console.WriteLine();
            }

        }
        public virtual double Correction()
        {
            string[] SortedArray = new string[userinput.Length];
            string[] userSeperate;
            double SumMarks = 0.0;
            for (int i = 0; i < QuestinAnswerDictionary.Count; i++)
            {
                if (userinput[i].Length > 1) 
                {
                    userSeperate = userinput[i].Split(",");
                    Array.Sort(userSeperate);
                    SortedArray[i] = string.Join(",", userSeperate);
                }
                if (userinput[i]?.ToLower() == QuestinAnswerDictionary.ElementAt(i).Key.Answer?.ToString() 
                    || SortedArray[i] == QuestinAnswerDictionary.ElementAt(i).Key.Answer?.ToString()
                    )
                    SumMarks += QuestinAnswerDictionary.ElementAt(i).Key.Marks;
            }
            return SumMarks;
        }

    }
}
