// $Id: ClassProperties.cs,v 1.3 2005/10/15 19:09:44 khtan Exp $
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date: 2005/10/15 19:09:44 $">
using System;
/* Assignment 3:
   
   Use the Class Properties code sample as a guide. It contains a
   Tester class and a Person class. Create a new console application
   that contains two classes. A tester class and, instead of the
   Person class, a class of your choice.  In your class create at
   least two properties. In the Tester class, create a few objects of
   your class and make sure the properties work. 

   Based on the above, this program seeks to understand the differences of using
   properties in a struct and in a class, and the differences
   between using fields and properties.

   Three implementations are created - 
      PScreenPosition : properties implemented in struct
      CScreenPosition : properties implemented in class
      FScreenPosition : fields implemented in struct
 */

namespace ClassProperties{
  /// <summary>ScreenPosition implemented with class</summary>
  class CScreenPosition{
    public CScreenPosition(){
      x=y=0;
    }
    /// <summary>Constructor</summary>
    public CScreenPosition(int X, int Y){
      x = rangeCheckedX(X);
      y = rangeCheckedY(Y);
    }
    /// <summary>Simple dump</summary>
    public void dump(string msg){
      Console.WriteLine("{2} ({0},{1})",x,y,msg);
    }
    /// <summary>Read/write property X</summary>
    public int X{
      get { return x; }
      set { x = rangeCheckedX(value); }
      /* Cannot have other functions, etc
         void hello(){
         Console.WriteLine("hello");
         }
      */
    }
    /// <summary>Read/write property Y</summary>
    public int Y{
      get { return y; }
      set { y = rangeCheckedY(value); }
    }
    /// <summary>Validate X values</summary>
    /// <param name="x">value of x</param>
    /// <returns>validated X value</returns>
    private static int rangeCheckedX(int x){
      if (x < 0 || x > 600){
        throw new ArgumentOutOfRangeException("X");
      } 
      return x;
    }
    /// <summary>Validate Y values</summary>
    /// <param name="y">value of y</param>
    /// <returns>validated Y value</returns>
    private static int rangeCheckedY(int y){
      if (y < 0 || y > 800){
        throw new ArgumentOutOfRangeException("Y");
      }
      return y; 
    }
    private int x, y;
  }
  /// <summary>ScreenPosition implemented with properties</summary>
  struct PScreenPosition{
    // cannot define default constructor, compiler will define one always
    public PScreenPosition(int X, int Y){
      x = rangeCheckedX(X);
      y = rangeCheckedY(Y);
    }
    public void dump(string msg){
      Console.WriteLine("{2} ({0},{1})",x,y,msg);
    }
    public int X{
      get { return x; }
      set { x = rangeCheckedX(value); }
    }
    public int Y{
      get { return y; }
      set { y = rangeCheckedY(value); }
    }
    private static int rangeCheckedX(int x){
      if (x < 0 || x > 600){
        throw new ArgumentOutOfRangeException("X");
      } 
      return x;
    }
    private static int rangeCheckedY(int y){
      if (y < 0 || y > 800){
        throw new ArgumentOutOfRangeException("Y");
      }
      return y; 
    }
    private int x, y;
  }
  /// <summary>ScreenPosition implemented with fields</summary>
  struct FScreenPosition{
    // cannot define default constructor, compiler will define one always
    public FScreenPosition(int x, int y){
      X = rangeCheckedX(x);
      Y = rangeCheckedY(y);
    }
    public void dump(string msg){
      Console.WriteLine("{2} ({0},{1})",X,Y,msg);
    }
    private static int rangeCheckedX(int x){
      if (x < 0 || x > 600){
        throw new ArgumentOutOfRangeException("X");
      } 
      return x;
    }
    private static int rangeCheckedY(int y)    {
      if (y < 0 || y > 800){
        throw new ArgumentOutOfRangeException("Y");
      }
      return y; 
    }
    // fields with public access, breaking encapsulation, though
    public int X;
    public int Y;

  }
  /// <summary>Test class with unit test methods</summary>
  class Test{
    static void test1(string msg){
      Console.WriteLine(msg);
      PScreenPosition topLeft = new PScreenPosition(65, 45);
      topLeft.dump("   Before assignment");
      topLeft.Y = 50;
      topLeft.dump("   After assignment");
    }
    static void test2(string msg){
      Console.WriteLine(msg);
      PScreenPosition topLeft = new PScreenPosition();
      topLeft.dump("   Before assignment");
      topLeft.Y = 50;
      topLeft.dump("   After assignment");
    }
    static void test3(string msg){
      /* PScreenPosition topLeft(20,30);
         This line seeks to instantiate an initialized PScreenPosition
         Error message: error CS1528: Expected ; or = (cannot specify constructor arguments in declaration)
      */

      /* PScreenPosition topLeft;
         This line seeks to instantiate an uninitialized PScreenPosition
         Error message : error CS0165: Use of unassigned local variable 'topLeft'
      */
    }
    static void test3a(string msg){
      Console.WriteLine(msg);
      FScreenPosition topLeft=new FScreenPosition();
      topLeft.dump("   Before assignment");
      topLeft.Y = 50;
      topLeft.X = 55;
      topLeft.dump("   After assignment");
    }
    static void test4(string msg){
      Console.WriteLine(msg);
      CScreenPosition topLeft=new CScreenPosition();
      topLeft.dump("   Before assignment");
      topLeft.Y = 50;
      topLeft.X = 55;
      topLeft.dump("   After assignment");
    }

    static public void Main(){
      try{
        test4("Test CScreenPosition");
        test1("Test PScreenPosition with constructor");
        test2("Test PScreenPosition with default constructor");
        test3a("Test FScreenPosition");
      }catch(ArgumentOutOfRangeException e){
        Console.WriteLine(e.Message);
      }
    }
  }
}//namespace ClassProperties
/* CONCLUSION:
   If a struct has public fields, it can be declared first, then initialized
   FScreenPosition topLeft;
   topLeft.X=50;
   topLeft.Y=55;
   // Now can use topLeft.

   If a struct has private fields, it cannot be declared first then initialized
   because the fields cannot be accessed. It can only be instantiated with 
   the constructor call, ie
   FScreenPosition topLeft=new FScreenPosition(); // default constructor
   FScreenPosition topLeft=new FScreenPosition(4,6); // user constructor

   If a struct has private fields with public property access, it still cannot
   be declared first, then initialized because property is not designed to allow
   access to uninitialized field. So, again we need to use the default or user
   constructor syntax.
 */
