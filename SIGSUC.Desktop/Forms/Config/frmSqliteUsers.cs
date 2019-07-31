using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SIGSUC.Desktop.Conexao.Sqlite;
using SIGSUC.Desktop.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace SIGSUC.Desktop.Forms.Config
{
    public partial class frmSqliteUsers : DevExpress.XtraEditors.XtraForm
    {
        SqliteUsers sqliteuser = new SqliteUsers();

        public frmSqliteUsers()
        {
            InitializeComponent();
        }

        private void FrmSqliteUsers_Load(object sender, EventArgs e)
        {
            GetDados();
        }

        private void GetDados()
        {
            using (var contexto = new ContextSqlite())
            {
                var sqliteusers = contexto.SqliteUsers.ToList().Where(c => c.Login != "Reuber");
                grdSqliteUsers.DataSource = sqliteusers;
            }

        }

        string getField(GridView view, int listSourceRowIndex, string field)
        {
            string login = Cripto.Decrypt(Convert.ToString(view.GetListSourceRowCellValue(listSourceRowIndex, field)));
            return login;
        }


        private void GridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Login_" && e.IsGetData)
                e.Value = getField(view, e.ListSourceRowIndex,"Login");
            if (e.Column.FieldName == "User_" && e.IsGetData)
                e.Value = getField(view, e.ListSourceRowIndex, "User");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
            txtPasswordC.Text = "";
            chkAdministrador.Checked = false;
            chkAlmoxarifado.Checked = false;
            chkAgricola.Checked = false;
            txtLogin.Focus();                
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //checar dados
            // não deixar desativar o usuário admin
            sqliteuser.Login = Cripto.Encrypt(txtLogin.Text);
            sqliteuser.User = Cripto.Encrypt(txtUser.Text);
            sqliteuser.Password = Cripto.Encrypt(txtPassword.Text);
            sqliteuser.Permissions = Cripto.Encrypt(txtLogin.Text + "[" + TrueFalse(chkAdministrador)
                + TrueFalse(chkAlmoxarifado)
                + TrueFalse(chkAgricola)
                + "NN]");
            sqliteuser.LastBase = Cripto.Encrypt("P");
            sqliteuser.Active = Cripto.Encrypt(TrueFalse(chkAtivo));

            using (var contexto = new ContextSqlite())
            {
                contexto.SqliteUsers.Add(sqliteuser);
                contexto.SaveChanges();
            }
            GetDados();
        }
        private string TrueFalse(CheckEdit check)
        {
            return check.Checked ? "S" : "N";
        }
    }
}