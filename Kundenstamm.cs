using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    class Kundenstamm : IContainer
    {
        private ArrayList _kundenList;
        public string Fluggesellschaft { get; set; }

        public Kundenstamm(string fluggesellschaft)
        {
            _kundenList = new ArrayList();
            this.Fluggesellschaft = fluggesellschaft;
        }

        public virtual void Add(IComponent kunde)
        {
            // Ein Kunde wird ohne Erstellung eines KundennummerSite Objektes hinzugefuegt.
            _kundenList.Add(kunde);
        }

        public virtual void Add(IComponent kunde, string kundennummer)
        {
            for (int i = 0; i < _kundenList.Count; ++i)
            {
                IComponent curObj = (IComponent)_kundenList[i];
                if (curObj.Site != null)
                {
                    if (curObj.Site.Name.Equals(kundennummer))
                        throw new ArgumentException("Diese Kundennummer existiert bereits im Kundenstamm.");
                }
            }

            KundennummerSite data = new KundennummerSite(this, kunde);
            data.Name = kundennummer;
            kunde.Site = data;
            _kundenList.Add(kunde);
        }

        public virtual void Remove(IComponent kunde)
        {
            for (int i = 0; i < _kundenList.Count; ++i)
            {
                if (kunde.Equals(_kundenList[i]))
                {
                    _kundenList.RemoveAt(i);
                    break;
                }
            }
        }

        public ComponentCollection Components
        {
            get
            {
                IComponent[] datalist = new Kunde[_kundenList.Count];
                _kundenList.CopyTo(datalist);
                return new ComponentCollection(datalist);
            }
        }

        public virtual void Dispose()
        {
            for (int i = 0; i < _kundenList.Count; ++i)
            { 
                IComponent curObj = (IComponent)_kundenList[i];
                curObj.Dispose();
            }

            _kundenList.Clear();
        }
    }
}
