using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class TrueAndFalse : Question
    {

        public TrueAndFalse(string _body, int _marks, string _answer)
        {
            Answer = new Answer(_answer);
            Header = "Choose True Or False (Enter T or F)";
            Marks = _marks;
            Body = _body;
        }
    }
}
