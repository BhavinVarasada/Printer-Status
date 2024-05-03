using System;

namespace PrinterStatus.Utility
{
    /// <summary>
    /// This class is used to get the input from the user.
    /// </summary>
    public class UserInput
    {
        /// <summary>
        /// this method will return the user input.
        /// </summary>
        /// <param name="strDisplayMsg"></param>
        /// <param name="strErrorMsg"></param>
        /// <returns></returns>
        public static int GetInt(string strDisplayMsg, string strErrorMsg)
        {
            int nPaperCount = 0;
            bool bInputStatus = false;
            while (!bInputStatus)
            {
                Output.FirstMessage(strDisplayMsg);
                string strPaperCount = Console.ReadLine();

                //this tryparse method is used for datatype conversation.
                bInputStatus = int.TryParse(strPaperCount, out nPaperCount);
                if (bInputStatus == false)
                {
                    Output.Write(strErrorMsg);
                }
            }
            return nPaperCount;
        }
    }
}
