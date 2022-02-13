using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal abstract class Question
    {
        string header;
        string body;
        int marks;

        Answer answer;

        public Question()
        {
            header = null;
            body = null;
            marks = 0;
        }

        public Question(string _header, string _body, int _marks, Answer _answer)
        {
            Header = _header;
            Body = _body;
            Marks = _marks;
            answer = _answer;
        }

        public string Header
        {
            get { return header; }
            set { header = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        internal Answer Answer { get => answer; set => answer = value; }

        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType()) return false;

            if (object.ReferenceEquals(this, obj)) return true;

            Question other = obj as Question;

            if (other == null) return false;

            return body == other.body && header == other.header && marks == other.marks;
        }

        public override string ToString()
        {
            return $"{body} ({header}) / Mark : ({marks})";
        }

    }
}
