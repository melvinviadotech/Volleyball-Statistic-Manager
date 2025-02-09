using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Volleyball_Statistic_Manager
{
    public partial class volleyballStatisticsManager : Form
    {
        formBoxScore boxScore;
        formDashboard dashboard;
        formLegend legend;
        formHotkeys hotkeys;
        formPlayByPlay playByPlay;

        public volleyballStatisticsManager()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
        }

        private void DashboardClick(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void BoxScoreClick(object sender, EventArgs e)
        {
            if (boxScore == null)
            {
                boxScore = new formBoxScore();
                boxScore.FormClosed += BoxScore_FormClosed;
                boxScore.MdiParent = this;
                boxScore.Dock = DockStyle.Fill;
                boxScore.Show();
            }
            else
            {
                boxScore.Activate();
            }
        }

        private void BoxScore_FormClosed(object sender, FormClosedEventArgs e)
        {
            boxScore = null;
        }

        private void LegendClick(object sender, EventArgs e)
        {
            if (legend == null)
            {
                legend = new formLegend();
                legend.FormClosed += LegendClick_FormClosed;
                legend.MdiParent = this;
                legend.Dock = DockStyle.Fill;
                legend.Show();
            }
            else
            {
                legend.Activate();
            }
        }

        private void LegendClick_FormClosed(object sender, FormClosedEventArgs e)
        {
            legend = null;
        }

        private void HotkeysClick(object sender, EventArgs e)
        {
            if (hotkeys == null)
            {
                hotkeys = new formHotkeys();
                hotkeys.FormClosed += HotkeysClick_FormClosed;
                hotkeys.MdiParent = this;
                hotkeys.Dock = DockStyle.Fill;
                hotkeys.Show();
            }
            else
            {
                hotkeys.Activate();
            }
        }

        private void HotkeysClick_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotkeys = null;
        }

        private void PlayByPlayClick(object sender, EventArgs e)
        {
            if (playByPlay == null)
            {
                playByPlay = new formPlayByPlay();
                playByPlay.FormClosed += PlayByPlayClick_FormClosed;
                playByPlay.MdiParent = this;
                playByPlay.Dock = DockStyle.Fill;
                playByPlay.Show();
            }
            else
            {
                playByPlay.Activate();
            }
        }

        private void PlayByPlayClick_FormClosed(object sender, FormClosedEventArgs e)
        {
            playByPlay = null;
        }

        // Remove container border
        private void MainFormLoad(object sender, EventArgs e)
        {
            DashboardClick(sender, e);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Hold mouse click to move window
        private void MoveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
