using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apm
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Fluggesellschaft fg = new Fluggesellschaft(123, "Hallo");
            fg.Bezeichnung = "Test";
            Console.Out.WriteLine(fg.Bezeichnung);

            Kundenstamm ksLufthansa = new Kundenstamm("Lufthansa");
            try
            {
                Kunde kunde1 = new Kunde(123,"Test", "Hans", "Mueller", DateTime.Now, "male", 123, "h.mueller@test.de", "deutsch", "Test", "12b", 123, "Hamburg", "Deutschland");
                ksLufthansa.Add(kunde1, "123");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Kunde konnte nicht hinzugefuegt werden: " + e.Message);
            }

            ComponentCollection datalist = ksLufthansa.Components;
            IEnumerator denum = datalist.GetEnumerator();

            while (denum.MoveNext())
            {
                Kunde currentKunde = (Kunde)denum.Current;
                Console.WriteLine("Kunde Vorname: " + currentKunde.Vorname);
                Console.WriteLine("Kunde Nachname: " + currentKunde.Nachname);
                Console.WriteLine("Kunde Kundenummer: " + currentKunde.Site.Name);
            }
            Console.WriteLine("Fluggesellschaft: " + ksLufthansa.Fluggesellschaft);

        }
    }
}
