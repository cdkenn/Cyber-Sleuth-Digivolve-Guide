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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblDigivolvesFrom = new System.Windows.Forms.DataGridView();
            this.DigimonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDigivolvesTo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLevel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblReqs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbStage = new System.Windows.Forms.ComboBox();
            this.tblDigimon = new System.Windows.Forms.DataGridView();
            this.colDigimonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigivolvesFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigivolvesTo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigimon)).BeginInit();
            this.SuspendLayout();
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
            this.tblDigivolvesFrom.Location = new System.Drawing.Point(45, 166);
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
            this.dataGridViewTextBoxColumn1,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblDigivolvesTo.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblDigivolvesTo.Location = new System.Drawing.Point(283, 166);
            this.tblDigivolvesTo.Name = "tblDigivolvesTo";
            this.tblDigivolvesTo.ReadOnly = true;
            this.tblDigivolvesTo.RowHeadersVisible = false;
            this.tblDigivolvesTo.Size = new System.Drawing.Size(503, 235);
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
            // Column1
            // 
            this.Column1.HeaderText = "Requirements";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(40, 36);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(70, 25);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.64444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.35555F));
            this.tableLayoutPanel1.Controls.Add(this.panelInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSearch, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 434F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1058, 434);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.lblReqs);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.lblLevel);
            this.panelInfo.Controls.Add(this.tblDigivolvesFrom);
            this.panelInfo.Controls.Add(this.tblDigivolvesTo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(253, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(802, 428);
            this.panelInfo.TabIndex = 0;
            // 
            // lblReqs
            // 
            this.lblReqs.AutoSize = true;
            this.lblReqs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqs.Location = new System.Drawing.Point(41, 108);
            this.lblReqs.Name = "lblReqs";
            this.lblReqs.Size = new System.Drawing.Size(54, 24);
            this.lblReqs.TabIndex = 9;
            this.lblReqs.Text = "Reqs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Requirements:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 31);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.cmbStage);
            this.panelSearch.Controls.Add(this.tblDigimon);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(244, 428);
            this.panelSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(106, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbStage
            // 
            this.cmbStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStage.FormattingEnabled = true;
            this.cmbStage.Location = new System.Drawing.Point(112, 31);
            this.cmbStage.Name = "cmbStage";
            this.cmbStage.Size = new System.Drawing.Size(127, 24);
            this.cmbStage.TabIndex = 5;
            this.cmbStage.SelectedIndexChanged += new System.EventHandler(this.cmbStage_SelectedIndexChanged);
            // 
            // tblDigimon
            // 
            this.tblDigimon.AllowUserToAddRows = false;
            this.tblDigimon.AllowUserToDeleteRows = false;
            this.tblDigimon.AllowUserToResizeColumns = false;
            this.tblDigimon.AllowUserToResizeRows = false;
            this.tblDigimon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDigimon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDigimonName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblDigimon.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblDigimon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblDigimon.Location = new System.Drawing.Point(0, 61);
            this.tblDigimon.Name = "tblDigimon";
            this.tblDigimon.RowHeadersVisible = false;
            this.tblDigimon.Size = new System.Drawing.Size(242, 365);
            this.tblDigimon.TabIndex = 3;
            this.tblDigimon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDigimon_CellContentClick);
            this.tblDigimon.SelectionChanged += new System.EventHandler(this.tblDigimon_SelectionChanged);
            // 
            // colDigimonName
            // 
            this.colDigimonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDigimonName.HeaderText = "Name";
            this.colDigimonName.Name = "colDigimonName";
            this.colDigimonName.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Cyber Sleuth Digivolve Tree";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDigivolvesFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigivolvesTo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDigimon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tblDigivolvesFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DigimonName;
        private System.Windows.Forms.DataGridView tblDigivolvesTo;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStage;
        private System.Windows.Forms.DataGridView tblDigimon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDigimonName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReqs;
        private System.Windows.Forms.Label label2;
    }
}

