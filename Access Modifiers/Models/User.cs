using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers.Models
{
    class User
    {
        public long Id { get; } //Sadece get var (Readonly)
        public string userName { get; set; }
        public string surName { get; set; }
        public string eMail { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public float Level { get; set; }
        private bool isVip
        {
            get
            {
                return isVip;
            }
            set 
            { 
                isVip = value;
            }
        }
        public bool isAdmin { get; } //Sadece get var (Readonly)
        public string profileUrl { get; set; }


    }
}
