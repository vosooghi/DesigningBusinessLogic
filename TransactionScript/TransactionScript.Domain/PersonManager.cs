using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionScript.Domain
{
    public class PersonManager
    {
        //In transaction script, for each command there is a method 
        public bool RegisterPerson(string firstName, string lastName)
        {
            //input validation
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException();
            }
            else
            {
                //Business Logic
                firstName = firstName.Trim();
                lastName= lastName.Trim();
                
                //DAL code, save to DB

            }

            return true;
        }
    }
}
