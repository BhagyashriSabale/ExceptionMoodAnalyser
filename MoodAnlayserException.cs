using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMoodAnalyser
{
    internal class MoodAnlayserException: Exception
    {
        public MoodAnlayserException(string message): base(message)
        { }
    }
}
