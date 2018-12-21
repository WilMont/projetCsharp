using projetCsharp.Models.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCsharp.ViewModels
{
    class ClientViewModel
    {
        public int idClient;
        public string nomClient;
        public string prenomClient;
        public string mailClient;
        public string adresseClient;
        public int pointsfClient;
        //private int tutu;
        private string concat;
        //public MetierViewModel metierPersonne;

        public ClientViewModel() { }

        public ClientViewModel(int idClient, string nomClient, string prenomClient, string mailClient, string adresseClient, int pointsfClient)
        {
            this.idClient = idClient;
            this.nomClient = nomClient;
            this.prenomClient = prenomClient;
            this.mailClient = mailClient;
            this.adresseClient = adresseClient;
            this.pointsfClient = pointsfClient;
            //metierClient = metier;
        }
        public int idClientProperty
        {
            get { return idClient; }
        }

        public String nomClientProperty
        {
            get { return nomClient; }
            set
            {
                nomClient = value.ToUpper();
            }
        }
        public String prenomClientProperty
        {
            get { return prenomClient; }
            set
            {
                this.prenomClient = value;
            }
        }
        public String mailClientProperty
        {
            get { return mailClient; }
            set
            {
                mailClient = value;
            }
        }
        public String adresseClientProperty
        {
            get { return adresseClient; }
            set
            {
                adresseClient = value;
            }
        }
        public int pointsfClientProperty
        {
            get { return pointsfClient; }
            set
            {
                pointsfClient = value;
            }
        }


        /* public string metierProperty
        {
            get { return metierPersonne.libMetier; }
        } */


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                ClientDAO.updateClient(this);
            }
        }
    }
}