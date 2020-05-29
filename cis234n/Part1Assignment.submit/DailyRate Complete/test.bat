rem $Id: test.bat,v 1.1 2005/09/29 16:36:59 khtan Exp khtan $
@echo off
echo "Test: good.input"
bin\debug\dailyrate.exe < good.input
echo "-------------------------------------"
echo "Test: badrate.input"
bin\debug\dailyrate.exe < badrate.input
echo "-------------------------------------"
echo "Test: baddays.input"
bin\debug\dailyrate.exe < baddays.input
echo "-------------------------------------"
echo "Test: controlchars.input"
bin\debug\dailyrate.exe < controlchars.input
echo "-------------------------------------"
echo "Test: largenum.input"
bin\debug\dailyrate.exe < largenum.input
echo "-------------------------------------"
echo "Test: negrate.input"
bin\debug\dailyrate.exe < negrate.input
echo "-------------------------------------"
echo "Test: negday.input"
bin\debug\dailyrate.exe < negday.input
