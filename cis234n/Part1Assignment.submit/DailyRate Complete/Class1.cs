// $Id: Class1.cs,v 1.11 2005/10/02 04:56:19 khtan Exp $
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date: 2005/10/02 04:56:19 $">
using System;
using System.Diagnostics;
using System.Globalization; // fxcop
[assembly:CLSCompliant(true)] // fxcop
namespace DailyRate
{
	/// <summary>
    /// Functionally, this program calculates the commission fee by requesting
    /// 2 inputs from the user ( daily rate, number of days )
	/// </summary>
    /// <remarks>
    /// This class also serves the following learning purposes:
    /// 1) Catching exceptions, anticipated and unanticipated
    /// 2) Use of comment tags
    /// 3) Use of fxcop ( //www.gotdotnet.com/team/fxcop ), a code analysis tool
    ///    Changes marked "fxcop" in the comments were motivated by the tool.
    ///    The advantage is that security and more advanced practices are caught and learnt
    ///    earlier
    /// 4) A simple test driver and test data files is used in runtest.bat
    /// </remarks>

	class Class1
	{
        /// <summary>
        /// Main entry point, serves to catch all unanticipated exceptions
        /// </summary>
		static void Main()
		{
          try{
			// (new Class1()).run(); // fxcop - mark method as static
			run();
          }catch(Exception e){
            writeExceptionMessage("Unhandled System.Exception! "+e.Message);
          }catch{ // see FxCop CA2102 Catch non-CLSCompliant exceptions in general handlers
            // <see href="http://www.gotdotnet.com/team/fxcop/Docs/Rules/Security/CatchNonClsCompliantExceptionsInGeneralHandlers.html" />
            writeExceptionMessage("non-CLSCompliant exception!");
          }
		}
        /// <summary>
        /// Write exception message to console
        /// </summary>
        /// <param name="message">Message string to print out</param>
        static private void writeExceptionMessage(string message){
           StackFrame CallStack = new StackFrame(1, true);
           Console.WriteLine("Error: "+message+ " [Function: "+CallStack.GetMethod()+", Line: "+CallStack.GetFileLineNumber()+"]");
        }
        /// <summary>
        /// Called from Main, contains top most logic of program and handling all anticipated exceptions
        /// </summary>
		public static void run()
		{
			double dailyRate = readDouble("Enter your daily rate: ");
			int noOfDays = readInt("Enter the number of days: ");
            if(dailyRate<0){ // No need to throw here because can handle and not call writeFee
              Console.WriteLine("Daily rate cannot be negative!");
            }else if(noOfDays<0){
              Console.WriteLine("Number of days cannot be negative!");
            }else{
              writeFee(calculateFee(dailyRate, noOfDays));
            }
		}
        /// <summary>
        /// Read and validate a double from user
        /// </summary>
        /// <param name="prompt">Read a double value from console</param>
        /// <returns>Valid double value</returns>
		static private double readDouble(string prompt)
		{
			Console.Write(prompt);
			string line = Console.ReadLine();
            double value=0.0;
            try{
              value=double.Parse(line,CultureInfo.InvariantCulture); // fxcop
            }catch(FormatException e){ // most likely 
              writeExceptionMessage(e.Message);
            }catch(OverflowException e){
              writeExceptionMessage(e.Message);
            }catch(ArgumentNullException e){
              writeExceptionMessage(e.Message);
            }
            return value;
		}
        /// <summary>
        /// Read and validate an integer from user
        /// </summary>
        /// <param name="prompt">read an integer from console</param>
        /// <returns>Valid int value</returns>
		static private int readInt(string prompt)
		{
			Console.Write(prompt);
			string line = Console.ReadLine();
            int value=0;
            try{
              value=int.Parse(line,CultureInfo.InvariantCulture); // fxcop
            }catch(FormatException e){ // most likely 
              writeExceptionMessage(e.Message);
            }catch(OverflowException e){
              writeExceptionMessage(e.Message);
            }catch(ArgumentNullException e){
              writeExceptionMessage(e.Message);
            }
            return value;
		}
        /// <summary>
        /// Compute consulting fee
        /// </summary>
        /// <param name="dailyRate">The daily commission rate in double precision</param>
        /// <param name="noOfDays">Whole number of days worked</param>
        /// <returns>dailyRate*noOfDays double value</returns>
		static private double calculateFee(double dailyRate, int noOfDays)
		{
          double result=0.0;
          try{
            result=dailyRate*noOfDays;
          }catch(OverflowException e){
              writeExceptionMessage(e.Message);
          }
          return result;
		}
        /// <summary>
        /// Write consulting fee to console
        /// </summary>
        /// <param name="fee">Value of fee in double precision</param>
		static private void writeFee(double fee)
		{
          double result=0.0;
          try{
            result= fee * 1.1;
          }catch(OverflowException e){
              writeExceptionMessage(e.Message);
          }
          Console.WriteLine("The consultant's fee is: {0}", result);
		}
	}
}
