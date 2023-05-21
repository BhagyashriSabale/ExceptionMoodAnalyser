using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMoodAnalyser
{
    internal class MoodAnlayserException: Exception
    {
        public MoodAnalysisError Error { get; set; }

        public MoodAnlayserException(MoodAnalysisError error, string message) : base(message)
        {
            Error = error;
        }
    }
}
