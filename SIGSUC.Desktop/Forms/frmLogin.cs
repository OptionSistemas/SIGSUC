using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using SIGSUC.Desktop.Conexao.Sqlite;
using SIGSUC.Desktop.Utils;

namespace SIGSUC.Desktop.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static bool servTest = false;
        public static string loginUser = "";
        public static string permissions = "";
        public static bool administrator = false;
        public static bool warehouse = false;
        SqliteUsers sqliteuser = new SqliteUsers();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //verificando a existência do Diretório Data
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Data"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Data");
            }

            //verificando a existência do arquivo de configuração
            if (!File.Exists(Directory.GetCurrentDirectory() + @"\Data\config.db"))
            {
                XtraMessageBox.Show("Não há arquivo de configuração parametrizado para este sistema", "Parametrização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            using (var contexto = new ContextSqlite())
            {

                sqliteuser = contexto.SqliteUsers.Find(Cripto.Encrypt(txtLogin.Text));
                if (sqliteuser == null)
                {
                    XtraMessageBox.Show("Usuário e/ou senha inválidos ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                if (txtPassword.Text != Cripto.Decrypt(sqliteuser.Password))
                {
                    XtraMessageBox.Show("Usuário e/ou senha inválidos ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                servTest = (Cripto.Decrypt(sqliteuser.LastBase) == "T");
                loginUser = Cripto.Decrypt(sqliteuser.Login);
                var _permissions = Cripto.Decrypt(sqliteuser.Permissions);
                permissions = _permissions.Substring(_permissions.IndexOf("[")+1,5);
                //XtraMessageBox.Show(permissions, "Permissões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                administrator = permissions.Substring(0, 1) == "S";
                warehouse = permissions.Substring(1, 1) == "S";


                if (!File.Exists(Directory.GetCurrentDirectory() + @"\Data\config.db"))
                {
                    File.Copy(Directory.GetCurrentDirectory() + @"\sqlite.dll", Directory.GetCurrentDirectory() + @"\Data\config.db", true);
                }
                //servTest = false;
                //loginUser = "Reuber";

                //this.Hide();
                frmManager frm = new frmManager();
                frm.Show();
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}