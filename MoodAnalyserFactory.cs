using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMoodAnalyser
{
    internal class MoodAnalyserFactory
    {
        public static MoodAnalyser CreateMoodAnalyser()
        {
            Type type = typeof(MoodAnalyser);
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            MoodAnalyser moodAnalyser = (MoodAnalyser)constructor.Invoke(null);
            return moodAnalyser;
        }
        public static MoodAnalyser CreateMoodAnalyser(string message)
        {
            Type type = typeof(MoodAnalyser);
            ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
            MoodAnalyser moodAnalyser = (MoodAnalyser)constructor.Invoke(new object[] { message });
            return moodAnalyser;
        }
        public static MoodAnalyser CreateMoodAnalyser(string className, string message)
        {
            try
            {
                Type type = Type.GetType(className);
                if (type == null)
                {
                    throw new MoodAnlayserException(MoodAnalysisError.NO_SUCH_CLASS, "No such class found.");
                }
                ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                if (constructor == null)
                {
                    throw new MoodAnlayserException(MoodAnalysisError.NO_SUCH_METHOD, "No such constructor found.");
                }

                MoodAnalyser moodAnalyser = (MoodAnalyser)constructor.Invoke(new object[] { message });
                return moodAnalyser;
            }
            catch (MoodAnlayserException)
            {
                throw; // Rethrow the MoodAnalysisException
            }
            catch (Exception ex)
            {
                throw new MoodAnlayserException(MoodAnalysisError.NO_SUCH_METHOD, ex.Message);
            }
        }
    }
    
}
