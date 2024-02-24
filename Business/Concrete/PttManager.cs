using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierServices
    {
        private IApplicantServices _applicantServices;

        public PttManager(IApplicantServices applicantServices)
        {
            _applicantServices = applicantServices;
        }


        public void GiveMask(Person person)
        {
            if (_applicantServices.CheckPerson(person))
            {
                Console.WriteLine($"Maske verildi:{person.FirstName} ");
            }
            else
            {
                Console.WriteLine("Maske verilemedi");
            }
        }
    }
}
