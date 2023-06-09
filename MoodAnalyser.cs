﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMoodAnalyser
{
    
    internal class MoodAnalyser
    {
        private string message;
        public MoodAnalyser()
        {
            message = "";
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public void SetMessage(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {

            try
            {
                if (message == null)
                {
                    throw new MoodAnlayserException(MoodAnalysisError.NULL_MOOD, "Invalid mood. Message cannot be null.");
                }
                else if (string.IsNullOrWhiteSpace(message))
                {
                    throw new MoodAnlayserException(MoodAnalysisError.EMPTY_MOOD, "Invalid mood. Message cannot be empty or whitespace.");
                }
                else if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                {
                    return "Sad Mood";
                }
                else if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
                {
                    return "Happy Mood";
                }
                else
                {
                    throw new MoodAnlayserException(MoodAnalysisError.INVALID_MOOD, "Unable to determine mood. Invalid message.");
                }
            }
            catch (MoodAnlayserException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return "Error";
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            MoodAnalyser other = (MoodAnalyser)obj;
            return this.message == other.message;
        }
        public override int GetHashCode()
        {
            return message.GetHashCode();
        }

    }
    public enum MoodAnalysisError
    {
        NULL_MOOD,
        EMPTY_MOOD,
        INVALID_MOOD,
        NO_SUCH_CLASS,
        NO_SUCH_METHOD
    }
}
