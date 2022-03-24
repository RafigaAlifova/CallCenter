using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormUI.CRUDForms
{
    public partial class EmployeeForm : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly IProfessionService _professionService;
        private readonly ICompanyService _companyService;

        public EmployeeForm()
        {
            InitializeComponent();
            this._employeeService = InstanceFactory
                .GetInstance<IEmployeeService>(new BusinessModule());
            this._professionService = InstanceFactory
                .GetInstance<IProfessionService>(new BusinessModule());
            this._companyService = InstanceFactory
               .GetInstance<ICompanyService>(new BusinessModule());
        }

        //sql cedvellerimiz getirmek ucun
        private void LoadEmployees()
        {
            this.dgwEmployee.DataSource = this._employeeService.GetAll();
        }
        private void LoadProfessions()
        {
            this.cmbProfessions.DataSource = this._professionService.GetAll();
            this.cmbProfessions.DisplayMember = "Name";
            this.cmbProfessions.ValueMember = "Id";

        }
        private void LoadCompanies()
        {
            this.cmbCompanies.DataSource = this._companyService.GetAll();
            this.cmbCompanies.DisplayMember = "Name";
            this.cmbCompanies.ValueMember = "Id";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._employeeService.Add(new Employee
            {
                FirstName = this.tbxFirstNameAdd.Text,
                LastName = this.tbxLastNameAdd.Text,
                ProfessionId = (int)this.cmbProfessions.SelectedValue,
                IsFree = this.btnStatus.Checked,
                CompanyId = (int)this.cmbCompanies.SelectedValue
            });
            LoadEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this._employeeService.Update(new Employee
            {
                Id = (int)this.dgwEmployee.CurrentRow?.Cells["Id"].Value,
                FirstName = this.tbxFirstNameAdd.Text,
                LastName = this.tbxLastNameAdd.Text,
                ProfessionId = (int)this.cmbProfessions.SelectedValue,
                CompanyId = (int)this.cmbCompanies.SelectedValue,
                IsFree = this.btnStatus.Checked

            }

            );
            LoadEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._employeeService.Delete(new Employee
            {
                Id = (int)this.dgwEmployee.CurrentRow?.Cells["Id"].Value

            }

            );
            LoadEmployees();
        }





        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.LoadProfessions();
            this.LoadEmployees();
            this.LoadCompanies();
        }

        private void dgwEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbxFirstNameAdd.Text =
                this.dgwEmployee.CurrentRow?.Cells["FirstName"].Value.ToString();
            this.tbxLastNameAdd.Text =
               this.dgwEmployee.CurrentRow?.Cells["LastName"].Value.ToString();
            this.cmbProfessions.SelectedValue =
              this.dgwEmployee.CurrentRow?.Cells["ProfessionId"].Value;
            this.cmbCompanies.SelectedValue =
            this.dgwEmployee.CurrentRow?.Cells["CompanyId"].Value;
          this.btnStatus.Checked=(bool) this.dgwEmployee.CurrentRow?.Cells["IsFree"].Value;

        }

      
    }
}
