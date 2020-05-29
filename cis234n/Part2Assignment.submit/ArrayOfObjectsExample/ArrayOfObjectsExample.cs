// $Id: ArrayOfObjectsExample.cs,v 1.3 2005/10/08 04:48:59 khtan Exp khtan $
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date: 2005/10/08 04:48:59 $">
using System;

namespace ArrayOfObjectsExample{
  /// <summary>
  /// This file is derived from the ArrayOfObjectsExample Windows Form project, as
  /// per assignment instructions. The steps used were :
  ///   1) Cartoon.cs - Copied entire Cartoon class into this file.
  ///   2) Form1.cs - Created class Driver and copied code of button1_Click into run() method
  ///               - Replaced listBox1.Items.Add with Console.WriteLine
  ///               - Write Main to call run() method
  ///   3) Confirmed code compiles and runs like Windows Form example.
  ///   4) Replaced Cartoon class with own class, called Position
  ///   5) Confirmed code compiles and runs
  /// </summary>
  /// <summary>Simple position object for 2 dimensional coordinate system</summary>
  public class Position{
    /// <summary>Default constructor</summary>
    public Position(){x=0;y=0;}
    /// <summary>Constructor for x and y coordinates</summary>
    public Position(int XX, int YY){x=XX;y=YY;}
    /// <summary>Property X for private x</summary>
    public int X{
      get{return this.x;}
      set{this.x = value;}
    }
    /// <summary>Property Y for private y</summary>
    public int Y{
      get{return this.y;}
      set{this.y = value;}
    }
    /// <summary>Convert to string</summary>
    public string toString(){
      return "("+x+","+y+")";
    }
    /// <summary>x coordinate</summary>
    private int x;
    /// <summary>y coordinate</summary>
    private int y;
  }//class Position
  ///<summary>Simple driver class for unit tests</summary>
  public class Driver{
    [STAThread]
    ///<summary>Simple Main entry point to catch unanticipate exceptions</summary>
    public static void Main(){
      try{
        run();
      }catch(Exception e){
        Console.WriteLine("Unhandled System.Exception! "+e.Message);
      }catch{ 
        Console.WriteLine("Non-CLSCompliant exception!");
      }
    }
    ///<summary>Simple unit test</summary>
    public static void run(){
      int next = 0;

      //Create object reference for a Position object
      Position p;

      //an array of Position objects. It's empty at this point.
      Position[] arrayOfPositions = new Position[2];
			
      //create a Position object and add it to the array
      p = new Position(5,10);
      arrayOfPositions[next] = p;
      next++;
      p = null;

      //create another one and add it
      p = new Position(27,36);
      arrayOfPositions[next]=p;
      next++;
      p = null;

      //display each object in the array in a listbox
      foreach (Position cc in arrayOfPositions){
        Console.WriteLine(cc.toString()); 
      }
    }
  }//class Driver
}
