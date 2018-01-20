namespace Digivolve_Tree
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbDigiSelect = new System.Windows.Forms.ComboBox();
            this.tblDigivolvesFrom = new System.Windows.Forms.DataGridView();
            this.DigimonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDigivolvesTo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtReqs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigivolvesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigivolvesTo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDigiSelect
            // 
            this.cmbDigiSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDigiSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDigiSelect.FormattingEnabled = true;
            this.cmbDigiSelect.Location = new System.Drawing.Point(221, 14);
            this.cmbDigiSelect.Name = "cmbDigiSelect";
            this.cmbDigiSelect.Size = new System.Drawing.Size(255, 28);
            this.cmbDigiSelect.TabIndex = 2;
            this.cmbDigiSelect.SelectedIndexChanged += new System.EventHandler(this.cmbDigiSelect_SelectedIndexChanged);
            // 
            // tblDigivolvesFrom
            // 
            this.tblDigivolvesFrom.AllowUserToAddRows = false;
            this.tblDigivolvesFrom.AllowUserToDeleteRows = false;
            this.tblDigivolvesFrom.AllowUserToOrderColumns = true;
            this.tblDigivolvesFrom.AllowUserToResizeRows = false;
            this.tblDigivolvesFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDigivolvesFrom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DigimonName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblDigivolvesFrom.DefaultCellStyle = dataGridViewCellStyle1;
            this.tblDigivolvesFrom.Location = new System.Drawing.Point(12, 12);
            this.tblDigivolvesFrom.Name = "tblDigivolvesFrom";
            this.tblDigivolvesFrom.ReadOnly = true;
            this.tblDigivolvesFrom.RowHeadersVisible = false;
            this.tblDigivolvesFrom.Size = new System.Drawing.Size(204, 235);
            this.tblDigivolvesFrom.TabIndex = 4;
            this.tblDigivolvesFrom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDigivolvesFrom_CellDoubleClick);
            // 
            // DigimonName
            // 
            this.DigimonName.HeaderText = "Digivolves From";
            this.DigimonName.Name = "DigimonName";
            this.DigimonName.ReadOnly = true;
            this.DigimonName.Width = 200;
            // 
            // tblDigivolvesTo
            // 
            this.tblDigivolvesTo.AllowUserToAddRows = false;
            this.tblDigivolvesTo.AllowUserToDeleteRows = false;
            this.tblDigivolvesTo.AllowUserToOrderColumns = true;
            this.tblDigivolvesTo.AllowUserToResizeRows = false;
            this.tblDigivolvesTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDigivolvesTo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblDigivolvesTo.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblDigivolvesTo.Location = new System.Drawing.Point(482, 14);
            this.tblDigivolvesTo.Name = "tblDigivolvesTo";
            this.tblDigivolvesTo.ReadOnly = true;
            this.tblDigivolvesTo.RowHeadersVisible = false;
            this.tblDigivolvesTo.Size = new System.Drawing.Size(204, 235);
            this.tblDigivolvesTo.TabIndex = 5;
            this.tblDigivolvesTo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDigivolvesTo_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Digivolves To";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(222, 60);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(44, 16);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level:";
            // 
            // txtReqs
            // 
            this.txtReqs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReqs.Location = new System.Drawing.Point(223, 86);
            this.txtReqs.Multiline = true;
            this.txtReqs.Name = "txtReqs";
            this.txtReqs.Size = new System.Drawing.Size(253, 163);
            this.txtReqs.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 261);
            this.Controls.Add(this.txtReqs);
            this.Controls.Add(this.tblDigivolvesTo);
            this.Controls.Add(this.tblDigivolvesFrom);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.cmbDigiSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Cyber Sleuth Digivolve Tree";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDigivolvesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigivolvesTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDigiSelect;
        private System.Windows.Forms.DataGridView tblDigivolvesFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DigimonName;
        private System.Windows.Forms.DataGridView tblDigivolvesTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtReqs;
    }
}

