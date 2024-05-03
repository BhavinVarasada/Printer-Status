namespace PrinterStatus
{
    /// <summary>
    /// This is the main Class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// this is the main method and it will call the start method.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Execution objExecution = new Execution();
            objExecution.Start();
        }
    }
}
