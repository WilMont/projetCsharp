using projetCsharp.Models.DAL;
using projetCsharp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCsharp.Models.DAO
{
    class ClientDAO
    {
        public int idClientDAO;
        public string nomClientDAO;
        public string prenomClientDAO;
        public string mailClientDAO;
        public string adresseClientDAO;
        public int pointsfClientDAO;

        public ClientDAO(int idClientDAO, string nomClientDAO, string prenomClientDAO, string mailClientDAO, string adresseClientDAO, int pointsfClientDAO)
        {
            this.idClientDAO = idClientDAO;
            this.nomClientDAO = nomClientDAO;
            this.prenomClientDAO = prenomClientDAO;
            this.mailClientDAO = mailClientDAO;
            this.adresseClientDAO = adresseClientDAO;
            this.pointsfClientDAO = pointsfClientDAO;
        }

        public static ObservableCollection<ClientDAO> listeClients()
        {
            ObservableCollection<ClientDAO> l = ClientDAL.selectClient();
            return l;
        }

        public static ClientDAO getClient(int idClient)
        {
            ClientDAO p = ClientDAL.getClient(idClient);
            return p;
        }

        public static void updateClient(ClientViewModel p)
        {
            ClientDAL.updateClient(p.idClientProperty, p.nomClientProperty, p.prenomClientProperty, p.mailClientProperty, p.adresseClientProperty, p.pointsfClientProperty);
        }

        public static void supprimerClient(int id)
        {
            ClientDAL.supprimerClient(id);
        }

        public static void insertClient(ClientViewModel p)
        {
            ClientDAL.updateClient(p.idClientProperty, p.nomClientProperty, p.prenomClientProperty, p.mailClientProperty, p.adresseClientProperty, p.pointsfClientProperty);
        }
    }
}
