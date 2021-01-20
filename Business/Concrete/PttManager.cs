using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IAplicantService _aplicantService;


        public PttManager(IAplicantService applicantService)
        {
            _aplicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            PttManager pttManager = new PttManager(new PersonManager());
            if (_aplicantService.CheckPerson(person)) 
            {
                Console.WriteLine(person.FirstName+" için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName+" için maske verilemedi");
            }
        }
    }
}
