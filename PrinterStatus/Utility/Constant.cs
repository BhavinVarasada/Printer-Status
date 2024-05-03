namespace PrinterStatus.Utility
{
    /// <summary>
    /// this class is used for all constant string and integer value.
    /// </summary>
    public class Constant
    {
        public const string DASH_LINE = "|===============================================================|";
        public const string PROGRAM_NAME = "Printer Status Check";
        public const string USER_DISPLAY_MSG = "Enter the paper count [Range: 0 to 2147483647] : ";

        public const string DISPLAY_MSG_NO_PAPER = "No paper";
        public const string DISPLAY_MSG_LOW_PAPER = "Printer is not ready to Print due to Low paper";
        public const string DISPLAY_MSG_PRINTER_READY = "Printer is ready to Print";

        public const string ERROR_MSG = "[Error] Entered Paper count is invalid.";
        public const string UNEXPECTED_ERROR_MSG = "Printer Status check operation failed.";
        public const string PRINTER_STATUS = "PrinterStatus : {0}";

        public const int ZERO = 0;
        public const int ONE = 1;
        public const int TEN = 10;
        public const int MINIMUM_RANGE = 0;
        public const int MAXIMUM_RANGE = 2147483647;
    }
}