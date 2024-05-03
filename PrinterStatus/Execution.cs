using PrinterStatus.Utility;
using System;

namespace PrinterStatus
{

    /// <summary>
    /// This class is used for program execution logic.
    /// </summary>
    public class Execution
    {
        /// <summary>
        /// This Method is for start the execution and it will call validation method to check user input is valid or not.
        /// </summary>
        public void Start()
        {
            try
            {
                Output.Write(Constant.DASH_LINE);
                Output.Write(Constant.PROGRAM_NAME);
                Output.Write(Constant.DASH_LINE);

                int nPaperCount = 0;
                bool bCheckValidation = false;
                while (!bCheckValidation)
                {
                    // this method return the integer number from the user.
                    nPaperCount = UserInput.GetInt(Constant.USER_DISPLAY_MSG, Constant.ERROR_MSG);

                    // this method will validate user input and return the result.
                    bCheckValidation = CheckValidation(nPaperCount);
                }
                PrinterStatus(nPaperCount);
            }
            catch (Exception ex)
            {
                Output.Write(ex.Message);
                Output.Write(ex.StackTrace);
            }
        }

        /// <summary>
        /// this method is used to check validation.
        /// </summary>
        /// <param name="nPaperCount"></param>
        /// <returns></returns>
        private bool CheckValidation(int nPaperCount)
        {
            try
            {
                // it will check that user input is in range or not.
                if (nPaperCount < Constant.MINIMUM_RANGE || nPaperCount > Constant.MAXIMUM_RANGE)
                {
                    Output.Write(string.Format(Constant.PRINTER_STATUS, Constant.ERROR_MSG));
                    return false;
                }
            }
            catch
            {
                Output.Write(Constant.UNEXPECTED_ERROR_MSG);
            }
            return true;
        }

        /// <summary>
        /// this method is final method to print the status.
        /// </summary>
        /// <param name="nPaperCount"></param>
        private void PrinterStatus(int nPaperCount)
        {
            // it will check userinput and print appropriate message for input.
            if (nPaperCount == Constant.ZERO)
            {
                Output.Write(string.Format(Constant.PRINTER_STATUS, Constant.DISPLAY_MSG_NO_PAPER));
            }
            else if (Constant.ONE <= nPaperCount && nPaperCount <= Constant.TEN)
            {
                Output.Write(string.Format(Constant.PRINTER_STATUS, Constant.DISPLAY_MSG_LOW_PAPER));
            }
            else if (nPaperCount > Constant.TEN)
            {
                Output.Write(string.Format(Constant.PRINTER_STATUS, Constant.DISPLAY_MSG_PRINTER_READY));
            }
        }
    }
}
