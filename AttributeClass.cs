using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Lab
{
    public class DevAttribute : System.Attribute
    {
        private int identifier;
        private string firstname, lastname;


        public DevAttribute(int identifier, string firstname, string lastname)
        {
            this.identifier = identifier;
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public virtual string FirstName
        {
            get { return firstname; }
        }

        public virtual string LastName
        {
            get { return lastname;}
        }

        public virtual int ID
        {
            get { return identifier; }
        }
    }
}
