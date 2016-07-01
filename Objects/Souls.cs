using System.Collections.Generic;

namespace CdList.Objects
{
  public class Cd
  {
    private string _personTitle;
    // private string _Contact;
    // private static List<string> _Contacts = new List<string> {};
    // private static List<Cd> _cds = new List<Cd> {};
    public Cd (string personTitle)
    {
      _personTitle=personTitle;
      // _Contact=Contact;
      // _Contacts.Add(_Contact);
      // _cds.Add(this);
    }
    // public string GetContact()
    // {
    //   return _Contact;
    // }
    public string Getperson()
    {
      return _personTitle;
    }
    // public List<String> GetAllContacts()
    // {
    //   return _Contacts;
    // }
    // public static List<Cd> GetAllCds()
    // {
    //   return _cds;
    // }
  }
}
