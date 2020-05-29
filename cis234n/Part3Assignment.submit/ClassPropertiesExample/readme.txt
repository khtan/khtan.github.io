Since this is a console application, I have dispensed completely with
VS .NET's solution and project overhead and just provided the source
and executable.

The advantage is smaller download.

Sample Transcript
------------------
// Compile
h:\vault\learn\pcc\cis234n\Part3Assignment\ClassPropertiesExample>csc ClassProperties.cs
csc ClassProperties.cs
Microsoft (R) Visual C# .NET Compiler version 7.10.3052.4
for Microsoft (R) .NET Framework version 1.1.4322
Copyright (C) Microsoft Corporation 2001-2002. All rights reserved.

// Run
h:\vault\learn\pcc\cis234n\Part3Assignment\ClassPropertiesExample>ClassProperties.exe
ClassProperties.exe
Test CScreenPosition
   Before assignment (0,0)
   After assignment (55,50)
Test PScreenPosition with constructor
   Before assignment (65,45)
   After assignment (65,50)
Test PScreenPosition with default constructor
   Before assignment (0,0)
   After assignment (0,50)
Test FScreenPosition
   Before assignment (0,0)
   After assignment (55,50)
