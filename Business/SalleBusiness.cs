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
        public ObservableCollection<Salle> ListOfSalle { get; set; }
        #endregion
        #region constructeur
        public SalleBusiness()
        {
            ListOfSalle = new ObservableCollection<Salle>();

            for (int i = 0; i < 10; i++)
            {
                Salle salle = new Salle();
                salle.Id = i;
                salle.Number = "salle numero " + i.ToString();

                ListOfSalle.Add(salle);
            }
        }
        #endregion


    }
}
