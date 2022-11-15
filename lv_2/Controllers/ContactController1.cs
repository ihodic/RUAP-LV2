using lv_2.Models;
using lv_2.Services;
using Microsoft.AspNetCore.Mvc;

namespace lv_2.Controllers
{
    public class ContactController1 : Controller
    {
        private ContactRepository contactRepository;
        public ContactController1()
        {
            this.contactRepository = new ContactRepository();
        }
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();

        }
    }
}
