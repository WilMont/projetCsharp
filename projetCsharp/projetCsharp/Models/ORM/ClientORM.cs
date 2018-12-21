using projetCsharp.Models.DAO;
using projetCsharp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCsharp.Models.ORM
{
    class ClientORM
    {

        public static ClientViewModel getClient(int idClient)
        {
            ClientDAO cDAO = ClientDAO.getClient(idClient);
            ClientViewModel c = new ClientViewModel(cDAO.idClientDAO, cDAO.nomClientDAO, cDAO.prenomClientDAO, cDAO.mailClientDAO, cDAO.adresseClientDAO, cDAO.pointsfClientDAO);
            return c;
        }

        public static ObservableCollection<ClientViewModel> listeClients()
        {
            ObservableCollection<ClientDAO> lDAO = ClientDAO.listeClients();
            ObservableCollection<ClientViewModel> l = new ObservableCollection<ClientViewModel>();
            foreach (ClientDAO element in lDAO)
            {
                ClientViewModel c = new ClientViewModel(element.idClientDAO, element.nomClientDAO, element.prenomClientDAO, element.mailClientDAO, element.adresseClientDAO, element.pointsfClientDAO);
                l.Add(c);
            }
            return l;
        }
    }
}
