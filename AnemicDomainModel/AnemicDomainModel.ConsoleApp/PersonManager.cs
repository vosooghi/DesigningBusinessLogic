using AnemicDomainModel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnemicDomainModel.ConsoleApp
{
    public class PersonManager
    {
        public bool RegisterPerson(Person person)
        {
            if (person == null) throw new ArgumentNullException();
            else
            {
                //Validatation
                //Save to DB
            }
            return true;
        }
    }
}
