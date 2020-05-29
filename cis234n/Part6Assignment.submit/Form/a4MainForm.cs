// $Id: a4MainForm.cs 10 2005-10-22 22:54:03Z khtan $
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date: 2005-10-22 15:54:03 -0700 (Sat, 22 Oct 2005) $">
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace a4{
  /// <summary>
  ///  See fuller documentation in readme.txt   
  /// </summary>
  public class a4MainForm : System.Windows.Forms.Form{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;
      private System.Windows.Forms.MainMenu mainMenu1;
      private System.Windows.Forms.MenuItem dataEntryItem;
    private a4DataObject refDo;
    public a4MainForm(a4DataObject ddo){
      InitializeComponent();
      refDo=ddo;
    }
    public a4MainForm(){
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
    protected override void Dispose( bool disposing ){
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
    private void InitializeComponent(){
        this.mainMenu1 = new System.Windows.Forms.MainMenu();
        this.dataEntryItem = new System.Windows.Forms.MenuItem();
        // 
        // mainMenu1
        // 
        this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                  this.dataEntryItem});
        // 
        // dataEntryItem
        // 
        this.dataEntryItem.Index = 0;
        this.dataEntryItem.Text = "DataEntry";
        this.dataEntryItem.Click += new System.EventHandler(this.dataEntryItemClick);
        // 
        // a4MainForm
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(292, 273);
        this.Menu = this.mainMenu1;
        this.Name = "a4MainForm";
        this.Text = "a4MainForm";

    }
    #endregion

		private void serializeObject(string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(a4DataObject));
			TextWriter writer = new StreamWriter(filename);
			serializer.Serialize(writer, this.refDo);
			writer.Close();
		}
		private void deserializeObject(string filename)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(a4DataObject));
			FileStream fs = new FileStream(filename, FileMode.Open);            
			XmlReader reader = new XmlTextReader(fs);
            this.refDo=(a4DataObject)serializer.Deserialize(reader);
            fs.Close();
		}


      private void dataEntryItemClick(object sender, System.EventArgs e)
      {
        /* if dataobject.xml exists, deserialize it and feed to refDo
           after user enters or updates, serialize it back
         */
        string filePath="dataobject.xml";
        if(File.Exists(filePath)){
          MessageBox.Show("Data object deserialized from dataobject.xml");
          deserializeObject(filePath);
        }
        a4DataValidateForm dvf=new a4DataValidateForm(refDo);
        dvf.ShowDialog();
        MessageBox.Show("Data object serialized to dataobject.xml");
        // MessageBox.Show(refDo.toString());
        serializeObject(filePath);
      }
  }
}
