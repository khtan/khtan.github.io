// $Id: testA4MainForm.cs 10 2005-10-22 22:54:03Z khtan $
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date: 2005-10-22 15:54:03 -0700 (Sat, 22 Oct 2005) $">
using System;
using System.Windows.Forms;

namespace a4
{
	/// <summary>
    ///  See fuller documentation in readme.txt   
	/// </summary>
	class testA4MainForm
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
          a4DataObject ddo=new a4DataObject();
          Application.Run(new a4MainForm(ddo));
		}
	}
}
