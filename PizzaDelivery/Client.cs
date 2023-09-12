using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    class Client
    {
        private string nume;
        private string prenume;
        private string cnp;
        private string sex;
        private string email;
        private int varsta;
        

        public Client()
        {
        }

        public Client(string nume_c, string prenume_c, string cnp_c, string sex_c, string email_c, int varsta_c)
        {
            nume = nume_c;
            prenume = prenume_c;
            cnp = cnp_c;
            sex = sex_c;
            email = email_c;
            varsta = varsta_c;
            
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set {  prenume = value; }
        }
        public string Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }

        }
        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }

        }
    }
}
