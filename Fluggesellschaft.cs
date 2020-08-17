using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    class Fluggesellschaft
    {

        public string Bezeichnung { get; set; }
        public int IataCode { get; set; }

        public Fluggesellschaft(int iataCode, string bezeichnung)
        {
            IataCode = iataCode;
            Bezeichnung = bezeichnung;
        }

    }

}
