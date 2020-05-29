// $Id: Automobile.cs,v 1.3 2005/11/22 05:51:38 khtan Exp $
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date: 2005/11/22 05:51:38 $">
using System;
using NUnit.Framework;

using miles=System.Single;
using gallons=System.Single;
using milesPerGallon=System.Single;

namespace Automobile{
  /// <summary>Interface for filling up gasoline</summary>
  /// <remarks>For convenience, aliases for miles, gallons and milesPerGallon units are used.</remarks>
  interface IMaintenance{
    /// <summary>Fill up fuel tank</summary>
    /// <param name="numGallons">Fill up with numGallons of gasoline</param>
     void fillUp(gallons numGallons);
  }//interface IMaintenance
  /// <summary>Abstract class to provide basic implementation for filling up and driving.
  /// Has name and fuel tank to keep track of.
  /// </summary>
  abstract public class Vehicle{
    /// <summary>Constructor</summary>
    /// <param name="name">Name of car</param>
    /// <param name="gasRate">Consumption rate of of car</param>
    public Vehicle(string name,float gasRate){ 
      this.name=name;
      fuelTank=0.0f;
      consumptionRate=gasRate;
    }
    /// <summary>Drives and consumes gasoline</summary>
    /// <param name="numMiles">No of miles to drive</param>
    /// <returns>Remaining capacity in fuel tank</returns>
    public gallons drive(miles numMiles){
       float gasConsumed=numMiles/consumptionRate;
       fuelTank-=gasConsumed;
       if(fuelTank<0.0f){
          Console.WriteLine("Oh oh! Out of gas");
          fuelTank=0.0f;
       }
       return fuelTank;
    }
    /// <summary>Fill up fuel tank</summary>
    /// <param name="numGallons">Amount of gasoline to add</param>
    public void fillUp(gallons numGallons){
      fuelTank+=numGallons;
    }
    /// <summary>Name of car</summary>
    protected string name;
    /// <summary>Fuel tank</summary>
    protected gallons fuelTank;
    /// <summary>Consumption rate of fuel of car</summary>
    public readonly milesPerGallon consumptionRate;
  }//class Vehicle
  /// <summary>Instantiable car</summary>
  /// <see cref="IMaintenance"/>
  /// <see cref="Vehicle"/>
  sealed class Automobile:Vehicle,IMaintenance{
     /// <summary>Sole constructor</summary>
     public Automobile():base("unknown",1.0f){
     }
     public Automobile(string name,milesPerGallon rate):base(name,rate){
     }
     /// <summary>Routine to print status of car</summary>
     /// <param name="msg">Message to display</param>
     public void dump(string msg){
       Console.WriteLine("{2} Car:{0} Tank:{1}",name,fuelTank,msg);
     }
     public string dumpStr(string msg){
       return msg+" Car:"+name+" Tank:"+fuelTank;
     }
   }
  /// <summary>Test circuit</summary>
  [TestFixture]
  public class Circuit{
     [STAThread]
     // Bug : VS Comment web report does not pick these comments
     /// <summary>Drive a certain distance and print car status</summary>
     /// <param name="car">Reference to car object</param>
     /// <param name="numMiles">Distance to drive</param>
     /// <param name="msg">Message to display</param>
     static void driveAndPrint(Automobile car,miles numMiles,string msg){
       if(car.drive(numMiles)>0.0){
         car.dump(msg);
       }else{
         car.dump(msg+"did not finish drive of "+numMiles+" miles, ");
       }
     }
     /// <summary>Drive a certain distance</summary>
     /// <param name="car">Reference to car object</param>
     /// <param name="numMiles">Distance to drive</param>
     static void driveAndPrint(Automobile car,miles numMiles){
       driveAndPrint(car,numMiles,"After driving "+numMiles+" miles, ");
     }
     /// <summary>Routine of test drive</summary>
     /// <param name="car">Reference to car object</param>
     [Ignore("Internal driver")]
     static void testDrive1(Automobile car){
       driveAndPrint(car,0,"Start of circuit, ");
          Assert.AreEqual("Start of circuit Car:rx7 Tank:0",car.dumpStr("Start of circuit"),"Start of circuit");
       car.fillUp(10.0f);
          Assert.AreEqual("After filling up Car:rx7 Tank:10",car.dumpStr("After filling up"),"After filling up");
       driveAndPrint(car,0,"After filling up, ");
       driveAndPrint(car,14.7f);
       driveAndPrint(car,60.7f);
       driveAndPrint(car,33.7f);
     }
        /// <summary>Main entry point, serves to catch all unanticipated exceptions</summary>
     [Test]
     public void FirstTest(){
       // static void Main(string[] args){
       try{
         Console.WriteLine("Running Automobile");
         Automobile rx7=new Automobile("rx7",10.0f);
         testDrive1(rx7);
       }catch(Exception e){
            Console.WriteLine("Unhandled System.Exception! "+e.Message);
       }catch{ 
            Console.WriteLine("non-CLSCompliant exception!");
       }
     }
  }//class Circuit
}//namespace Automobile
