// $Id$
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date$">
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace MDIDemo
{
	/// <summary>
	/// Summary description for MDIChild.
	/// </summary>
	public class MDIChild : System.Windows.Forms.Form
	{
        private System.Windows.Forms.MainMenu childMenu;
        private System.Windows.Forms.MenuItem fileItem;
        private System.Windows.Forms.MenuItem saveItem;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.TextBox editData;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MDIChild()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public MDIChild(string path)
		{
			InitializeComponent();
			StreamReader myReader;
			myReader=File.OpenText(path);
            string buffer;
            while((buffer=myReader.ReadLine())!=null){
              editData.AppendText(buffer);
            }
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
            this.editData = new System.Windows.Forms.TextBox();
            this.childMenu = new System.Windows.Forms.MainMenu();
            this.fileItem = new System.Windows.Forms.MenuItem();
            this.saveItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // editData
            // 
            this.editData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editData.Location = new System.Drawing.Point(0, 0);
            this.editData.Multiline = true;
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(292, 273);
            this.editData.TabIndex = 0;
            this.editData.Text = "";
            // 
            // childMenu
            // 
            this.childMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.fileItem});
            // 
            // fileItem
            // 
            this.fileItem.Index = 0;
            this.fileItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                     this.saveItem,
                                                                                     this.menuItem1});
            this.fileItem.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
            this.fileItem.Text = "&File";
            // 
            // saveItem
            // 
            this.saveItem.Index = 0;
            this.saveItem.MergeOrder = 1;
            this.saveItem.Text = "&Save";
            this.saveItem.Click += new System.EventHandler(this.saveItemClick);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MergeOrder = 1;
            this.menuItem1.Text = "-";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.InitialDirectory = ".";
            this.saveFileDialog.Title = "MDI Text Editor";
            // 
            // MDIChild
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.editData);
            this.Menu = this.childMenu;
            this.Name = "MDIChild";
            this.Text = "MDIChild";
            this.ResumeLayout(false);

        }
		#endregion

        private void saveItemClick(object sender, System.EventArgs e)
        {
            DialogResult buttonClicked=saveFileDialog.ShowDialog();
            if(buttonClicked.Equals(DialogResult.OK))
            {
                Stream saveStream=saveFileDialog.OpenFile();
                StreamWriter saveWriter=new StreamWriter(saveStream);
                foreach (string line in editData.Lines)
                {
                    saveWriter.WriteLine(line);
                }
                saveWriter.Close();
            }
        }
	}
}
