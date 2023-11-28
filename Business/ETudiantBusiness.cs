using Demo2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.Business
{
    public class ETudiantBusiness
    {
        public List<Etudiant>   ListOfStudent { get; set; }
        public ETudiantBusiness()
        {
            ListOfStudent = new List<Etudiant>();

            for (int i = 0; i < 10; i++) 
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Id = i;
                etudiant.Email = "email@gamil.com  : " + i.ToString();

                ListOfStudent.Add(etudiant);    
            }
        }
    }
}
