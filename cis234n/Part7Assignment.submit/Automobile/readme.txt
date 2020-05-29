New readme.txt
===============
This project involves investigating what it takes to use NUnit as a unit
testing harness. 

The tasks done include:

- Installed NUnit 2.2 ( www.nunit.org )
- Studied documentation
     getstarted.html
- Worked through sample projects
     Account
     MoneyTest
- Studied additional materials at 
     Test-driven C# ( http://msdn.microsoft.com/msdnmag/issues/04/04/ExtremeProgramming/default.aspx )
     Test Driven Development ( http://www.codeproject.com/dotnet/tdd_in_dotnet.asp )
- Figured out how to compile with Nunit framework on the console
     Turned Automobile.exe into Automobile.dll
     Made Circuit object a test fixture
     Created a test case FirstTest
- Ran Nunit in GUI mode
     See automobile.bmp
- Ran Nunit in console mode
     See transcript below

Lessons and results:
1) NUnit is a unit test and it does not have facilities
   for GUI testing. In fact, it recommends rearchitecting GUI applications
   so that the GUI logic can be tested with a simple interface instead of
   pressing GUI buttons.
2) To convert the existing Automobile code into an NUnit project, the
   executable Automobile.exe has to be recompiled as a library Automobile.dll.
   Then the Circuit object as made into a test fixture and a test case, FirstTest
   was created to reuse old test code.
3) The Nunit in GUI mode was easy to use, and a run is captured in automobile.bmp.
4) Figured out how to compile with NUnit on the console. This is instructive
   because it reveals the pieces hidden by the NUnit GUI.


Transcript of console build and nunit-console usage:
   | Part7Assignment\Automobile>csc /target:library /lib:o:/dev/nunit22/bin /r:nunit.framework.dll automobile.cs
   | csc /target:library /lib:o:/dev/nunit22/bin /r:nunit.framework.dll automobile.cs
   | Microsoft (R) Visual C# .NET Compiler version 7.10.3052.4
   | for Microsoft (R) .NET Framework version 1.1.4322
   | Copyright (C) Microsoft Corporation 2001-2002. All rights reserved.
   | 
   | 
   | Part7Assignment\Automobile>nunit-console automobile.dll
   | nunit-console automobile.dll
   | NUnit version 2.2.0
   | Copyright (C) 2002-2003 James W. Newkirk, Michael C. Two, Alexei A. Vorontsov, Charlie Poole.
   | Copyright (C) 2000-2003 Philip Craig.
   | All Rights Reserved.
   | 
   | OS Version: Microsoft Windows NT 5.0.2195.0    .NET Version: 1.1.4322.573
   | 
   | .N.Running Automobile
   | Start of circuit, did not finish drive of 0 miles,  Car:rx7 Tank:0
   | After filling up,  Car:rx7 Tank:10
   | After driving 14.7 miles,  Car:rx7 Tank:8.53
   | After driving 60.7 miles,  Car:rx7 Tank:2.46
   | Oh oh! Out of gas
   | After driving 33.7 miles, did not finish drive of 33.7 miles,  Car:rx7 Tank:0
   | 
   | Tests run: 1, Failures: 0, Not run: 1, Time: 0.015625 seconds
   | 
   | Tests not run:
   | 1) Automobile.Circuit.testDrive1 : Method testDrive1's signature is not correct: it must be an instance method.
   | 
 
Original readme.txt for Week 2
===============================
Since this is a console application, I have dispensed completely with
VS .NET's solution and project overhead and just provided the source
and executable.

The advantage is smaller download.

Sample Transcript
------------------
// Compile
h:\vault\learn\pcc\cis234n\Part2Assignment\Automobile>csc automobile.cs
csc automobile.cs
Microsoft (R) Visual C# .NET Compiler version 7.10.3052.4
for Microsoft (R) .NET Framework version 1.1.4322
Copyright (C) Microsoft Corporation 2001-2002. All rights reserved.

// Run
h:\vault\learn\pcc\cis234n\Part2Assignment\Automobile>automobile.exe
automobile.exe
Running Automobile
Start of circuit, did not finish drive of 0 miles,  Car:rx7 Tank:0
After filling up,  Car:rx7 Tank:10
After driving 14.7 miles,  Car:rx7 Tank:8.53
After driving 60.7 miles,  Car:rx7 Tank:2.46
Oh oh! Out of gas
After driving 33.7 miles, did not finish drive of 33.7 miles,  Car:rx7 Tank:0
