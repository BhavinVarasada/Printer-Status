using System;

namespace PrinterStatus.Utility
{
    /// <summary>
    /// This class is used for all output methods.
    /// </summary>
    public class Output
    {
        /// <summary>
        /// this method is used for Console.writeline command.
        /// </summary>
        /// <param name="strMessage"></param>
        public static void Write(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        /// <summary>
        /// this method is used for Console.write command.
        /// </summary>
        /// <param name="strMessage"></param>
        public static void FirstMessage(string strMessage)
        {
            Console.Write(strMessage);
        }
    }
}
