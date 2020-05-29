// $Id: a4DataObject.cs 10 2005-10-22 22:54:03Z khtan $
// <author value="Kwee Heong Tan">
// <course value="cis234n">
// <date value="$Date: 2005-10-22 15:54:03 -0700 (Sat, 22 Oct 2005) $">
using System;

namespace a4{
  /// <summary>
  /// The object should contain three fields: LastName, AccountNumber, and a boolean field ValidAccountNumber.
  /// The prefix a4 ( for assignment 4) was used because System has a class called DataObject
  ///  See fuller documentation in readme.txt
  /// </summary>
  public class a4DataObject{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    public void dump(){
      Console.WriteLine("ln={0} an={1} van={2}",lastname,accountnumber,validaccountnumber);
    }
    public string toString(){
      string sValue="LastName:"+lastname+" AccountNumber:"+accountnumber+" ValidAccountNumber:"+validaccountnumber;
      return sValue;
    }
    public string LastName{
      get{
        return this.lastname;
      }
      set{
        this.lastname=value;
      }
    }

    public int AccountNumber{
      get{
        return this.accountnumber;
      }
      set{
        this.accountnumber=value;
      }
    }

    public bool ValidAccountNumber{
      get{
      return this.validaccountnumber;
      }
      set{
      this.validaccountnumber=value;
      }
    }
  private string lastname;
  private int accountnumber;
  private bool validaccountnumber;
  }//class
}
