using System;
using System.Collections;

namespace Rent.Core.Concrete.Helpers
{
    public static class MsgExceptionDetailHelper
    {
        static public string Details(Exception exception)
        {
            string exceptionString = "";

            try
            {
                int i = 0;
                while (exception != null)
                {
                    exceptionString += "*** Exception Level " + i + " ***\n";
                    exceptionString += "Message: " + exception.Message + "\n";
                    exceptionString += "Source: " + exception.Source + "\n";
                    exceptionString += "Target Site: " +
                                       exception.TargetSite + "\n";
                    exceptionString += "Stack Trace: " +
                                       exception.StackTrace + "\n";
                    exceptionString += "Data: ";
                    foreach (DictionaryEntry keyValuePair in
                        exception.Data)
                        exceptionString += keyValuePair.Key.ToString()
                                           + ":" + keyValuePair.Value.ToString();
                    exceptionString += "\n***\n\n";
                    exception = exception.InnerException;
                    i++;
                }
            }
            catch { }
            return exceptionString;
        }
    }
}
