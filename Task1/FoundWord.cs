using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class FoundWord
    {
        public string Word { get; set; }
        public int StartPosition { get; set; }
        public int EndPosition { get; set; }
        public FoundWord(string Word,int StartPosition,int EndPosition)
        {
            this.Word = Word;
            this.StartPosition = StartPosition;
            this.EndPosition = EndPosition;
        }
    }
}
