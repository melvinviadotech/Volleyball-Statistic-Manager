namespace Volleyball_Statistic_Manager
{
    partial class formHotkeys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hotkeyGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotkeyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // hotkeyGrid
            // 
            this.hotkeyGrid.AllowUserToAddRows = false;
            this.hotkeyGrid.AllowUserToDeleteRows = false;
            this.hotkeyGrid.AllowUserToResizeColumns = false;
            this.hotkeyGrid.AllowUserToResizeRows = false;
            this.hotkeyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotkeyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.hotkeyGrid.Location = new System.Drawing.Point(12, 12);
            this.hotkeyGrid.Name = "hotkeyGrid";
            this.hotkeyGrid.ReadOnly = true;
            this.hotkeyGrid.RowHeadersVisible = false;
            this.hotkeyGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.hotkeyGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hotkeyGrid.Size = new System.Drawing.Size(321, 328);
            this.hotkeyGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hotkey";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Key 1";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Key 2";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Hold Ctrl + Hotkey to Remove";
            // 
            // formHotkeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotkeyGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHotkeys";
            this.Text = "formHotkeys";
            this.Load += new System.EventHandler(this.FormHotkeys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotkeyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hotkeyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
    }
}