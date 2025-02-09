using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;
using Microsoft.VisualBasic;


namespace Volleyball_Statistic_Manager
{
    public partial class formPlayByPlay : Form
    {
        public formPlayByPlay()
        {
            InitializeComponent();
        }

        // Load the play by play tab
        private void PlayByPlayLoad(object sender, EventArgs e)
        {
            playByPlay.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            playByPlay.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            playByPlay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            playByPlay.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            playByPlay.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            playByPlay.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            playByPlay.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            playByPlay.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            
            playByPlay.ScrollBars = ScrollBars.Vertical;

            playByPlay.Columns[0].ReadOnly = true;
            playByPlay.Columns[2].ReadOnly = true;
            playByPlay.Columns[3].ReadOnly = true;

            foreach (DataGridViewColumn column in playByPlay.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        String currentServe = "";
        bool winnerOne = true;
        int teamOnePoints = 0;
        int teamTwoPoints = 0;

        private void AddPoint(object sender, EventArgs e)
        {
            if (currentServe == "")
            {
                MessageBox.Show(
                    "Select the team that served first", 
                    "Serve",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            } 
            else
            {
                if (winnerOne)
                {
                    teamOnePoints++;
                }
                else
                {
                    teamTwoPoints++;
                }

                int index = playByPlay.Rows.Add(
                    currentServe,
                    teamOneDescription.Text,
                    teamOnePoints,
                    teamTwoPoints,
                    teamTwoDescription.Text
                );

                if (winnerOne)
                {
                    DataGridViewCell cell = playByPlay.Rows[index].Cells[2];

                    cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
                    cell.Style.BackColor = Color.LightGray;

                    ServeTeamOne(sender, e);

                    serveTeamOneButton.BackgroundColor = Color.DarkGray;
                    serveTeamTwoButton.BackgroundColor = Color.DimGray;

                    currentServe = "Team One";
                }
                else
                {
                    DataGridViewCell cell = playByPlay.Rows[index].Cells[3];

                    cell.Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
                    cell.Style.BackColor = Color.LightGray;

                    ServeTeamTwo(sender, e);

                    serveTeamTwoButton.BackgroundColor = Color.DarkGray;
                    serveTeamOneButton.BackgroundColor = Color.DimGray;

                    currentServe = "Team Two";
                }

                // Scroll to the bottom upon adding a row
                playByPlay.FirstDisplayedScrollingRowIndex = playByPlay.RowCount - 1;

                // Clear text boxes
                teamOneDescription.Clear();
                teamTwoDescription.Clear();
            }   
        }

        private void ServeTeamOne(object sender, EventArgs e)
        {
            if (teamOnePoints == 0 && teamTwoPoints == 0)
            {
                serveTeamOneButton.BackgroundColor = Color.DarkGray;
                serveTeamTwoButton.BackgroundColor = Color.DimGray;

                currentServe = "Team One";
            }
        }

        private void ServeTeamTwo(object sender, EventArgs e)
        {
            if (teamOnePoints == 0 && teamTwoPoints == 0)
            {
                serveTeamTwoButton.BackgroundColor = Color.DarkGray;
                serveTeamOneButton.BackgroundColor = Color.DimGray;

                currentServe = "Team Two";
            }
        }

        private void PointTeamOne(object sender, EventArgs e)
        {
            winnerOne = true;

            pointEarnedTeamOneButton.BackgroundColor = Color.DarkGray;
            pointEarnedTeamTwoButton.BackgroundColor = Color.DimGray;
        }

        private void PointTeamTwo(object sender, EventArgs e)
        {
            winnerOne = false;

            pointEarnedTeamTwoButton.BackgroundColor = Color.DarkGray;
            pointEarnedTeamOneButton.BackgroundColor = Color.DimGray;
        }

        private void ExportPlayByPlayCSV(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            var dir = fbd.SelectedPath;

            try
            {
                //Build the CSV file data as a Comma separated string.
                string csv = string.Empty;

                // If "per set mode" is enabled"
                //Add the Header row for CSV file.
                foreach (DataGridViewColumn column in playByPlay.Columns)
                {
                    csv += column.HeaderText + ',';
                }
                //Add new line.
                csv += "\r\n";

                //Adding the Rows
                foreach (DataGridViewRow row in playByPlay.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            //Add the Data rows.
                            csv += cell.Value.ToString().TrimEnd(',').Replace(",", ";") + ',';
                        }
                        // break;
                    }
                    //Add new line.
                    csv += "\r\n";
                }

                var path = (dir + "\\file.csv");

                if (File.Exists(path))
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(
                        "File for this date already exists\nOverwrite New File?",
                        "Existing File",
                        buttons
                        );
                    if (result == DialogResult.Yes)
                    {
                        File.WriteAllText(path, csv);
                        MessageBox.Show("File Overwritten");
                    }
                    else
                    {
                        MessageBox.Show("File Not Overwritten");
                    }
                }
                else
                {
                    File.WriteAllText(path, csv);
                    MessageBox.Show("Export Successful");
                }

            }
            catch
            {
                MessageBox.Show("Error: Could not save data");
            }
        }

        private void Undo(object sender, EventArgs e)
        {
            int index = playByPlay.Rows.Count - 1;

            if ((string)playByPlay.Rows[index].Cells[0].Value == "Team One")
            {
                serveTeamOneButton.BackgroundColor = Color.DarkGray;
                serveTeamTwoButton.BackgroundColor = Color.DimGray;

                currentServe = "Team One";
            }
            else
            {
                serveTeamTwoButton.BackgroundColor = Color.DarkGray;
                serveTeamOneButton.BackgroundColor = Color.DimGray;

                currentServe = "Team Two";
            }

            if (winnerOne)
            {
                teamOnePoints--;
            }
            else
            {
                teamTwoPoints--;
            }

            playByPlay.Rows.RemoveAt(index);
        }
    }
}
