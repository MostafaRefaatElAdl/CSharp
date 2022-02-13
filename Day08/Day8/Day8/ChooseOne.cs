using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class ChooseOne : Question
    {

        public ChooseOne(string _body, int _marks, string _answer)
        {
            Answer = new Answer(_answer) ;
            Header = "Choose the right answer";
            Marks = _marks;
            Body = _body;
        }

    }
}
