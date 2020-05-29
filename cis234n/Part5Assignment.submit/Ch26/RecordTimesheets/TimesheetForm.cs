using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace RecordTimesheets
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TimesheetForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox empID;
		private System.Windows.Forms.TextBox empName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private TextBox[] codes;
		private TextBox[] descriptions;
		private TextBox[] durations;

		private System.Windows.Forms.TextBox desc1;
		private System.Windows.Forms.TextBox dur1;
		private System.Windows.Forms.TextBox desc2;
		private System.Windows.Forms.TextBox dur2;
		private System.Windows.Forms.TextBox desc3;
		private System.Windows.Forms.TextBox dur3;
		private System.Windows.Forms.TextBox code1;
		private System.Windows.Forms.TextBox code2;
		private System.Windows.Forms.TextBox code3;
		private System.Windows.Forms.TextBox code4;
		private System.Windows.Forms.TextBox desc4;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox dur4;

		public TimesheetForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			TextBox[] cd = {code1, code2, code3, code4};
			TextBox[] des = {desc1, desc2, desc3, desc4};
			TextBox[] durs = {dur1, dur2, dur3, dur4};
			codes = cd;
			descriptions = des;
			durations = durs;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.code4 = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dur3 = new System.Windows.Forms.TextBox();
            this.dur2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desc4 = new System.Windows.Forms.TextBox();
            this.dur1 = new System.Windows.Forms.TextBox();
            this.desc3 = new System.Windows.Forms.TextBox();
            this.desc2 = new System.Windows.Forms.TextBox();
            this.desc1 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.code3 = new System.Windows.Forms.TextBox();
            this.code2 = new System.Windows.Forms.TextBox();
            this.code1 = new System.Windows.Forms.TextBox();
            this.dur4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // code4
            // 
            this.code4.Location = new System.Drawing.Point(8, 208);
            this.code4.Name = "code4";
            this.code4.Size = new System.Drawing.Size(48, 20);
            this.code4.TabIndex = 12;
            this.code4.Text = "";
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(120, 48);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(160, 20);
            this.empName.TabIndex = 2;
            this.empName.Text = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(232, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Time";
            // 
            // dur3
            // 
            this.dur3.Location = new System.Drawing.Point(232, 176);
            this.dur3.Name = "dur3";
            this.dur3.Size = new System.Drawing.Size(48, 20);
            this.dur3.TabIndex = 11;
            this.dur3.Text = "";
            // 
            // dur2
            // 
            this.dur2.Location = new System.Drawing.Point(232, 144);
            this.dur2.Name = "dur2";
            this.dur2.Size = new System.Drawing.Size(48, 20);
            this.dur2.TabIndex = 8;
            this.dur2.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Code";
            // 
            // desc4
            // 
            this.desc4.Location = new System.Drawing.Point(64, 208);
            this.desc4.Name = "desc4";
            this.desc4.Size = new System.Drawing.Size(160, 20);
            this.desc4.TabIndex = 13;
            this.desc4.Text = "";
            // 
            // dur1
            // 
            this.dur1.Location = new System.Drawing.Point(232, 112);
            this.dur1.Name = "dur1";
            this.dur1.Size = new System.Drawing.Size(48, 20);
            this.dur1.TabIndex = 5;
            this.dur1.Text = "";
            // 
            // desc3
            // 
            this.desc3.Location = new System.Drawing.Point(64, 176);
            this.desc3.Name = "desc3";
            this.desc3.Size = new System.Drawing.Size(160, 20);
            this.desc3.TabIndex = 10;
            this.desc3.Text = "";
            // 
            // desc2
            // 
            this.desc2.Location = new System.Drawing.Point(64, 144);
            this.desc2.Name = "desc2";
            this.desc2.Size = new System.Drawing.Size(160, 20);
            this.desc2.TabIndex = 7;
            this.desc2.Text = "";
            // 
            // desc1
            // 
            this.desc1.Location = new System.Drawing.Point(64, 112);
            this.desc1.Name = "desc1";
            this.desc1.Size = new System.Drawing.Size(160, 20);
            this.desc1.TabIndex = 4;
            this.desc1.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(112, 240);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 24);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveClick);
            // 
            // code3
            // 
            this.code3.Location = new System.Drawing.Point(8, 176);
            this.code3.Name = "code3";
            this.code3.Size = new System.Drawing.Size(48, 20);
            this.code3.TabIndex = 9;
            this.code3.Text = "";
            // 
            // code2
            // 
            this.code2.Location = new System.Drawing.Point(8, 144);
            this.code2.Name = "code2";
            this.code2.Size = new System.Drawing.Size(48, 20);
            this.code2.TabIndex = 6;
            this.code2.Text = "";
            // 
            // code1
            // 
            this.code1.Location = new System.Drawing.Point(8, 112);
            this.code1.Name = "code1";
            this.code1.Size = new System.Drawing.Size(48, 20);
            this.code1.TabIndex = 3;
            this.code1.Text = "";
            // 
            // dur4
            // 
            this.dur4.Location = new System.Drawing.Point(232, 208);
            this.dur4.Name = "dur4";
            this.dur4.Size = new System.Drawing.Size(48, 20);
            this.dur4.TabIndex = 14;
            this.dur4.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(64, 88);
            this.label4.Name = "label4";
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // empID
            // 
            this.empID.Location = new System.Drawing.Point(120, 16);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(48, 20);
            this.empID.TabIndex = 1;
            this.empID.Text = "";
            // 
            // TimesheetForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dur4);
            this.Controls.Add(this.desc4);
            this.Controls.Add(this.code4);
            this.Controls.Add(this.dur3);
            this.Controls.Add(this.desc3);
            this.Controls.Add(this.code3);
            this.Controls.Add(this.dur2);
            this.Controls.Add(this.desc2);
            this.Controls.Add(this.code2);
            this.Controls.Add(this.dur1);
            this.Controls.Add(this.desc1);
            this.Controls.Add(this.code1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimesheetForm";
            this.Text = "Enter Timesheet";
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TimesheetForm());
		}

        private void saveClick(object sender, System.EventArgs e)
        {
          XmlTextWriter writer=new XmlTextWriter("Timesheet.xml",null);
          writer.Formatting=Formatting.Indented;
          writer.WriteStartDocument();
          writer.WriteStartElement("Timesheet");
          writer.WriteAttributeString("xmlns",null,"http://tempuri.org/Timesheet.xsd");
          writer.WriteStartElement("EmployeeID");
          writer.WriteString(empID.Text);
          writer.WriteEndElement();
          writer.WriteStartElement("EmployeeName");
          writer.WriteString(empName.Text);
          writer.WriteEndElement();
          for(int i=0;i<codes.Length;++i){
            string code=codes[i].Text;
            if(code.Equals("")) break;
            writer.WriteStartElement("TimesheetData");
               string name=descriptions[i].Text;
               string duration=durations[i].Text;
               writer.WriteStartElement("ActivityID");
                  writer.WriteString(code);
               writer.WriteEndElement();
               writer.WriteStartElement("ActivityName");
                  writer.WriteString(name);
               writer.WriteEndElement();
               writer.WriteStartElement("ActivityDuration");
                  writer.WriteString(duration);
               writer.WriteEndElement();
            writer.WriteEndElement();
          }//for
          writer.WriteEndElement();
          writer.WriteEndDocument();
          writer.Close();
        }
	}
}
