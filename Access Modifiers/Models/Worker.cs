using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers.Models
{
    class Worker:User
    {
        public Worker(string userName,bool isAdmin, string email, bool isVip) 
        {
            this.userName = userName;
            this.isAdmin = true;
            this.eMail = "saoidjasoidj@aoidjsaoidj.com";
            this.isVip = false;

        }
    }
}
