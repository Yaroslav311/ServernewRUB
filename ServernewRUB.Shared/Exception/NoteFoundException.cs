using System;
using System.Collections.Generic;
using System.Text;

namespace ServernewRUB.Shared.Exception
{
    public class NoteFoundException : System.Exception
    {
        public NoteFoundException(string message)  : base(message)
        {
            
        }
    }
}
