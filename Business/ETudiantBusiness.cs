using Demo2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.Business
{
    public class ETudiantBusiness
    {
        //public List<Etudiant>   ListOfStudent { get; set; }
        public ObservableCollection<Etudiant> ListOfObject { get; set; }

        public Etudiant SelectedItem { get; set; }
        public string BusinessLabel { get; set; }
        public string AddButton { get; set; }
        public string EditButton { get; set; }
        public string RemoveButton { get; set; }

        public ETudiantBusiness()
        {
            BusinessLabel = "Gestion Etudiant";
            AddButton = "Ajouter Etudiant";
            EditButton = "Editer Etudiant";
            RemoveButton = "Supprimer Etudiant";
            ListOfObject = new ObservableCollection<Etudiant>();

            for (int i = 0; i < 5; i++) 
            {
                Etudiant etudiant = new Etudiant();
                etudiant.Id = i;
                etudiant.Email = "email@gamil.com  : " + i.ToString();

                ListOfObject.Add(etudiant);    
            }
        }
    }
}
