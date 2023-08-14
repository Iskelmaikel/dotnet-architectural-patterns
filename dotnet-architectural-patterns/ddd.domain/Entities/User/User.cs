using ddd.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd.domain.Entities.User
{
    public partial class User : BaseEntity
    {
        public string UserName { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public DateTime? BirthDate { get; private set; }
        
        public User() {
        
        }
    }
}
