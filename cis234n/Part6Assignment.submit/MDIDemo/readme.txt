Project requirement:
   Change the TextFileExample in the IO folder from a console
   application to a Windows Forms Application. Use any method you wish to
   get a line of input from the user, such as a textbox or listbox and
   write that line out to a textfile.  Write out as many lines as the
   user wishes to enter until they decide to stop and save the
   file. Also, be able to read back the file into the program. Once
   again, choose any method you wish to display the contents of  the
   file. 

   Use the SaveFileDialog (see the example) to allow the user to choose
   the name and location of the file to save. 

Project solution:

   The solution reuses the MDIDemo in Chapter 22 with the following
   enhancements:

   MDIParent.cs
   - Added an openFileDialog
   - Added an openItemClick to get user to select file to open.
     The path of the file is passed to MDIChild constructor
   - Support both openFileDialog as multiselect and single select.
     Code is set to multiselect
   - Fixed bug that multiselect files were using the same child count
   MDIChild.cs
   - Changed saveFileDialog default directory property from "c:\" to "."
   - Added a constructor MDIChild(string path) to read in the required
     contents of selected file
     Constructor uses a StreamReader to read the file and update the
     internal TextBox