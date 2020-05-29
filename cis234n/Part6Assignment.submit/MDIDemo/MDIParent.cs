// $Id$
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date$">
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MDIDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MDIParent : System.Windows.Forms.Form
	{
        private System.Windows.Forms.MainMenu mdiMenu;
        private System.Windows.Forms.MenuItem fileItem;
        private System.Windows.Forms.MenuItem newItem;
        private System.Windows.Forms.MenuItem windowItem;
        private System.Windows.Forms.MenuItem closeItem;
        private System.Windows.Forms.MenuItem exitItem;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem cascadeItem;
        private System.Windows.Forms.MenuItem horizontalItem;
        private System.Windows.Forms.MenuItem verticalItem;
        private int childCount=0;
        private System.Windows.Forms.MenuItem helpItem;
        private System.Windows.Forms.MenuItem aboutItem;
        private System.Windows.Forms.MenuItem openItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MDIParent()
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
            this.mdiMenu = new System.Windows.Forms.MainMenu();
            this.fileItem = new System.Windows.Forms.MenuItem();
            this.newItem = new System.Windows.Forms.MenuItem();
            this.openItem = new System.Windows.Forms.MenuItem();
            this.closeItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.exitItem = new System.Windows.Forms.MenuItem();
            this.windowItem = new System.Windows.Forms.MenuItem();
            this.cascadeItem = new System.Windows.Forms.MenuItem();
            this.horizontalItem = new System.Windows.Forms.MenuItem();
            this.verticalItem = new System.Windows.Forms.MenuItem();
            this.helpItem = new System.Windows.Forms.MenuItem();
            this.aboutItem = new System.Windows.Forms.MenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            // 
            // mdiMenu
            // 
            this.mdiMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                    this.fileItem,
                                                                                    this.windowItem,
                                                                                    this.helpItem});
            // 
            // fileItem
            // 
            this.fileItem.Index = 0;
            this.fileItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                     this.newItem,
                                                                                     this.openItem,
                                                                                     this.closeItem,
                                                                                     this.menuItem1,
                                                                                     this.exitItem});
            this.fileItem.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
            this.fileItem.Text = "&File";
            // 
            // newItem
            // 
            this.newItem.Index = 0;
            this.newItem.Text = "&New";
            this.newItem.Click += new System.EventHandler(this.newItemClick);
            // 
            // openItem
            // 
            this.openItem.Index = 1;
            this.openItem.Text = "&Open";
            this.openItem.Click += new System.EventHandler(this.openItemClick);
            // 
            // closeItem
            // 
            this.closeItem.Index = 2;
            this.closeItem.Text = "&Close";
            this.closeItem.Click += new System.EventHandler(this.closeItemClick);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "-";
            // 
            // exitItem
            // 
            this.exitItem.Index = 4;
            this.exitItem.MergeOrder = 2;
            this.exitItem.Text = "E&xit";
            this.exitItem.Click += new System.EventHandler(this.exitItemClick);
            // 
            // windowItem
            // 
            this.windowItem.Index = 1;
            this.windowItem.MdiList = true;
            this.windowItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                       this.cascadeItem,
                                                                                       this.horizontalItem,
                                                                                       this.verticalItem});
            this.windowItem.Text = "&Window";
            // 
            // cascadeItem
            // 
            this.cascadeItem.Index = 0;
            this.cascadeItem.Text = "&Cascade";
            this.cascadeItem.Click += new System.EventHandler(this.cascadeItemClick);
            // 
            // horizontalItem
            // 
            this.horizontalItem.Index = 1;
            this.horizontalItem.Text = "Tile &Horizontal";
            this.horizontalItem.Click += new System.EventHandler(this.horizontalItemClick);
            // 
            // verticalItem
            // 
            this.verticalItem.Index = 2;
            this.verticalItem.Text = "Tile &Vertical";
            this.verticalItem.Click += new System.EventHandler(this.verticalItemClick);
            // 
            // helpItem
            // 
            this.helpItem.Index = 2;
            this.helpItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                     this.aboutItem});
            this.helpItem.Text = "&Help";
            // 
            // aboutItem
            // 
            this.aboutItem.Index = 0;
            this.aboutItem.Text = "&About MDI Demo";
            this.aboutItem.Click += new System.EventHandler(this.aboutItemClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.InitialDirectory = ".";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "MDI Text Editor";
            // 
            // MDIParent
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(492, 423);
            this.IsMdiContainer = true;
            this.Menu = this.mdiMenu;
            this.Name = "MDIParent";
            this.Text = "MDI Parent Form";

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MDIParent());
		}

        private void exitItemClick(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void newItemClick(object sender, System.EventArgs e)
        {
            childCount++;
            MDIChild childForm=new MDIChild();
            childForm.MdiParent=this;
            childForm.Text=childForm.Text+" "+childCount;
            childForm.Show();
        }

        private void cascadeItemClick(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalItemClick(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalItemClick(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeItemClick(object sender, System.EventArgs e)
        {
            Form childForm=this.ActiveMdiChild;
            if(childForm!=null)
            {
                childForm.Close();
            }
        }

        private void aboutItemClick(object sender, System.EventArgs e)
        {
            About aboutDialog=new About();
            aboutDialog.ShowDialog(); // modal
            // aboutDialog.Show(); //modeless
        }

        private void openItemClick(object sender, System.EventArgs e)
        {
            DialogResult buttonClicked=openFileDialog.ShowDialog();
            if(buttonClicked.Equals(DialogResult.OK)){
              MDIChild childForm;
              if(openFileDialog.Multiselect==true){
                  string[] paths=openFileDialog.FileNames;
                  foreach (string path in paths){
                    childCount++;
                    childForm=new MDIChild(path);
                    childForm.MdiParent=this;
                    childForm.Text=childForm.Text+" "+childCount;
                    childForm.Show();
                  }
              }else{
                  childCount++;
                  string path=openFileDialog.FileName;
                  childForm=new MDIChild(path);
                  childForm.MdiParent=this;
                  childForm.Text=childForm.Text+" "+childCount;
                  childForm.Show();
              }
            }
        }
	}
}
