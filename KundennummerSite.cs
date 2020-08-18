using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apm
{
    class KundennummerSite : ISite
    {
        private IComponent _curComponent;
        private IContainer _curContainer;
        private bool _bDesignMode;
        private string _KundennummerName;

        public KundennummerSite(IContainer actvCntr, IComponent prntCmpnt)
        {
            _curComponent = prntCmpnt;
            _curContainer = actvCntr;
            _bDesignMode = false;
            _KundennummerName = null;
        }

        //Support the ISite interface.
        public virtual IComponent Component
        {
            get
            {
                return _curComponent;
            }
        }

        public virtual IContainer Container
        {
            get
            {
                return _curContainer;
            }
        }

        public virtual bool DesignMode
        {
            get
            {
                return _bDesignMode;
            }
        }

        public virtual string Name
        {
            get
            {
                return _KundennummerName;
            }

            set
            {
                _KundennummerName = value;
            }
        }

        // Support the IServiceProvider interface
        public virtual object GetService(Type serviceType)
        {
            // This programm does not use any service object
            return null;
        }
    }
}
