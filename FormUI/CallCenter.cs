using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using System;
using System.Windows.Forms;

namespace FormUI
{
    public partial class CallCenter : Form
    {
        //DEPENDENCE INJECTION:
       private readonly IEmployeeService _employeeService;
       //private readonly IRequestService _requestService;
       //private readonly  ICompanyService _companyService;
       //private readonly  IProfessionService _professionService;

        public CallCenter()
        {
            InitializeComponent();
            _employeeService = InstanceFactory
                 .GetInstance<IEmployeeService>(new BusinessModule());
            //_requestService = new RequestManager(new EfRequestDal());
            //_companyService = new CompanyManager(new EfCompanyDal());
            //_professionService = new ProfessionManager(new EfProfessionDal());
        }

        private void CallCenter_Load(object sender, EventArgs e)
        {
            //yuklenende datalarim gelsin hamisi getall kimi
            LoadData();

        }

        private void LoadData()
        {
            dgwEmployees.DataSource = this._employeeService.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgwEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
