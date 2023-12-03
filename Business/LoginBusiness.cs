using Demo2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.Business
{
    public class LoginBusiness
    {
        public Etudiant etudiant { get; set; }

        

        public LoginBusiness()
        {
            etudiant = new Etudiant();
            
        }
    }
}
