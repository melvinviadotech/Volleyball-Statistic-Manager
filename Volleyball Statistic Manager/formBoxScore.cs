using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Volleyball_Statistic_Manager
{
    public partial class formBoxScore : Form
    {
        bool setsEnabled = false;
        int setsAmount = 0;
        int currentSet = 0;

        public formBoxScore()
        {
            InitializeComponent();
        }

        private void BoxScoreLoad(object sender, EventArgs e)
        {
            this.ControlBox = false;

            for (int i = 0; i < 6; i++)
            {
                volleyballStatistics.Rows.Add("", 0, 0, 0, 0.00, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }
                
            volleyballStatistics.Rows.Add("Totals", 0, 0, 0, 0.00, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }

        private DataGridViewRow GetSelectedRow()
        {
            int selectedrowindex = volleyballStatistics.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = volleyballStatistics.Rows[selectedrowindex];

            return selectedRow;
        }

        private void valueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (volleyballStatistics.SelectedCells.Count > 0)
            {
                // For selected row
                double kills = Convert.ToDouble(GetSelectedRow().Cells[1].Value);
                double errors = Convert.ToDouble(GetSelectedRow().Cells[2].Value);
                double totalAttacks = Convert.ToDouble(GetSelectedRow().Cells[3].Value);
                double percentage = ((kills - errors) / totalAttacks) * 100;

                if (totalAttacks > 0)
                {
                    GetSelectedRow().Cells[4].Value = percentage;
                }

                double serviceAce = Convert.ToDouble(GetSelectedRow().Cells[7].Value);
                double singleBlock = Convert.ToDouble(GetSelectedRow().Cells[9].Value);
                double assistBlock = Convert.ToDouble(GetSelectedRow().Cells[10].Value);

                GetSelectedRow().Cells[15].Value = 
                    kills + 
                    serviceAce + 
                    singleBlock + 
                    0.5 * assistBlock;

                
                // For total row
                if (volleyballStatistics.Rows.Count == 7)
                {
                    double totalKills = Convert.ToDouble(volleyballStatistics.Rows[6].Cells[1].Value);
                    double totalErrors = Convert.ToDouble(volleyballStatistics.Rows[6].Cells[2].Value);
                    double sumOfAttacks = Convert.ToDouble(volleyballStatistics.Rows[6].Cells[3].Value);
                    double totalPercentage = ((totalKills - totalErrors) / sumOfAttacks) * 100;

                    if (sumOfAttacks > 0)
                    {
                        volleyballStatistics.Rows[6].Cells[4].Value = totalPercentage;
                    }

                    double totalServiceAces = Convert.ToDouble(volleyballStatistics.Rows[6].Cells[7].Value);
                    double totalSingleBlocks = Convert.ToDouble(volleyballStatistics.Rows[6].Cells[9].Value);
                    double totalAssistBlocks = Convert.ToDouble(volleyballStatistics.Rows[6].Cells[10].Value);
                    volleyballStatistics.Rows[6].Cells[15].Value =
                        totalKills +
                        totalServiceAces +
                        totalSingleBlocks +
                        0.5 * totalAssistBlocks;
                }   
            }
        }

        private void SetPlayerName(object sender, EventArgs e)
        {
            if (setsEnabled)
            {
                for (int i = 0; i < sets.Count; i++)
                {
                    if (volleyballStatistics.SelectedCells.Count > 0)
                    {
                        int selectedrowindex = volleyballStatistics.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = sets[i].Rows[selectedrowindex];

                        selectedRow.Cells[0].Value = playerName.Text;
                        sets[0].Rows[selectedrowindex].Cells[0].Value = playerName.Text;
                    }
                }
            } 
            else
            {
                if (volleyballStatistics.SelectedCells.Count > 0)
                {
                    GetSelectedRow().Cells[0].Value = playerName.Text;
                }
            }

            playerName.Text = "";
            playerName.Select();
            playerName.Focus();

            int index = volleyballStatistics.SelectedCells[0].RowIndex;

            if (setsEnabled)
            {
                LoadSet(currentSet);
            }

            if (index == 5)
            {
                volleyballStatistics.ClearSelection();
                volleyballStatistics.Rows[0].Selected = true;
            }
            else
            {
                volleyballStatistics.ClearSelection();
                volleyballStatistics.Rows[index + 1].Selected = true;
            }

            
        }

        private void EditCell(int index, string type)
        {
            if (volleyballStatistics.SelectedCells.Count > 0)
            {
                if (type == "+")
                {
                    GetSelectedRow().Cells[index].Value = (int)GetSelectedRow().Cells[index].Value + 1;
                    volleyballStatistics.Rows[6].Cells[index].Value = (int)volleyballStatistics.Rows[6].Cells[index].Value + 1;

                    if (index == 1 | index == 2)
                    {
                        GetSelectedRow().Cells[3].Value = (int)GetSelectedRow().Cells[3].Value + 1;
                        volleyballStatistics.Rows[6].Cells[3].Value = (int)volleyballStatistics.Rows[6].Cells[3].Value + 1;
                    }

                    addSound();
                }
                else if (type == "-")
                {
                    GetSelectedRow().Cells[index].Value = (int)GetSelectedRow().Cells[index].Value - 1;
                    volleyballStatistics.Rows[6].Cells[index].Value = (int)volleyballStatistics.Rows[6].Cells[index].Value - 1;

                    if (index == 1 | index == 2)
                    {
                        GetSelectedRow().Cells[3].Value = (int)GetSelectedRow().Cells[3].Value - 1;
                        volleyballStatistics.Rows[6].Cells[3].Value = (int)volleyballStatistics.Rows[6].Cells[3].Value - 1;
                    }

                    removeSound();
                }
            }
        }

        private void AddKill(object sender, EventArgs e)
        {
            EditCell(1, "+");
        }

        private void RemoveKill(object sender, EventArgs e)
        {
            EditCell(1, "-");
        }

        private void AddAttackError(object sender, EventArgs e)
        {
            EditCell(2, "+");
        }

        private void RemoveAttackError(object sender, EventArgs e)
        {
            EditCell(2, "-");
        }

        private void AddtotalAttacks(object sender, EventArgs e)
        {
            EditCell(3, "+");
        }

        private void RemoveTotalAttacks(object sender, EventArgs e)
        {
            EditCell(3, "-");
        }

        private void AddAssist(object sender, EventArgs e)
        {
            EditCell(5, "+");
        }

        private void RemoveAssist(object sender, EventArgs e)
        {
            EditCell(5, "-");
        }

        private void AddSetError(object sender, EventArgs e)
        {
            EditCell(6, "+");
        }

        private void RemoveSetError(object sender, EventArgs e)
        {
            EditCell(6, "-");
        }

        private void AddServiceAce(object sender, EventArgs e)
        {
            EditCell(7, "+");
        }

        private void RemoveServiceAce(object sender, EventArgs e)
        {
            EditCell(7, "-");
        }

        private void AddServiceError(object sender, EventArgs e)
        {
            EditCell(8, "+");
        }

        private void RemoveServiceError(object sender, EventArgs e)
        {
            EditCell(8, "-");
        }

        private void AddBlockSingle(object sender, EventArgs e)
        {
            EditCell(9, "+");
        }

        private void RemoveBlockSingle(object sender, EventArgs e)
        {
            EditCell(9, "-");
        }

        private void AddBlockAssist(object sender, EventArgs e)
        {
            EditCell(10, "+");
        }

        private void RemoveBlockAssist(object sender, EventArgs e)
        {
            EditCell(10, "-");
        }

        private void AddBlockError(object sender, EventArgs e)
        {
            EditCell(11, "+");
        }

        private void RemoveBlockError(object sender, EventArgs e)
        {
            EditCell(11, "-");
        }

        private void AddDig(object sender, EventArgs e)
        {
            EditCell(12, "+");
        }

        private void RemoveDig(object sender, EventArgs e)
        {
            EditCell(12, "-");
        }

        private void AddBallHandlingError(object sender, EventArgs e)
        {
            EditCell(13, "+");
        }

        private void RemoveBallHandlingError(object sender, EventArgs e)
        {
            EditCell(13, "-");
        }

        private void AddReceptionError(object sender, EventArgs e)
        {
            EditCell(14, "+");
        }

        private void RemoveReceptionError(object sender, EventArgs e)
        {
            EditCell(14, "-");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys[] playerKeys =
            {
                Keys.D1,
                Keys.D2,
                Keys.D3,
                Keys.D4,
                Keys.D5,
                Keys.D6
            };

            foreach (Keys key in playerKeys)
            {
                if (keyData == key)
                {
                    int index = Array.IndexOf(playerKeys, key);

                    volleyballStatistics.ClearSelection();
                    volleyballStatistics.Rows[index].Selected = true;
                }
            }

            Keys[][] actionKeys = new Keys[15][];

            // Players
            actionKeys[0] = new Keys[] { };

            // Kills (Attacks)
            actionKeys[1] = new Keys[] { Keys.K };

            // Attack Errors
            actionKeys[2] = new Keys[] { Keys.E };

            // Total Attacks
            actionKeys[3] = new Keys[] { Keys.T };

            // PCT
            actionKeys[4] = new Keys[] { };

            // Assists
            actionKeys[5] = new Keys[] { Keys.A };

            // Set Error
            actionKeys[6] = new Keys[] { Keys.Shift, Keys.A };

            // Service Ace 
            actionKeys[7] = new Keys[] { Keys.Z };

            // Service Error
            actionKeys[8] = new Keys[] { Keys.Shift, Keys.Z };

            // Block Solo 
            actionKeys[9] = new Keys[] { Keys.B };

            // Block Assist
            actionKeys[10] = new Keys[] { Keys.V };

            // Block Error
            actionKeys[11] = new Keys[] { Keys.Shift, Keys.B };

            // Dig
            actionKeys[12] = new Keys[] { Keys.D };

            // Ball Handling Error
            actionKeys[13] = new Keys[] { Keys.H };

            // Reception Error
            actionKeys[14] = new Keys[] { Keys.R };

            Console.WriteLine(Array.IndexOf(actionKeys, actionKeys[0]));

            if (playerName.Focused == false)
            {
                for (int i = 0; i < actionKeys.Length; i++)
                {
                    Keys keyOne;
                    Keys keyTwo;

                    if (actionKeys[i].Length == 1)
                    {
                        keyOne = actionKeys[i][0];

                        if (keyData == keyOne)
                        {
                            EditCell(i, "+");
                        }
                        else if (keyData == (keyOne | Keys.Control))
                        {
                            EditCell(i, "-");
                        }
                    }
                    else if (actionKeys[i].Length == 2)
                    {
                        keyOne = actionKeys[i][0];
                        keyTwo = actionKeys[i][1];

                        if (keyData == (keyOne | keyTwo))
                        {
                            EditCell(i, "+");
                        }
                        else if (keyData == (keyOne | keyTwo | Keys.Control))
                        {
                            EditCell(i, "-");
                        }
                    }
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ResetButton(object sender, EventArgs e)
        {
            string message = "Confirm Reset?\nAny unsaved progress will be lost.";
            string title = "Reset";

            // Clear DGV values
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Reset();
            }
        }

        private void Reset()
        {
            for (int i = 0; i < 6; i++)
            {
                volleyballStatistics.Rows[i].SetValues("", 0, 0, 0, 0.00, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }
        }

        private void ClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                playerName.Select();
                playerName.Focus();
            }
        }

        private void ExportCSV(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            var dir = fbd.SelectedPath;
            string date = dateTimePicker1.Value.ToString("yyy-MM-dd");

            try
            {
                //Build the CSV file data as a Comma separated string.
                string csv = string.Empty;

                // If "per set mode" is enabled"
                if (setsEnabled)
                {
                    foreach (DataGridView set in sets)
                    {
                        csv += "Set " + (sets.IndexOf(set) + 1) + ",Result: ";

                        if (setsResults[sets.IndexOf(set)] == "")
                        {
                            csv += "Not Set";
                        } else
                        {
                            csv += setsResults[sets.IndexOf(set)];
                        }

                        csv += "\r\n";

                        //Add the Header row for CSV file.
                        foreach (DataGridViewColumn column in set.Columns)
                        {
                            csv += column.HeaderText + ',';
                        }
                        //Add new line.
                        csv += "\r\n";

                        //Adding the Rows
                        foreach (DataGridViewRow row in set.Rows)
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
                    }

                    EnableTotal();

                    csv += "Totals";
                    csv += "\r\n";

                    //Add the Header row for CSV file.
                    foreach (DataGridViewColumn column in volleyballStatistics.Columns)
                    {
                        csv += column.HeaderText + ',';
                    }
                    //Add new line.
                    csv += "\r\n";

                    //Adding the Rows
                    foreach (DataGridViewRow row in volleyballStatistics.Rows)
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
                } else
                {
                    //Add the Header row for CSV file.
                    foreach (DataGridViewColumn column in volleyballStatistics.Columns)
                    {
                        csv += column.HeaderText + ',';
                    }
                    //Add new line.
                    csv += "\r\n";

                    //Adding the Rows
                    foreach (DataGridViewRow row in volleyballStatistics.Rows)
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
                }   

                var path = (dir + "\\" + date + ".csv");

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
                    } else
                    {
                        MessageBox.Show("File Not Overwritten");
                    }
                } else
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

        private void ImportCSV(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            csvName.Text = dlg.FileName;

            volleyballStatistics.Rows.Clear();

            var list = File.ReadLines(csvName.Text).Skip(1)
                .Select(x => x.Split(','))
                .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                volleyballStatistics.Rows.Add(
                    list[i][0].ToString(),
                    Int32.Parse(list[i][1]),
                    Int32.Parse(list[i][2]),
                    Int32.Parse(list[i][3]),
                    Double.Parse(list[i][4]),
                    Int32.Parse(list[i][5]),
                    Int32.Parse(list[i][6]),
                    Int32.Parse(list[i][7]),
                    Int32.Parse(list[i][8]),
                    Int32.Parse(list[i][9]),
                    Int32.Parse(list[i][10]),
                    Int32.Parse(list[i][11]),
                    Int32.Parse(list[i][12]),
                    Int32.Parse(list[i][13]),
                    Int32.Parse(list[i][14]),
                    Double.Parse(list[i][15])
                );
            }
        }

        bool soundOn = true;

        private void addSound()
        {
            if (soundOn)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\add.wav");

                player.Stop();
                player.Play();
            }

        }

        private void removeSound()
        {
            if (soundOn)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\remove.wav");

                player.Stop();
                player.Play();
            }
        }

        private void EnableClickSounds(object sender, EventArgs e)
        {
            if (soundOn)
            {
                soundOn = false;
                enableAddRemoveSoundToolStripMenuItem.Checked = false;
            } 
            else
            {
                soundOn = true;
                enableAddRemoveSoundToolStripMenuItem.Checked = true;
            }
        }

        private void EnableSets(object sender, EventArgs e)
        {
            SetSets("");

            if (setsAmount != 0)
            {
                currentSet = 1;
                enableSetsButton.Enabled = false;
                setsEnabled = true;
                prevSetButton.Enabled = true;
                nextSetButton.Enabled = true;
                selectedSet.Enabled = true;
                selectedSet.ReadOnly = false;
                showTotalButton.Enabled = true;
                winButton.Enabled = true;
                lossButton.Enabled = true;

                selectedSet.Text = "1";

                CreateSets(setsAmount);
                LoadSet(1);
            }
        }

        private void SetSets(string msg)
        {
            string message = msg;
            string title = "Enable Sets";
            string placeholder = "";

            if (msg == "")
            {
                message = "Enter Amount of Sets";
            }

            string result = Interaction.InputBox(message, title, placeholder);

            if (result == "")
            {
                MessageBox.Show("Enabling Sets Cancelled");
            }
            else
            {
                try
                {
                    setsAmount = Int32.Parse(result);   
                }
                catch
                {
                    SetSets("Amount must be a number");
                }
            }
        }

        private void NextSet(object sender, EventArgs e)
        {
            SaveSet(currentSet);

            if (currentSet == setsAmount)
            {
                currentSet = 1;
            }
            else
            {
                currentSet++;
            }

            selectedSet.Text = currentSet.ToString();

            LoadSet(currentSet);
        }

        private void PreviousSet(object sender, EventArgs e)
        {
            SaveSet(currentSet);

            if (currentSet == 1)
            {
                currentSet = setsAmount;
            }
            else
            {
                currentSet--;
            }

            selectedSet.Text = currentSet.ToString();

            LoadSet(currentSet);
        }

        private void SaveSet(int currentSet)
        {
            sets[currentSet - 1].Rows.Clear();

            foreach (DataGridViewRow r in volleyballStatistics.Rows)
            {
                int index = sets[currentSet - 1].Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    sets[currentSet - 1].Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }
        }

        private void LoadSet(int currentSet)
        {
            volleyballStatistics.Rows.Clear();

            foreach (DataGridViewRow r in sets[currentSet - 1].Rows)
            {
                int index = volleyballStatistics.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    volleyballStatistics.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }

            setResult.Text = setsResults[currentSet - 1];
        }

        List<DataGridView> sets = new List<DataGridView> { };
        List<String> setsResults = new List<String> { };

        private void CreateSets(int amountOfSets)
        {
            for (int i = 0; i < amountOfSets; i++)
            {
                sets.Add(new DataGridView());
                setsResults.Add("");

                sets[i].AllowUserToAddRows = false;

                foreach (DataGridViewColumn c in volleyballStatistics.Columns)
                {
                    sets[i].Columns.Add(c.Clone() as DataGridViewColumn);
                }

                for (int j = 0; j < 6; j++)
                {
                    sets[i].Rows.Add("", 0, 0, 0, 0.00, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                }

                sets[i].Rows.Add("Totals", 0, 0, 0, 0.00, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }
        }

        bool totalToggled = false;

        private void ToggleTotal(object sender, EventArgs e)
        {
            if (totalToggled)
            {
                DisableTotal();
            } 
            else
            {
                EnableTotal();
            }
        }

        private void EnableTotal()
        {
            totalToggled = true;

            prevSetButton.Enabled = false;
            nextSetButton.Enabled = false;
            selectedSet.ReadOnly = true;
            showTotalButton.Text = "Total On";

            SaveSet(currentSet);

            DataGridView total = new DataGridView();

            total.AllowUserToAddRows = false;

            foreach (DataGridViewColumn c in volleyballStatistics.Columns)
            {
                total.Columns.Add(c.Clone() as DataGridViewColumn);
            }

            for (int j = 0; j < 6; j++)
            {
                total.Rows.Add("", 0, 0, 0, 0.00, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            }

            total.Rows.Add("Totals", 0, 0, 0, 0.00, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            for (int i = 0; i < setsAmount; i++)
            {
                foreach (DataGridViewRow r in sets[i].Rows)
                {
                    foreach (DataGridViewCell o in r.Cells)
                    {
                        if (o.ColumnIndex != 0)
                        {
                            double valueOne = Convert.ToDouble(o.Value);
                            double valueTwo = Convert.ToDouble(total.Rows[r.Index].Cells[o.ColumnIndex].Value);
                            double result = valueOne + valueTwo;

                            total.Rows[r.Index].Cells[o.ColumnIndex].Value = result;
                        } 
                        else
                        {
                            total.Rows[r.Index].Cells[o.ColumnIndex].Value = sets[0].Rows[r.Index].Cells[o.ColumnIndex].Value;
                        }
                    }
                }
            }

            volleyballStatistics.Rows.Clear();

            foreach (DataGridViewRow r in total.Rows)
            {
                int index = volleyballStatistics.Rows.Add(r.Clone() as DataGridViewRow);
                foreach (DataGridViewCell o in r.Cells)
                {
                    volleyballStatistics.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }

                // Re-calculate percentages for each row
                double kills = Convert.ToDouble(volleyballStatistics.Rows[index].Cells[1].Value);
                double errors = Convert.ToDouble(volleyballStatistics.Rows[index].Cells[2].Value);
                double totalAttacks = Convert.ToDouble(volleyballStatistics.Rows[index].Cells[3].Value);

                if (totalAttacks > 0)
                {
                    volleyballStatistics.Rows[index].Cells[4].Value = ((kills - errors) / totalAttacks) * 100;
                }
            }
        }

        private void DisableTotal()
        {
            totalToggled = false;

            prevSetButton.Enabled = true;
            nextSetButton.Enabled = true;
            selectedSet.ReadOnly = false;
            showTotalButton.Text = "Total Off";

            LoadSet(currentSet);
        }

        private void SetAsWin(object sender, EventArgs e)
        {
            setsResults[currentSet - 1] = "W";
            setResult.Text = "W";
        }

        private void SetAsLoss(object sender, EventArgs e)
        {
            setResult.Text = "L";
            setsResults[currentSet - 1] = "L";
        }
    }
}
