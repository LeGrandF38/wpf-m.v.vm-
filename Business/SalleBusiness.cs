using Demo2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2.Business
{
    public class SalleBusiness
    {

        #region proprietes
        public ObservableCollection<Salle> ListOfObject { get; set; }
        public Salle SelectedItem { get; set; }
        public string BusinessLabel  { get; set; }
        public string AddButton { get; set; }
        public string EditButton { get; set; }
        public string RemoveButton { get; set; }
        #endregion
        #region constructeur
        public SalleBusiness()
        {
            BusinessLabel = "Gestion Salles";
            AddButton = "Ajouter Salle";
            EditButton = "Editer Salle";
            RemoveButton = "Supprimer Salle";
            ListOfObject = new ObservableCollection<Salle>();

            for (int i = 0; i < 10; i++)
            {
                Salle salle = new Salle();
                salle.Id = i;
                salle.Number = "salle numero " + i.ToString();

                ListOfObject.Add(salle);
            }
        }
        #endregion


    }
}
