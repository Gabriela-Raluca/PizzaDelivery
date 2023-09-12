using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery
{
    class ExceptieVal: Exception
    {
        public override string Message
        {
            get { return "Excepție la validarea datelor. Introduceți vârsta!"; }
        }
    }
}
