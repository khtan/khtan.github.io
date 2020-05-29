// $Id: Form1.cs,v 1.7 2005/10/02 05:20:51 khtan Exp $
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date: 2005/10/02 05:20:51 $">
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using operandType=System.Single; // Change to System.Int32 for original program

namespace Methods
{
	/// <summary>
	/// This is the dialog form for exercising the various math operations.
    /// This code was originally written for integer operands. By creating an alias
    /// type called operandType and setting it to System.Single, the code was updated
    /// for float. This operandType can be set back to System.Int32 for integer operations.
	/// </summary>
    /// <remarks>
    /// The gui objects are documented as "gui" so that the Comment Web Page will
    /// show better which members are objects, and which members are functions.
    /// Deeper detail on each "gui" is not documented because it results in constant
    /// updating whenever the gui form changes.
    /// </remarks>
	public class Form1 : System.Windows.Forms.Form
	{
        /// <summary>gui</summary>
		private System.Windows.Forms.Label label1;       /// <summary>gui</summary>
		private System.Windows.Forms.TextBox lhsOperand; /// <summary>gui</summary>
		private System.Windows.Forms.GroupBox groupBox1; /// <summary>gui</summary>
		private System.Windows.Forms.Label label2;       /// <summary>gui</summary>
		private System.Windows.Forms.TextBox rhsOperand; /// <summary>gui</summary>
		private System.Windows.Forms.Button calculate;   /// <summary>gui</summary>
		private System.Windows.Forms.Label label3;       /// <summary>gui</summary>
		private System.Windows.Forms.TextBox expression; /// <summary>gui</summary>
		private System.Windows.Forms.Label label4;       /// <summary>gui</summary>
		private System.Windows.Forms.TextBox result;     /// <summary>gui</summary>
		private System.Windows.Forms.Button quit;        /// <summary>gui</summary>
		private System.Windows.Forms.RadioButton addition;/// <summary>gui</summary>
		private System.Windows.Forms.RadioButton subtraction;/// <summary>gui</summary>
		private System.Windows.Forms.RadioButton multiplication;/// <summary>gui</summary>
		private System.Windows.Forms.RadioButton division;/// <summary>gui</summary>
		private System.Windows.Forms.RadioButton remainder;/// <summary>gui</summary>
        private System.Windows.Forms.RadioButton sqrtlhs;/// <summary>gui</summary>
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// default constructor of form
		/// </summary>
		public Form1()
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
            this.calculate = new System.Windows.Forms.Button();
            this.remainder = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.expression = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sqrtlhs = new System.Windows.Forms.RadioButton();
            this.division = new System.Windows.Forms.RadioButton();
            this.multiplication = new System.Windows.Forms.RadioButton();
            this.subtraction = new System.Windows.Forms.RadioButton();
            this.quit = new System.Windows.Forms.Button();
            this.rhsOperand = new System.Windows.Forms.TextBox();
            this.lhsOperand = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(16, 200);
            this.calculate.Name = "calculate";
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // remainder
            // 
            this.remainder.Location = new System.Drawing.Point(16, 104);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(104, 16);
            this.remainder.TabIndex = 4;
            this.remainder.Text = "% Remainder";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result";
            // 
            // expression
            // 
            this.expression.Enabled = false;
            this.expression.Location = new System.Drawing.Point(136, 200);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(176, 20);
            this.expression.TabIndex = 7;
            this.expression.Text = "";
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(16, 248);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(296, 20);
            this.result.TabIndex = 9;
            this.result.Text = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "left operand";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(280, 32);
            this.label2.Name = "label2";
            this.label2.TabIndex = 3;
            this.label2.Text = "right operand";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(136, 184);
            this.label3.Name = "label3";
            this.label3.TabIndex = 6;
            this.label3.Text = "Expression";
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(16, 24);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(104, 16);
            this.addition.TabIndex = 0;
            this.addition.Text = "+ Addition";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sqrtlhs);
            this.groupBox1.Controls.Add(this.remainder);
            this.groupBox1.Controls.Add(this.division);
            this.groupBox1.Controls.Add(this.multiplication);
            this.groupBox1.Controls.Add(this.subtraction);
            this.groupBox1.Controls.Add(this.addition);
            this.groupBox1.Location = new System.Drawing.Point(128, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operators";
            // 
            // sqrtlhs
            // 
            this.sqrtlhs.Location = new System.Drawing.Point(16, 128);
            this.sqrtlhs.Name = "sqrtlhs";
            this.sqrtlhs.Size = new System.Drawing.Size(120, 16);
            this.sqrtlhs.TabIndex = 5;
            this.sqrtlhs.Text = "Sqrt(left operand)";
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(16, 84);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(104, 16);
            this.division.TabIndex = 3;
            this.division.Text = "/ Division";
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(16, 64);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(104, 16);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "* Multiplication";
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(16, 44);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(104, 16);
            this.subtraction.TabIndex = 1;
            this.subtraction.Text = "- Subtraction";
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(320, 248);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(56, 23);
            this.quit.TabIndex = 10;
            this.quit.Text = "Quit";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // rhsOperand
            // 
            this.rhsOperand.Location = new System.Drawing.Point(280, 48);
            this.rhsOperand.Name = "rhsOperand";
            this.rhsOperand.TabIndex = 4;
            this.rhsOperand.Text = "";
            // 
            // lhsOperand
            // 
            this.lhsOperand.Location = new System.Drawing.Point(16, 48);
            this.lhsOperand.Name = "lhsOperand";
            this.lhsOperand.TabIndex = 1;
            this.lhsOperand.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(392, 277);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.expression);
            this.Controls.Add(this.rhsOperand);
            this.Controls.Add(this.lhsOperand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exceptions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>The main entry point for the application.</summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
        /// <summary>Start calculation when "Click" button is activated. Calls doCalculation</summary>
        /// <param name="sender">Form that sent event</param>
        /// <param name="e">Event</param>
		private void calculate_Click(object sender, System.EventArgs e)
		{
			try
			{
				operandType lhs = operandType.Parse(lhsOperand.Text);
                operandType rhs=0;
                if(! sqrtlhs.Checked){
                  rhs = operandType.Parse(rhsOperand.Text);
                }
				operandType answer = doCalculation(lhs, rhs);	
				result.Text = answer.ToString();
			}
			catch (System.Exception caught)
			{
				result.Text = caught.Message;
			}
		}	
        /// <summary>Perform actual calculation. Called by calculate_Click</summary>
        /// <param name="lhs">Left hand side operand</param>
        /// <param name="rhs">Right hand side operand</param>
        /// <returns>For binary operations, = lhs op rhs. For sqrt, = sqrt(lhs)</returns>
        /// <exception>InvalidOperationException</exception>
		private operandType doCalculation(operandType lhs, operandType rhs)
		{
			operandType result = 0;

			if (addition.Checked) 
				result = addValues(lhs, rhs);
			else if (subtraction.Checked)
				result = subtractValues(lhs, rhs);
			else if (multiplication.Checked)
				result = multiplyValues(lhs, rhs);
			else if (division.Checked)
				result = divideValues(lhs, rhs);
			else if (remainder.Checked)
				result = remainderValues(lhs, rhs);
			else if (sqrtlhs.Checked){
				result = sqrtLhsValue(lhs);
			}else
				throw new InvalidOperationException("no operator selected");

			return result;
		}		
        /// <summary>Perform + binary operation</summary>
        /// <param name="lhs">Left hand side operand</param>
        /// <param name="rhs">Right hand side operand</param>
        /// <returns>result of operation</returns>
		private operandType addValues(operandType lhs, operandType rhs)
		{	
			expression.Text = lhs.ToString() + " + " + rhs.ToString();
			return lhs + rhs;
		}
        /// <summary>Perform - binary operation</summary>
        /// <param name="lhs">Left hand side operand</param>
        /// <param name="rhs">Right hand side operand</param>
        /// <returns>result of operation</returns>
		private operandType subtractValues(operandType lhs, operandType rhs)	
		{
			expression.Text = lhs.ToString() + " - " + rhs.ToString();
			return lhs - rhs;
		}

        /// <summary>Perform * binary operation</summary>
        /// <param name="lhs">Left hand side operand</param>
        /// <param name="rhs">Right hand side operand</param>
        /// <returns>result of operation</returns>
		private operandType multiplyValues(operandType lhs, operandType rhs)	
		{
			expression.Text = lhs.ToString() + " * " + rhs.ToString();
			return checked(lhs * rhs);	
		}
        /// <summary>Perform / binary operation</summary>
        /// <param name="lhs">Left hand side operand</param>
        /// <param name="rhs">Right hand side operand</param>
        /// <returns>result of operation</returns>
		private operandType divideValues(operandType lhs, operandType rhs)	
		{
			expression.Text = lhs.ToString() + " / " + rhs.ToString();
			return lhs / rhs;
		}
        /// <summary>Perform % binary operation</summary>
        /// <param name="lhs">Left hand side operand</param>
        /// <param name="rhs">Right hand side operand</param>
        /// <returns>result of operation</returns>
		private operandType remainderValues(operandType lhs, operandType rhs)	
		{
			expression.Text = lhs.ToString() + " % " + rhs.ToString();
			return lhs % rhs;
		}
        /// <summary>Perform sqrt on operand</summary>
        /// <param name="lhs">operand value from left hand side field</param>
        /// <returns>result of operation</returns>
		private operandType sqrtLhsValue(operandType lhs)	
		{
			expression.Text = "sqrt("+lhs.ToString() + ")";
			return Convert.ToSingle(System.Math.Sqrt(lhs));
		}
        /// <summary>Quit application</summary>
        /// <param name="sender">Form that sent event</param>
        /// <param name="e">Event</param>
        /// <returns>result of operation</returns>
		private void quit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
        /// <summary>Load the form</summary>
        /// <param name="sender">Form that sent event</param>
        /// <param name="e">Event</param>
        /// <returns>result of operation</returns>
		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
