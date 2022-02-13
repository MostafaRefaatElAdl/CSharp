using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class ChooseAll : Question
    {
        public ChooseAll(string _body, int _marks, string _answer)
        {
            Answer = new Answer(_answer);
            Header = "Choose All right answers seprated by (,)";
            Marks= _marks;
            Body = _body;
        }

    }
}
