using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 :Form
    {
        DataClasses1DataContext dt = new DataClasses1DataContext();
        bool? CheckUser=false;
        bool? checkpass=false;
        int? loginid;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
           
           tabControl1.SelectedTab=tabPage1;
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSignupUsername.Text==string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtSignupUsername, "نام کاربری را وارد نمایید");
                }
                else if (txtsignupPassword.Text==string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtsignupPassword, "کلمه عبور را وارد نمایید ");
                }
                else
                {
                    dt.insertLogin(txtSignupUsername.Text, txtsignupPassword.Text);
                    MessageBox.Show("عملیات با موفقیت انجام شد ", "ثبت شد ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }

            }
            catch 
            {
                MessageBox.Show("ارتباط با سرور خارجی قطع شده است", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Checkusername(ref CheckUser, txtSigninUsername.Text);
                dt.CheckPassword(ref checkpass, txtSigninPassword.Text);
                if (txtSigninUsername.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtSigninUsername, "نام کاربری را وارد نمایید");
                }
                else if (txtSigninPassword.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtSigninPassword, "کلمه عبور را وارد نمایید ");
                }
                else if(CheckUser==false&&checkpass==false)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtSigninUsername, "نام کاربری و یا کلمه عبور اشتباه است ");
                }
                else if (CheckUser==true&&checkpass==true)
                {
                    dt.getloginId(ref loginid,txtSigninUsername.Text);
                    frmMain.Loginid = (int)loginid;
                    errorProvider1.Clear();
                    new frmMain().Show();
                    this.Hide();
                }
            }
            catch 
            {
                MessageBox.Show("ارتباط با سرور خارجی قطع شده است", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
    }
}
