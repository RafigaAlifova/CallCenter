using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
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
    public partial class ProfessionAndCompanyForm : Form
    {
        private readonly IProfessionService _professionService;
        private readonly ICompanyService _companyService;
        public ProfessionAndCompanyForm()
        {
            InitializeComponent();
            this._professionService = InstanceFactory
                .GetInstance<IProfessionService>(new BusinessModule());
            this._companyService = InstanceFactory
               .GetInstance<ICompanyService>(new BusinessModule());
        }
        private void LoadProfessions()
        {
            this.dgwProfessions.DataSource = this._professionService.GetAll();

              }
        private void LoadCompanies()
        {
            this.dgwCompanies.DataSource = this._companyService.GetAll();
        }
        private void ProfessionAndCompanyForm_Load(object sender, EventArgs e)
        {
            LoadProfessions();
            LoadCompanies();
        }
        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            this._companyService.Add(new Company
            {
                Name=this.tbxNameCompanyCRUD.Text
            });
            this.LoadCompanies();
        }
        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            this._companyService.Update(new Company
            {
                Id = (int)this.dgwCompanies.CurrentRow?.Cells["Id"].Value,
                Name = this.tbxNameCompanyCRUD.Text
            });
            this.LoadCompanies();
        }
        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            this._companyService.Delete(new Company
            {
                Id = (int)this.dgwCompanies.CurrentRow?.Cells["Id"].Value
            });
            this.LoadCompanies();
        }
        private void btnAddProfession_Click(object sender, EventArgs e)
        {
            this._professionService.Add(new Profession
            {
                Name = this.tbxNameProfessionCRUD.Text
            });
            this.LoadProfessions();
        }

        private void btnUpdateProfession_Click(object sender, EventArgs e)
        
        {

            this._professionService.Update(new Profession
            {
                Id = (int)this.dgwProfessions.CurrentRow?.Cells["Id"].Value,
                Name = this.tbxNameProfessionCRUD.Text
            });
            this.LoadProfessions();
        }

        private void btnDeleteProfession_Click(object sender, EventArgs e)
        {

            this._professionService.Delete(new Profession
            {
                Id = (int)this.dgwProfessions.CurrentRow?.Cells["Id"].Value,
            });
            this.LoadProfessions();
        }

        private void btnCompanySearch_Click(object sender, EventArgs e)
        {
            string name = this.tbxCompanyNameSearch.Text;
            int strParam = this.cmbSearchParameters.SelectedIndex;
            this.dgwCompanies.DataSource =
                this._companyService.Search(name, strParam);

        }

        private void btnSearchProfession_Click(object sender, EventArgs e)
        {
            string name = this.tbxProfessionNameSearch.Text;

           int strParam = this.cmbSearchParametersProfessions.SelectedIndex;
            this.dgwProfessions.DataSource =
                this._professionService.Search(name, strParam);

        }


    }

}