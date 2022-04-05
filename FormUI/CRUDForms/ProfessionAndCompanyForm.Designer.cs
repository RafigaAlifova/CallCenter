
namespace FormUI.CRUDForms
{
    partial class ProfessionAndCompanyForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxCompanies = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vacancyCountCompanyCRUD = new System.Windows.Forms.DomainUpDown();
            this.gbxSearchMusic = new System.Windows.Forms.GroupBox();
            this.btnCompanySearch = new System.Windows.Forms.Button();
            this.cmbSearchParameters = new System.Windows.Forms.ComboBox();
            this.tbxCompanyNameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.tbxNameCompanyCRUD = new System.Windows.Forms.TextBox();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.dgwCompanies = new System.Windows.Forms.DataGridView();
            this.dgwProfessions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxProfessions = new System.Windows.Forms.GroupBox();
            this.vacancyCountProfessionCRUD = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxSearchGenre = new System.Windows.Forms.GroupBox();
            this.cmbSearchParametersProfessions = new System.Windows.Forms.ComboBox();
            this.btnSearchProfession = new System.Windows.Forms.Button();
            this.tbxProfessionNameSearch = new System.Windows.Forms.TextBox();
            this.lblProfessionNameSearch = new System.Windows.Forms.Label();
            this.btnDeleteProfession = new System.Windows.Forms.Button();
            this.btnUpdateProfession = new System.Windows.Forms.Button();
            this.btnAddProfession = new System.Windows.Forms.Button();
            this.tbxNameProfessionCRUD = new System.Windows.Forms.TextBox();
            this.lblNameProfession = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxCompanies.SuspendLayout();
            this.gbxSearchMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfessions)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxProfessions.SuspendLayout();
            this.gbxSearchGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbxCompanies, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgwCompanies, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgwProfessions, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 774);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbxCompanies
            // 
            this.gbxCompanies.Controls.Add(this.label3);
            this.gbxCompanies.Controls.Add(this.vacancyCountCompanyCRUD);
            this.gbxCompanies.Controls.Add(this.gbxSearchMusic);
            this.gbxCompanies.Controls.Add(this.btnDeleteCompany);
            this.gbxCompanies.Controls.Add(this.btnUpdateCompany);
            this.gbxCompanies.Controls.Add(this.btnAddCompany);
            this.gbxCompanies.Controls.Add(this.tbxNameCompanyCRUD);
            this.gbxCompanies.Controls.Add(this.lblNameCompany);
            this.gbxCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxCompanies.Location = new System.Drawing.Point(2, 389);
            this.gbxCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCompanies.Name = "gbxCompanies";
            this.gbxCompanies.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCompanies.Size = new System.Drawing.Size(590, 383);
            this.gbxCompanies.TabIndex = 2;
            this.gbxCompanies.TabStop = false;
            this.gbxCompanies.Text = "Companies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(393, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vacancy";
            // 
            // vacancyCountCompanyCRUD
            // 
            this.vacancyCountCompanyCRUD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vacancyCountCompanyCRUD.Location = new System.Drawing.Point(461, 53);
            this.vacancyCountCompanyCRUD.Name = "vacancyCountCompanyCRUD";
            this.vacancyCountCompanyCRUD.Size = new System.Drawing.Size(92, 20);
            this.vacancyCountCompanyCRUD.TabIndex = 8;
            // 
            // gbxSearchMusic
            // 
            this.gbxSearchMusic.Controls.Add(this.btnCompanySearch);
            this.gbxSearchMusic.Controls.Add(this.cmbSearchParameters);
            this.gbxSearchMusic.Controls.Add(this.tbxCompanyNameSearch);
            this.gbxSearchMusic.Controls.Add(this.label2);
            this.gbxSearchMusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxSearchMusic.Location = new System.Drawing.Point(2, 227);
            this.gbxSearchMusic.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSearchMusic.Name = "gbxSearchMusic";
            this.gbxSearchMusic.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSearchMusic.Size = new System.Drawing.Size(586, 154);
            this.gbxSearchMusic.TabIndex = 7;
            this.gbxSearchMusic.TabStop = false;
            this.gbxSearchMusic.Text = "Search";
            // 
            // btnCompanySearch
            // 
            this.btnCompanySearch.Location = new System.Drawing.Point(486, 95);
            this.btnCompanySearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompanySearch.Name = "btnCompanySearch";
            this.btnCompanySearch.Size = new System.Drawing.Size(76, 32);
            this.btnCompanySearch.TabIndex = 9;
            this.btnCompanySearch.Text = "Search";
            this.btnCompanySearch.UseVisualStyleBackColor = true;
            this.btnCompanySearch.Click += new System.EventHandler(this.btnCompanySearch_Click);
            // 
            // cmbSearchParameters
            // 
            this.cmbSearchParameters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSearchParameters.FormattingEnabled = true;
            this.cmbSearchParameters.Items.AddRange(new object[] {
            "Contains",
            "Starts",
            "Ends"});
            this.cmbSearchParameters.Location = new System.Drawing.Point(459, 32);
            this.cmbSearchParameters.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchParameters.Name = "cmbSearchParameters";
            this.cmbSearchParameters.Size = new System.Drawing.Size(92, 21);
            this.cmbSearchParameters.TabIndex = 8;
            // 
            // tbxCompanyNameSearch
            // 
            this.tbxCompanyNameSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCompanyNameSearch.Location = new System.Drawing.Point(86, 31);
            this.tbxCompanyNameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCompanyNameSearch.Name = "tbxCompanyNameSearch";
            this.tbxCompanyNameSearch.Size = new System.Drawing.Size(92, 20);
            this.tbxCompanyNameSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCompany.Location = new System.Drawing.Point(496, 178);
            this.btnDeleteCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(68, 34);
            this.btnDeleteCompany.TabIndex = 6;
            this.btnDeleteCompany.Text = "Delete";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCompany.Location = new System.Drawing.Point(410, 178);
            this.btnUpdateCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(68, 34);
            this.btnUpdateCompany.TabIndex = 5;
            this.btnUpdateCompany.Text = "Update";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCompany.Location = new System.Drawing.Point(324, 178);
            this.btnAddCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(68, 34);
            this.btnAddCompany.TabIndex = 4;
            this.btnAddCompany.Text = "Add";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // tbxNameCompanyCRUD
            // 
            this.tbxNameCompanyCRUD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxNameCompanyCRUD.Location = new System.Drawing.Point(88, 57);
            this.tbxNameCompanyCRUD.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNameCompanyCRUD.Name = "tbxNameCompanyCRUD";
            this.tbxNameCompanyCRUD.Size = new System.Drawing.Size(92, 20);
            this.tbxNameCompanyCRUD.TabIndex = 2;
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.ForeColor = System.Drawing.Color.Teal;
            this.lblNameCompany.Location = new System.Drawing.Point(20, 59);
            this.lblNameCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(35, 13);
            this.lblNameCompany.TabIndex = 0;
            this.lblNameCompany.Text = "Name";
            // 
            // dgwCompanies
            // 
            this.dgwCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwCompanies.Location = new System.Drawing.Point(2, 2);
            this.dgwCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.dgwCompanies.Name = "dgwCompanies";
            this.dgwCompanies.RowHeadersWidth = 51;
            this.dgwCompanies.RowTemplate.Height = 24;
            this.dgwCompanies.Size = new System.Drawing.Size(590, 383);
            this.dgwCompanies.TabIndex = 0;
            // 
            // dgwProfessions
            // 
            this.dgwProfessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProfessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProfessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwProfessions.Location = new System.Drawing.Point(596, 2);
            this.dgwProfessions.Margin = new System.Windows.Forms.Padding(2);
            this.dgwProfessions.Name = "dgwProfessions";
            this.dgwProfessions.RowHeadersWidth = 51;
            this.dgwProfessions.RowTemplate.Height = 24;
            this.dgwProfessions.Size = new System.Drawing.Size(591, 383);
            this.dgwProfessions.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbxProfessions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(596, 389);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 383);
            this.panel1.TabIndex = 3;
            // 
            // gbxProfessions
            // 
            this.gbxProfessions.Controls.Add(this.vacancyCountProfessionCRUD);
            this.gbxProfessions.Controls.Add(this.label4);
            this.gbxProfessions.Controls.Add(this.gbxSearchGenre);
            this.gbxProfessions.Controls.Add(this.btnDeleteProfession);
            this.gbxProfessions.Controls.Add(this.btnUpdateProfession);
            this.gbxProfessions.Controls.Add(this.btnAddProfession);
            this.gbxProfessions.Controls.Add(this.tbxNameProfessionCRUD);
            this.gbxProfessions.Controls.Add(this.lblNameProfession);
            this.gbxProfessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxProfessions.Location = new System.Drawing.Point(0, 0);
            this.gbxProfessions.Margin = new System.Windows.Forms.Padding(2);
            this.gbxProfessions.Name = "gbxProfessions";
            this.gbxProfessions.Padding = new System.Windows.Forms.Padding(2);
            this.gbxProfessions.Size = new System.Drawing.Size(591, 383);
            this.gbxProfessions.TabIndex = 2;
            this.gbxProfessions.TabStop = false;
            this.gbxProfessions.Text = "Professions";
            // 
            // vacancyCountProfessionCRUD
            // 
            this.vacancyCountProfessionCRUD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vacancyCountProfessionCRUD.Location = new System.Drawing.Point(450, 52);
            this.vacancyCountProfessionCRUD.Name = "vacancyCountProfessionCRUD";
            this.vacancyCountProfessionCRUD.Size = new System.Drawing.Size(92, 20);
            this.vacancyCountProfessionCRUD.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(382, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vacancy";
            // 
            // gbxSearchGenre
            // 
            this.gbxSearchGenre.Controls.Add(this.cmbSearchParametersProfessions);
            this.gbxSearchGenre.Controls.Add(this.btnSearchProfession);
            this.gbxSearchGenre.Controls.Add(this.tbxProfessionNameSearch);
            this.gbxSearchGenre.Controls.Add(this.lblProfessionNameSearch);
            this.gbxSearchGenre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxSearchGenre.Location = new System.Drawing.Point(2, 227);
            this.gbxSearchGenre.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSearchGenre.Name = "gbxSearchGenre";
            this.gbxSearchGenre.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSearchGenre.Size = new System.Drawing.Size(587, 154);
            this.gbxSearchGenre.TabIndex = 8;
            this.gbxSearchGenre.TabStop = false;
            this.gbxSearchGenre.Text = "Search";
            // 
            // cmbSearchParametersProfessions
            // 
            this.cmbSearchParametersProfessions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSearchParametersProfessions.FormattingEnabled = true;
            this.cmbSearchParametersProfessions.Items.AddRange(new object[] {
            "Contains",
            "Starts",
            "Ends"});
            this.cmbSearchParametersProfessions.Location = new System.Drawing.Point(448, 29);
            this.cmbSearchParametersProfessions.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchParametersProfessions.Name = "cmbSearchParametersProfessions";
            this.cmbSearchParametersProfessions.Size = new System.Drawing.Size(92, 21);
            this.cmbSearchParametersProfessions.TabIndex = 11;
            // 
            // btnSearchProfession
            // 
            this.btnSearchProfession.Location = new System.Drawing.Point(482, 95);
            this.btnSearchProfession.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchProfession.Name = "btnSearchProfession";
            this.btnSearchProfession.Size = new System.Drawing.Size(76, 32);
            this.btnSearchProfession.TabIndex = 10;
            this.btnSearchProfession.Text = "Search";
            this.btnSearchProfession.UseVisualStyleBackColor = true;
            this.btnSearchProfession.Click += new System.EventHandler(this.btnSearchProfession_Click);
            // 
            // tbxProfessionNameSearch
            // 
            this.tbxProfessionNameSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxProfessionNameSearch.Location = new System.Drawing.Point(121, 27);
            this.tbxProfessionNameSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbxProfessionNameSearch.Name = "tbxProfessionNameSearch";
            this.tbxProfessionNameSearch.Size = new System.Drawing.Size(92, 20);
            this.tbxProfessionNameSearch.TabIndex = 4;
            // 
            // lblProfessionNameSearch
            // 
            this.lblProfessionNameSearch.AutoSize = true;
            this.lblProfessionNameSearch.ForeColor = System.Drawing.Color.Teal;
            this.lblProfessionNameSearch.Location = new System.Drawing.Point(18, 32);
            this.lblProfessionNameSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfessionNameSearch.Name = "lblProfessionNameSearch";
            this.lblProfessionNameSearch.Size = new System.Drawing.Size(35, 13);
            this.lblProfessionNameSearch.TabIndex = 3;
            this.lblProfessionNameSearch.Text = "Name";
            // 
            // btnDeleteProfession
            // 
            this.btnDeleteProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProfession.Location = new System.Drawing.Point(492, 178);
            this.btnDeleteProfession.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProfession.Name = "btnDeleteProfession";
            this.btnDeleteProfession.Size = new System.Drawing.Size(68, 34);
            this.btnDeleteProfession.TabIndex = 6;
            this.btnDeleteProfession.Text = "Delete";
            this.btnDeleteProfession.UseVisualStyleBackColor = true;
            this.btnDeleteProfession.Click += new System.EventHandler(this.btnDeleteProfession_Click);
            // 
            // btnUpdateProfession
            // 
            this.btnUpdateProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProfession.Location = new System.Drawing.Point(406, 178);
            this.btnUpdateProfession.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProfession.Name = "btnUpdateProfession";
            this.btnUpdateProfession.Size = new System.Drawing.Size(68, 34);
            this.btnUpdateProfession.TabIndex = 5;
            this.btnUpdateProfession.Text = "Update";
            this.btnUpdateProfession.UseVisualStyleBackColor = true;
            this.btnUpdateProfession.Click += new System.EventHandler(this.btnUpdateProfession_Click);
            // 
            // btnAddProfession
            // 
            this.btnAddProfession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProfession.Location = new System.Drawing.Point(320, 178);
            this.btnAddProfession.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProfession.Name = "btnAddProfession";
            this.btnAddProfession.Size = new System.Drawing.Size(68, 34);
            this.btnAddProfession.TabIndex = 4;
            this.btnAddProfession.Text = "Add";
            this.btnAddProfession.UseVisualStyleBackColor = true;
            this.btnAddProfession.Click += new System.EventHandler(this.btnAddProfession_Click);
            // 
            // tbxNameProfessionCRUD
            // 
            this.tbxNameProfessionCRUD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxNameProfessionCRUD.Location = new System.Drawing.Point(123, 56);
            this.tbxNameProfessionCRUD.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNameProfessionCRUD.Name = "tbxNameProfessionCRUD";
            this.tbxNameProfessionCRUD.Size = new System.Drawing.Size(92, 20);
            this.tbxNameProfessionCRUD.TabIndex = 2;
            // 
            // lblNameProfession
            // 
            this.lblNameProfession.AutoSize = true;
            this.lblNameProfession.ForeColor = System.Drawing.Color.Teal;
            this.lblNameProfession.Location = new System.Drawing.Point(55, 59);
            this.lblNameProfession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameProfession.Name = "lblNameProfession";
            this.lblNameProfession.Size = new System.Drawing.Size(35, 13);
            this.lblNameProfession.TabIndex = 0;
            this.lblNameProfession.Text = "Name";
            // 
            // ProfessionAndCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1189, 774);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProfessionAndCompanyForm";
            this.Text = "ProfessionAndCompanyForm";
            this.Load += new System.EventHandler(this.ProfessionAndCompanyForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxCompanies.ResumeLayout(false);
            this.gbxCompanies.PerformLayout();
            this.gbxSearchMusic.ResumeLayout(false);
            this.gbxSearchMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProfessions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbxProfessions.ResumeLayout(false);
            this.gbxProfessions.PerformLayout();
            this.gbxSearchGenre.ResumeLayout(false);
            this.gbxSearchGenre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxCompanies;
        private System.Windows.Forms.GroupBox gbxSearchMusic;
        private System.Windows.Forms.Button btnCompanySearch;
        private System.Windows.Forms.ComboBox cmbSearchParameters;
        private System.Windows.Forms.TextBox tbxCompanyNameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.TextBox tbxNameCompanyCRUD;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.DataGridView dgwCompanies;
        private System.Windows.Forms.DataGridView dgwProfessions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxProfessions;
        private System.Windows.Forms.GroupBox gbxSearchGenre;
        private System.Windows.Forms.ComboBox cmbSearchParametersProfessions;
        private System.Windows.Forms.Button btnSearchProfession;
        private System.Windows.Forms.TextBox tbxProfessionNameSearch;
        private System.Windows.Forms.Label lblProfessionNameSearch;
        private System.Windows.Forms.Button btnDeleteProfession;
        private System.Windows.Forms.Button btnUpdateProfession;
        private System.Windows.Forms.Button btnAddProfession;
        private System.Windows.Forms.TextBox tbxNameProfessionCRUD;
        private System.Windows.Forms.Label lblNameProfession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown vacancyCountCompanyCRUD;
        private System.Windows.Forms.DomainUpDown vacancyCountProfessionCRUD;
        private System.Windows.Forms.Label label4;
    }
}