Project requirement:
   Change the SerializeToXML example from a console to a windows
   application. Once again, I'll leave it up to you how you create the
   form. 

   Instead of using the OrderedItem class that is in the sample,
   create your own class, whatever you want and use it to create an
   object to serialize. 

Project solution:

   The solution reuses the Form assignment used in Part 4.

   a4MainForm.cs.
   - Update the dataEntryClick to check for an xml file
     "./dataobject.xml". If the file exists, it is read
     in as the data object and then presented to the user.
     Upon validation, the updated data object is serialized
     back to the same file.
     If no xml file exists, a default data object is created.
     
   a4ValidateDataForm.cs
   - Updated to display the deserialized object and allow
     user to change the name and account number