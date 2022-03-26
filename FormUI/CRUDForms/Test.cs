using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI.CRUDForms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbProfessions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}

/*
 
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
           // this.dgwEmployees.DataSource = this._employeeService.GetAll();
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

        private void dgwEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.tbxFirstNameAdd.Text =
            //   this.dgwEmployees.CurrentRow?.Cells["FirstName"].Value.ToString();
            //this.tbxLastNameAdd.Text =
            //   this.dgwEmployees.CurrentRow?.Cells["LastName"].Value.ToString();
            //this.cmbProfessions.SelectedValue =
            //  this.dgwEmployees.CurrentRow?.Cells["ProfessionId"].Value;
            //this.cmbCompanies.SelectedValue =
            //this.dgwEmployees.CurrentRow?.Cells["CompanyId"].Value;
            //this.ckbStatusAdd.Checked = (bool)this.dgwEmployees.CurrentRow?.Cells["IsFree"].Value;

        }

        
      
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.LoadProfessions();
            this.LoadEmployees();
            this.LoadCompanies();
        }
       
        //private void tbxFirstNameSearch_TextChanged(object sender, EventArgs e)
        //{
        //    //var text = tbxFirstNameSearch.Text;
        //    //if (!String.IsNullOrEmpty(text))
        //    //{
        //    //    dgwEmployee.DataSource = this._employeeService.Get(text);
        //    //}
        //    //else LoadEmployees();
        //}

        //private void cmbProfessionSearch_TextChanged(object sender, EventArgs e)
        //{
        //    //try
        //    //{
        //    //    dgwMovies.DataSource = _movieService
        //    //        .GetByGenreId((int)cbxGenreId.SelectedValue);
        //    //}
        //    //catch { }
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._employeeService.Add(new Employee
            {
                FirstName = this.tbxFirstNameAdd.Text,
                LastName = this.tbxLastNameAdd.Text,
                ProfessionId = (int)this.cmbProfessions.SelectedValue,
                IsFree = this.ckbStatusAdd.Checked,
                CompanyId = (int)this.cmbCompanies.SelectedValue
            });
            LoadEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this._employeeService.Update(new Employee
            {
               // Id = (int)this.dgwEmployees.CurrentRow?.Cells["Id"].Value,
                FirstName = this.tbxFirstNameAdd.Text,
                LastName = this.tbxLastNameAdd.Text,
                ProfessionId = (int)this.cmbProfessions.SelectedValue,
                CompanyId = (int)this.cmbCompanies.SelectedValue,
                IsFree = this.ckbStatusAdd.Checked

            }

           );
            LoadEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._employeeService.Delete(new Employee
            {
                //Id = (int)this.dgwEmployees.CurrentRow?.Cells["Id"].Value

            }

          );
            LoadEmployees();

        }

       
    }
}

 
 
 */