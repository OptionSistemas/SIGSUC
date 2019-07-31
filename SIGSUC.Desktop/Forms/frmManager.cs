using SIGSUC.Desktop.Forms;
using SIGSUC.Desktop.Forms.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIGSUC.Desktop
{
    public partial class frmManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static bool administrator = false;
        public static bool warehouse = false;

        public frmManager()
        {
            InitializeComponent();
        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOracle frm = new frmOracle();
            frm.ShowDialog();
        }

        private void FrmManager_Load(object sender, EventArgs e)
        {
            administrator = frmLogin.administrator;
            warehouse = frmLogin.warehouse;
            ripConfiguracoes.Visible = administrator;
            ripAlmoxarifado.Visible = warehouse;

        }

        private void FrmManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSqliteUsers frm = new frmSqliteUsers();
            frm.ShowDialog();
        }
    }
}
