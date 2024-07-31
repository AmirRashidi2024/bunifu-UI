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
    public partial class frmMain : Form
    {
        public static int Loginid;
        public frmMain()
        {
            InitializeComponent();
        }
        private void RibbonControl1_Click(object sender, EventArgs e)
        {

        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ButtonItem2_Click(object sender, EventArgs e)
        {
            frmAddStudent.insertloginid = Loginid;
            new frmAddStudent().ShowDialog();
        }

        private void ButtonItem3_Click(object sender, EventArgs e)
        {
            frmshowStudent.Id_login = Loginid;
            new frmshowStudent().ShowDialog();
        }
    }
}
