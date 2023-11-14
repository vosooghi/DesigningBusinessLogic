using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnemicDomainModel.Domain
{
    public class Person
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string shortName { get { return Name.Substring(0, 2); } }
    }
}
