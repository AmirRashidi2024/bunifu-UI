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
    public partial class frmAddStudent : Form
    {
        public static int insertloginid;
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public frmAddStudent()
        {
            InitializeComponent();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
          
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dt.InsertUsers(insertloginid, txtName.Text, txtFamily.Text,
                txtFatherName.Text, txtinternationalCode.Text, txtAddress.Text);

                if (MessageBox.Show("عملیات با موفقیت انجام شد ", "ثبت شد ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    txtName.Text = string.Empty;
                    txtFamily.Text = string.Empty;
                    txtFatherName.Text = string.Empty;
                    txtinternationalCode.Text = string.Empty;
                    txtAddress.Text = string.Empty;

                }
            }
            catch
            {
                MessageBox.Show("ارتباط با سرور خارجی قطع شده است ", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
    }
}
