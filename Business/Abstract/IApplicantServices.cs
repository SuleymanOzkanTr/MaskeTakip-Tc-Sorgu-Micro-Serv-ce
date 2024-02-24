using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicantServices
    {
        void ApplyMask(Person  person);
        bool CheckPerson(Person person);
        List<Person> GetAllPersons();
    }
}
