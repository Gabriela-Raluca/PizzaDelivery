using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    [Serializable]
    class Pizza
    {
        public string denumire;
        public string ingrediente;
        public float pret;
        public string poza;

        public Pizza()
        {
            denumire = "";
            ingrediente = "";
            pret = 0;
            poza = null;
        }
        
    public Pizza(string den,string ingred, float prt,string poz)
    {
        denumire = den;
        ingrediente = ingred;
        pret = prt;
        poza = poz;
    }
    
    }

}
