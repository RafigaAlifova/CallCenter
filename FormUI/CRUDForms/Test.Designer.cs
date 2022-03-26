
namespace FormUI.CRUDForms
{
    partial class Test
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgwEmployees = new System.Windows.Forms.DataGridView();
            this.panelSidebar = new System.Windows.Forms.TableLayoutPanel();
            this.panelCrud = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCompanies = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxFirstNameAdd = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstNameAdd = new System.Windows.Forms.Label();
            this.lblLastNameAdd = new System.Windows.Forms.Label();
            this.lblProfessionAdd = new System.Windows.Forms.Label();
            this.lblStatusAdd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbStatusAdd = new System.Windows.Forms.CheckBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.panelCrud.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panelGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSidebar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1458, 815);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgwEmployees);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(3, 3);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(35);
            this.panelGrid.Size = new System.Drawing.Size(868, 809);
            this.panelGrid.TabIndex = 0;
            // 
            // dgwEmployees
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dgwEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwEmployees.Location = new System.Drawing.Point(35, 35);
            this.dgwEmployees.Name = "dgwEmployees";
            this.dgwEmployees.Size = new System.Drawing.Size(798, 739);
            this.dgwEmployees.TabIndex = 0;
            // 
            // panelSidebar
            // 
            this.panelSidebar.ColumnCount = 1;
            this.panelSidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSidebar.Controls.Add(this.panelCrud, 0, 1);
            this.panelSidebar.Controls.Add(this.panelSearch, 0, 0);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(877, 3);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.RowCount = 2;
            this.panelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelSidebar.Size = new System.Drawing.Size(578, 809);
            this.panelSidebar.TabIndex = 1;
            // 
            // panelCrud
            // 
            this.panelCrud.Controls.Add(this.tableLayoutPanel3);
            this.panelCrud.Controls.Add(this.panelButtons);
            this.panelCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrud.Location = new System.Drawing.Point(3, 407);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(572, 399);
            this.panelCrud.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblFirstNameAdd, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblLastNameAdd, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblProfessionAdd, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblStatusAdd, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 2, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(572, 333);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbCompanies);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(288, 201);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(281, 60);
            this.panel2.TabIndex = 29;
            // 
            // cmbCompanies
            // 
            this.cmbCompanies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.cmbCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCompanies.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompanies.FormattingEnabled = true;
            this.cmbCompanies.Location = new System.Drawing.Point(20, 20);
            this.cmbCompanies.Name = "cmbCompanies";
            this.cmbCompanies.Size = new System.Drawing.Size(241, 23);
            this.cmbCompanies.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(288, 135);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(281, 60);
            this.panel3.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 23);
            this.comboBox1.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbxFirstNameAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(288, 69);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(281, 60);
            this.panel4.TabIndex = 29;
            // 
            // tbxFirstNameAdd
            // 
            this.tbxFirstNameAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.tbxFirstNameAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxFirstNameAdd.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstNameAdd.Location = new System.Drawing.Point(20, 20);
            this.tbxFirstNameAdd.Name = "tbxFirstNameAdd";
            this.tbxFirstNameAdd.Size = new System.Drawing.Size(241, 23);
            this.tbxFirstNameAdd.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(288, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(281, 60);
            this.panel5.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 23);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(60, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 66);
            this.label1.TabIndex = 27;
            this.label1.Text = "Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstNameAdd
            // 
            this.lblFirstNameAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstNameAdd.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameAdd.ForeColor = System.Drawing.Color.Teal;
            this.lblFirstNameAdd.Location = new System.Drawing.Point(60, 0);
            this.lblFirstNameAdd.Name = "lblFirstNameAdd";
            this.lblFirstNameAdd.Size = new System.Drawing.Size(222, 66);
            this.lblFirstNameAdd.TabIndex = 17;
            this.lblFirstNameAdd.Text = " First Name";
            this.lblFirstNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastNameAdd
            // 
            this.lblLastNameAdd.AutoSize = true;
            this.lblLastNameAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastNameAdd.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameAdd.ForeColor = System.Drawing.Color.Teal;
            this.lblLastNameAdd.Location = new System.Drawing.Point(60, 66);
            this.lblLastNameAdd.Name = "lblLastNameAdd";
            this.lblLastNameAdd.Size = new System.Drawing.Size(222, 66);
            this.lblLastNameAdd.TabIndex = 18;
            this.lblLastNameAdd.Text = "Last Name";
            this.lblLastNameAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfessionAdd
            // 
            this.lblProfessionAdd.AutoSize = true;
            this.lblProfessionAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfessionAdd.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessionAdd.ForeColor = System.Drawing.Color.Teal;
            this.lblProfessionAdd.Location = new System.Drawing.Point(60, 132);
            this.lblProfessionAdd.Name = "lblProfessionAdd";
            this.lblProfessionAdd.Size = new System.Drawing.Size(222, 66);
            this.lblProfessionAdd.TabIndex = 19;
            this.lblProfessionAdd.Text = "Profession";
            this.lblProfessionAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusAdd
            // 
            this.lblStatusAdd.AutoSize = true;
            this.lblStatusAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusAdd.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusAdd.ForeColor = System.Drawing.Color.Teal;
            this.lblStatusAdd.Location = new System.Drawing.Point(60, 264);
            this.lblStatusAdd.Name = "lblStatusAdd";
            this.lblStatusAdd.Size = new System.Drawing.Size(222, 69);
            this.lblStatusAdd.TabIndex = 26;
            this.lblStatusAdd.Text = "Status";
            this.lblStatusAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbStatusAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(288, 267);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(281, 63);
            this.panel1.TabIndex = 28;
            // 
            // ckbStatusAdd
            // 
            this.ckbStatusAdd.AutoSize = true;
            this.ckbStatusAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbStatusAdd.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.ckbStatusAdd.Location = new System.Drawing.Point(20, 20);
            this.ckbStatusAdd.Name = "ckbStatusAdd";
            this.ckbStatusAdd.Size = new System.Drawing.Size(241, 23);
            this.ckbStatusAdd.TabIndex = 29;
            this.ckbStatusAdd.Text = "Available";
            this.ckbStatusAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbStatusAdd.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnUpdate);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 333);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(572, 66);
            this.panelButtons.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(471, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(290, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.Location = new System.Drawing.Point(381, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(3, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(572, 398);
            this.panelSearch.TabIndex = 0;
            this.panelSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSearch_Paint);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 815);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Test";
            this.Text = "Test";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelCrud.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgwEmployees;
        private System.Windows.Forms.TableLayoutPanel panelSidebar;
        private System.Windows.Forms.Panel panelCrud;
        private System.Windows.Forms.Panel panelSearch;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.CheckBox ckbStatusAdd;
        private System.Windows.Forms.ComboBox cmbCompanies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatusAdd;
        private System.Windows.Forms.TextBox tbxFirstNameAdd;
        private System.Windows.Forms.Label lblProfessionAdd;
        private System.Windows.Forms.Label lblLastNameAdd;
        private System.Windows.Forms.Label lblFirstNameAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}