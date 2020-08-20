using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apm
{
    public partial class StartfensterMenu : UserControl
    {
        public StartfensterMenu()
        {
            InitializeComponent();
        }

        private void btn_informationenAbrufen_Click(object sender, EventArgs e)
        {
            PassagierinfoSuche passagierinfo = new PassagierinfoSuche();
            passagierinfo.BringToFront();
        }

    }
}
