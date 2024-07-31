using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Stimulsoft.Report;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class frmshowStudent : Form
    {
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public static int Id_login;

        public frmshowStudent()
        {
            InitializeComponent();
        }
        private void FrmshowStudent_Load(object sender, EventArgs e)
        {
            try
            {
                bsUser.DataSource = dt.FillUsersbyid(Id_login);
            }
            catch 
            {
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport st = new StiReport();
               
                st.Load("report/Report.mrt");
                st.Compile();
                st["userfirstname"] = "Ahmad";
                st["tarikh"] = "null";
                st["Userloginid"] = Id_login;
                st.ShowWithRibbonGUI();

            }
            catch 
            {

            }
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
