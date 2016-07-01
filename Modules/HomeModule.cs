using System.Collections.Generic;
using CdList.Objects;
using Nancy;

namespace ToDoList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
          return View["index.cshtml"];
      };Get["/add_contact"] = _ => {
          return View["add_contact.cshtml"];
      };
      Post["/add_new_cd"] = _ =>{
        List<Contact> allContacts = Contact.GetAllContacts();
        int ContactIndex=-1;
        if (allContacts.Count > 0)
        {
          ContactIndex = Contact.Find(Request.Form["new-Contact"]);
        }
        if (ContactIndex == -1){
          Contact newContact = new Contact(Request.Form["new-Contact"]);
          newContact.Addperson(Request.Form["new-person"]);
          return View["Contact_details.cshtml", newContact];
        } else {
          Contact newContact = allContacts[ContactIndex];
          newContact.Addperson(Request.Form["new-person"]);
          return View["Contact_details.cshtml", newContact];
        }
        // return View["Contact_details.cshtml", newContact];
      };
      // Get["/Contact_details"] = _ =>{
      //   Contact newContact = new Contact(Request.Form["new-Contact"]);
      //   newContact.Addperson(Request.Form["new-person"]);
      //   return View["Contact_details.cshtml", newContact];
      // };
      Get["/{detailsContact}"] = parameters => {
        List<Contact> allContacts = Contact.GetAllContacts();
        Contact currentContact = allContacts [Contact.Find(parameters.detailsContact)];
        return View ["Contact_details.cshtml", currentContact];
      };
      Get["/view_all_Contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAllContacts();
        return View["view_all_Contacts.cshtml", allContacts];
      };
      Post["/search_list"] = _ => {
        List<Contact> searchedList = Contact.SearchContacts(Request.Form["search-Contact"]);
        return View["view_all_Contacts.cshtml", searchedList];
      };
      Get["/search_form"] = _ =>{
        return View["search_form.cshtml"];
      };
    }
  }
}
