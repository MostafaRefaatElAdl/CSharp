using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class AnswerList: List<Answer>
    {

        public string[] GetAnswers() 
        {
            string[] answer = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                answer[i]= this[i].AnswerText;
            }
            return answer;
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < Count; i++) 
            {
                res+=$"{this[i]}\n";
            }
            return $"{res}";
        }
    }
}
