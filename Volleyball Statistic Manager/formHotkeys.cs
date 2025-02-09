using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Statistic_Manager
{
    public partial class formHotkeys : Form
    {
        public formHotkeys()
        {
            InitializeComponent();
        }

        private void FormHotkeys_Load(object sender, EventArgs e)
        {
            hotkeyGrid.Rows.Add(
                "Kills",
                "",
                "K"
                );

            hotkeyGrid.Rows.Add(
                "Attack Errors",
                "",
                "E"
                );

            hotkeyGrid.Rows.Add(
                "Total Attacks",
                "",
                "T"
                );

            hotkeyGrid.Rows.Add(
                "Assists",
                "",
                "A"
                );

            hotkeyGrid.Rows.Add(
                "Set Error",
                "Shift",
                "A"
                );

            hotkeyGrid.Rows.Add(
                "Service Ace",
                "",
                "Z"
                );

            hotkeyGrid.Rows.Add(
                "Service Error",
                "Shift",
                "Z"
                );

            hotkeyGrid.Rows.Add(
                "Block Solo",
                "",
                "B"
                );

            hotkeyGrid.Rows.Add(
                "Block Assist",
                "",
                "V"
                );

            hotkeyGrid.Rows.Add(
                "Block Error",
                "Shift",
                "B"
                );

            hotkeyGrid.Rows.Add(
                "Dig",
                "",
                "D"
                );

            hotkeyGrid.Rows.Add(
                "Ball Handling Error",
                "",
                "H"
                );

            hotkeyGrid.Rows.Add(
                "Reception Error",
                "",
                "R"
                );

            hotkeyGrid.Rows.Add(
                "Remove Modifier",
                "Ctrl",
                "*"
                );
        }
    }
}
