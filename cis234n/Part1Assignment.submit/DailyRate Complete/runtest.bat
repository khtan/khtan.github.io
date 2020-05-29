rem $Id: runtest.bat,v 1.2 2005/09/29 16:40:13 khtan Exp $
@echo off
call test.bat > test.out
fc /w test.out test.ref


