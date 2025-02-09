using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Statistic_Manager
{
    public partial class formLegend : Form
    {
        public formLegend()
        {
            InitializeComponent();
        }

        private void OpenManual(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://fs.ncaa.org/Docs/stats/Stats_Manuals/VB/2022.pdf");
            Process.Start(sInfo);
        }
    }
}
