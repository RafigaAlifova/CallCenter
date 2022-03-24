
namespace FormUI
{
    partial class CallCenter
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
            this.dgwEmployees = new System.Windows.Forms.DataGridView();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.gbxEmpUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxEmpProfessionUpdate = new System.Windows.Forms.TextBox();
            this.tbxEmpSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxEmpNameUpdate = new System.Windows.Forms.TextBox();
            this.lblEmpProfessionUpdate = new System.Windows.Forms.Label();
            this.lblEmpSurnameUpdate = new System.Windows.Forms.Label();
            this.lblEmpNameUpdate = new System.Windows.Forms.Label();
            this.gbxEmpAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxProfessionAdd = new System.Windows.Forms.TextBox();
            this.tbxEmpSurnameAdd = new System.Windows.Forms.TextBox();
            this.tbxEmpNameAdd = new System.Windows.Forms.TextBox();
            this.lblProfessionAdd = new System.Windows.Forms.Label();
            this.lblEmpSurnameAdd = new System.Windows.Forms.Label();
            this.lblEmpNameAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxEmpUpdate.SuspendLayout();
            this.gbxEmpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwEmployees
            // 
            this.dgwEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.dgwEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployees.Location = new System.Drawing.Point(29, 12);
            this.dgwEmployees.Name = "dgwEmployees";
            this.dgwEmployees.Size = new System.Drawing.Size(1090, 449);
            this.dgwEmployees.TabIndex = 0;
            this.dgwEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEmployees_CellContentClick);
            // 
            // gbxCrud
            // 
            this.gbxCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(58)))), ((int)(((byte)(120)))));
            this.gbxCrud.Controls.Add(this.gbxEmpUpdate);
            this.gbxCrud.Controls.Add(this.gbxEmpAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCrud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxCrud.Location = new System.Drawing.Point(29, 492);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(1090, 350);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "CRUD";
            // 
            // gbxEmpUpdate
            // 
            this.gbxEmpUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxEmpUpdate.Controls.Add(this.btnUpdate);
            this.gbxEmpUpdate.Controls.Add(this.tbxEmpProfessionUpdate);
            this.gbxEmpUpdate.Controls.Add(this.tbxEmpSurnameUpdate);
            this.gbxEmpUpdate.Controls.Add(this.tbxEmpNameUpdate);
            this.gbxEmpUpdate.Controls.Add(this.lblEmpProfessionUpdate);
            this.gbxEmpUpdate.Controls.Add(this.lblEmpSurnameUpdate);
            this.gbxEmpUpdate.Controls.Add(this.lblEmpNameUpdate);
            this.gbxEmpUpdate.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmpUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxEmpUpdate.Location = new System.Drawing.Point(564, 53);
            this.gbxEmpUpdate.Name = "gbxEmpUpdate";
            this.gbxEmpUpdate.Size = new System.Drawing.Size(486, 278);
            this.gbxEmpUpdate.TabIndex = 1;
            this.gbxEmpUpdate.TabStop = false;
            this.gbxEmpUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(238, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxEmpProfessionUpdate
            // 
            this.tbxEmpProfessionUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.tbxEmpProfessionUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpProfessionUpdate.Location = new System.Drawing.Point(168, 129);
            this.tbxEmpProfessionUpdate.Name = "tbxEmpProfessionUpdate";
            this.tbxEmpProfessionUpdate.Size = new System.Drawing.Size(241, 23);
            this.tbxEmpProfessionUpdate.TabIndex = 5;
            // 
            // tbxEmpSurnameUpdate
            // 
            this.tbxEmpSurnameUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.tbxEmpSurnameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpSurnameUpdate.Location = new System.Drawing.Point(168, 84);
            this.tbxEmpSurnameUpdate.Name = "tbxEmpSurnameUpdate";
            this.tbxEmpSurnameUpdate.Size = new System.Drawing.Size(241, 23);
            this.tbxEmpSurnameUpdate.TabIndex = 4;
            // 
            // tbxEmpNameUpdate
            // 
            this.tbxEmpNameUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.tbxEmpNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpNameUpdate.Location = new System.Drawing.Point(168, 39);
            this.tbxEmpNameUpdate.Name = "tbxEmpNameUpdate";
            this.tbxEmpNameUpdate.Size = new System.Drawing.Size(241, 23);
            this.tbxEmpNameUpdate.TabIndex = 3;
            // 
            // lblEmpProfessionUpdate
            // 
            this.lblEmpProfessionUpdate.AutoSize = true;
            this.lblEmpProfessionUpdate.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpProfessionUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEmpProfessionUpdate.Location = new System.Drawing.Point(17, 129);
            this.lblEmpProfessionUpdate.Name = "lblEmpProfessionUpdate";
            this.lblEmpProfessionUpdate.Size = new System.Drawing.Size(81, 19);
            this.lblEmpProfessionUpdate.TabIndex = 2;
            this.lblEmpProfessionUpdate.Text = "Profession";
            // 
            // lblEmpSurnameUpdate
            // 
            this.lblEmpSurnameUpdate.AutoSize = true;
            this.lblEmpSurnameUpdate.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSurnameUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEmpSurnameUpdate.Location = new System.Drawing.Point(17, 84);
            this.lblEmpSurnameUpdate.Name = "lblEmpSurnameUpdate";
            this.lblEmpSurnameUpdate.Size = new System.Drawing.Size(144, 19);
            this.lblEmpSurnameUpdate.TabIndex = 1;
            this.lblEmpSurnameUpdate.Text = "Employee Surname";
            // 
            // lblEmpNameUpdate
            // 
            this.lblEmpNameUpdate.AutoSize = true;
            this.lblEmpNameUpdate.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNameUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEmpNameUpdate.Location = new System.Drawing.Point(17, 39);
            this.lblEmpNameUpdate.Name = "lblEmpNameUpdate";
            this.lblEmpNameUpdate.Size = new System.Drawing.Size(124, 19);
            this.lblEmpNameUpdate.TabIndex = 0;
            this.lblEmpNameUpdate.Text = "Employee Name";
            // 
            // gbxEmpAdd
            // 
            this.gbxEmpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbxEmpAdd.Controls.Add(this.btnAdd);
            this.gbxEmpAdd.Controls.Add(this.tbxProfessionAdd);
            this.gbxEmpAdd.Controls.Add(this.tbxEmpSurnameAdd);
            this.gbxEmpAdd.Controls.Add(this.tbxEmpNameAdd);
            this.gbxEmpAdd.Controls.Add(this.lblProfessionAdd);
            this.gbxEmpAdd.Controls.Add(this.lblEmpSurnameAdd);
            this.gbxEmpAdd.Controls.Add(this.lblEmpNameAdd);
            this.gbxEmpAdd.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmpAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbxEmpAdd.Location = new System.Drawing.Point(22, 53);
            this.gbxEmpAdd.Name = "gbxEmpAdd";
            this.gbxEmpAdd.Size = new System.Drawing.Size(486, 278);
            this.gbxEmpAdd.TabIndex = 0;
            this.gbxEmpAdd.TabStop = false;
            this.gbxEmpAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(244, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbxProfessionAdd
            // 
            this.tbxProfessionAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.tbxProfessionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProfessionAdd.Location = new System.Drawing.Point(168, 129);
            this.tbxProfessionAdd.Name = "tbxProfessionAdd";
            this.tbxProfessionAdd.Size = new System.Drawing.Size(247, 23);
            this.tbxProfessionAdd.TabIndex = 5;
            // 
            // tbxEmpSurnameAdd
            // 
            this.tbxEmpSurnameAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.tbxEmpSurnameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpSurnameAdd.Location = new System.Drawing.Point(168, 84);
            this.tbxEmpSurnameAdd.Name = "tbxEmpSurnameAdd";
            this.tbxEmpSurnameAdd.Size = new System.Drawing.Size(247, 23);
            this.tbxEmpSurnameAdd.TabIndex = 4;
            // 
            // tbxEmpNameAdd
            // 
            this.tbxEmpNameAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.tbxEmpNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpNameAdd.Location = new System.Drawing.Point(168, 39);
            this.tbxEmpNameAdd.Name = "tbxEmpNameAdd";
            this.tbxEmpNameAdd.Size = new System.Drawing.Size(247, 23);
            this.tbxEmpNameAdd.TabIndex = 3;
            // 
            // lblProfessionAdd
            // 
            this.lblProfessionAdd.AutoSize = true;
            this.lblProfessionAdd.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessionAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblProfessionAdd.Location = new System.Drawing.Point(17, 129);
            this.lblProfessionAdd.Name = "lblProfessionAdd";
            this.lblProfessionAdd.Size = new System.Drawing.Size(81, 19);
            this.lblProfessionAdd.TabIndex = 2;
            this.lblProfessionAdd.Text = "Profession";
            // 
            // lblEmpSurnameAdd
            // 
            this.lblEmpSurnameAdd.AutoSize = true;
            this.lblEmpSurnameAdd.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpSurnameAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEmpSurnameAdd.Location = new System.Drawing.Point(17, 84);
            this.lblEmpSurnameAdd.Name = "lblEmpSurnameAdd";
            this.lblEmpSurnameAdd.Size = new System.Drawing.Size(144, 19);
            this.lblEmpSurnameAdd.TabIndex = 1;
            this.lblEmpSurnameAdd.Text = "Employee Surname";
            // 
            // lblEmpNameAdd
            // 
            this.lblEmpNameAdd.AutoSize = true;
            this.lblEmpNameAdd.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNameAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblEmpNameAdd.Location = new System.Drawing.Point(17, 39);
            this.lblEmpNameAdd.Name = "lblEmpNameAdd";
            this.lblEmpNameAdd.Size = new System.Drawing.Size(124, 19);
            this.lblEmpNameAdd.TabIndex = 0;
            this.lblEmpNameAdd.Text = "Employee Name";
            // 
            // CallCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(203)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1156, 870);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.dgwEmployees);
            this.Name = "CallCenter";
            this.Text = "Call Center";
            this.Load += new System.EventHandler(this.CallCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployees)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxEmpUpdate.ResumeLayout(false);
            this.gbxEmpUpdate.PerformLayout();
            this.gbxEmpAdd.ResumeLayout(false);
            this.gbxEmpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwEmployees;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.GroupBox gbxEmpAdd;
        private System.Windows.Forms.Label lblProfessionAdd;
        private System.Windows.Forms.Label lblEmpSurnameAdd;
        private System.Windows.Forms.Label lblEmpNameAdd;
        private System.Windows.Forms.TextBox tbxProfessionAdd;
        private System.Windows.Forms.TextBox tbxEmpSurnameAdd;
        private System.Windows.Forms.TextBox tbxEmpNameAdd;
        private System.Windows.Forms.GroupBox gbxEmpUpdate;
        private System.Windows.Forms.TextBox tbxEmpProfessionUpdate;
        private System.Windows.Forms.TextBox tbxEmpSurnameUpdate;
        private System.Windows.Forms.TextBox tbxEmpNameUpdate;
        private System.Windows.Forms.Label lblEmpProfessionUpdate;
        private System.Windows.Forms.Label lblEmpSurnameUpdate;
        private System.Windows.Forms.Label lblEmpNameUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}

