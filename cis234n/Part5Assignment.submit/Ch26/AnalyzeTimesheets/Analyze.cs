using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace AnalyzeTimesheets
{
	class Analyze
	{
		static void Main(string[] args)
		{
			if (args.Length < 1)
			{
				Console.WriteLine("Usage: AnalyzeTimesheets <XML file>");
				return;
			}

			try
			{
				// Code to read and validate XML goes here
              StreamReader stream=new StreamReader(args[0]);
              XmlTextReader reader=new XmlTextReader(stream);
              XmlSchemaCollection schemaColl=new XmlSchemaCollection();
              schemaColl.Add(null,"Timesheet.xsd");
              XmlValidatingReader valReader=new XmlValidatingReader(reader);
              valReader.ValidationType=ValidationType.Schema; // Q - types of validation?
              valReader.Schemas.Add(schemaColl);
              valReader.ValidationEventHandler += new ValidationEventHandler(valHandler);
              decimal hours=0;
              while(valReader.Read()){
                if(valReader.LocalName.Equals("ActivityName")){
                  Console.WriteLine("Activity: "+valReader.ReadString());
                }
                if(valReader.LocalName.Equals("ActivityDuration")){
                  hours+=Decimal.Parse(valReader.ReadString());
                }
              }
              Console.WriteLine("File processed. Number of hours worked - {0}",hours);
              valReader.Close();
              reader.Close();
              stream.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception analyzing timesheet: " + e);
			}
		}

		private static void valHandler(Object sender, ValidationEventArgs e)
		{
			Console.WriteLine("Validation failed: " + e.Message);
		}
	}
}
