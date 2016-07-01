using System.Collections.Generic;

namespace CdList.Objects
{
  public class Contact
  {
    private string _Contact;
    private List<string> _persons = new List<string> {};
    private static List<Contact> _Contacts = new List<Contact> {};
    public Contact (string newContact)
    {
      _Contact = newContact;
      _persons = new List<string>{};
      _Contacts.Add(this);
    }
    public string GetContact()
    {
      return _Contact;
    }
    public void Addperson(string newperson)
    {
      _persons.Add(newperson);
    }
    public List<string> Getpersons()
    {
      return _persons;
    }
    // public List<String> GetAllContacts()
    // {
    //   return _Contacts;
    // }
    public static List<Contact> GetAllContacts()
    {
      return _Contacts;
    }
    public static int Find(string searchContactName)
    {
      int counter=0;
      int searchIndex=-1;
      foreach(var Contact in _Contacts)
      {
        if(Contact.GetContact()==searchContactName)
        {
          searchIndex=counter;
        }
        counter++;
      }
      return searchIndex;
    }
    public static List<Contact> SearchContacts(string searchTerm)
    {
      List<Contact> searchedList = new List<Contact> {};
      foreach(var Contact in _Contacts)
      {
        if (Contact.GetContact().ToLower().Contains(searchTerm.ToLower()))
        {
          searchedList.Add(Contact);
        }
      }
      return searchedList;
    }
  }
}
