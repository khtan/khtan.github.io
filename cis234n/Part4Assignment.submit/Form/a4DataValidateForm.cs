// $Id: a4DataValidateForm.cs 10 2005-10-22 22:54:03Z khtan $
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date: 2005-10-22 15:54:03 -0700 (Sat, 22 Oct 2005) $">
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace a4
{
	/// <summary>
    ///  See fuller documentation in readme.txt   
	/// </summary>
	public class a4DataValidateForm : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox AccountNumberBox;
        private System.Windows.Forms.Button SubmitButton;
		private System.Windows.Forms.ErrorProvider submitError;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private a4DataObject refDo;
		public a4DataValidateForm(a4DataObject ddo){
            
			InitializeComponent();
            refDo=ddo;
		}
		public a4DataValidateForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.AccountNumberBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.submitError = new System.Windows.Forms.ErrorProvider();
            this.SuspendLayout();
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(30, 60);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.Location = new System.Drawing.Point(30, 140);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.TabIndex = 1;
            this.AccountNumberLabel.Text = "Account Number";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(150, 60);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.TabIndex = 2;
            this.LastNameBox.Text = "";
            // 
            // AccountNumberBox
            // 
            this.AccountNumberBox.Location = new System.Drawing.Point(150, 140);
            this.AccountNumberBox.Name = "AccountNumberBox";
            this.AccountNumberBox.TabIndex = 3;
            this.AccountNumberBox.Text = "";
            this.AccountNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(120, 220);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.Click += new System.EventHandler(this.submitClick);
            // 
            // DataValidateForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AccountNumberBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.AccountNumberLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Name = "DataValidateForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
		#endregion
        private void submitClick(object sender, System.EventArgs e)
        {
          bool emptyDetected=false;
          if(LastNameBox.Text.Length==0){
            submitError.SetError(LastNameBox,"Please enter last name");
            emptyDetected=true;
          }else{
            submitError.SetError(LastNameBox,"");
          }
          if(AccountNumberBox.Text.Length==0){
            submitError.SetError(AccountNumberBox,"Please enter account number");
            emptyDetected=true;
          }else{
            submitError.SetError(AccountNumberBox,"");
          }
          if(emptyDetected) return;

          refDo.LastName=this.LastNameBox.Text;
          refDo.AccountNumber=int.Parse(this.AccountNumberBox.Text);
          refDo.ValidAccountNumber=true;
          // MessageBox.Show(refDo.toString());
          this.Close();
        }

        private void keyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
          //accept only 0-9 or backspace keys
          if ((e.KeyChar >= '0' && e.KeyChar <= '9')  || e.KeyChar == Convert.ToChar(Keys.Back))
            e.Handled = false;      //leave character in textbox buffer
          else
            e.Handled = true;       //erase character from textbox buffer
        }
	}//class
}
