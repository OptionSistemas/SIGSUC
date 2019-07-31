using Oracle.ManagedDataAccess.Client;
using SIGSUC.Desktop.Conexao.Oracle;
using SIGSUC.Desktop.Conexao.Sqlite;
using SIGSUC.Desktop.Utils;
using System;

namespace SIGSUC.Desktop.Forms.Config
{
    public partial class frmOracle : DevExpress.XtraEditors.XtraForm
    {
        OracleCon pims_Acesso = new OracleCon();
        OracleCon sisma_Acesso = new OracleCon();
        OracleCon mega_Acesso = new OracleCon();
        OracleCon senior_Acesso = new OracleCon();
        private OracleConnection conn;

        public frmOracle()
        {
            InitializeComponent();
        }

        private void frmOracle_Load(object sender, EventArgs e)
        {
            GetDados();

        }

        private void GetDados()
        {
            using (var contexto = new ContextSqlite())
            {
                var systemName = "PIMS";
                pims_Acesso = contexto.OracleCon.Find(Cripto.Encrypt(systemName));
                edtServiceNamePims.Text = Cripto.Decrypt(pims_Acesso.ServiceName);
                edtHostPims.Text = Cripto.Decrypt(pims_Acesso.Host);
                edtPortPims.Text = Cripto.Decrypt(pims_Acesso.Port);
                edtUserPims.Text = Cripto.Decrypt(pims_Acesso.User);
                edtPasswordPims.Text = Cripto.Decrypt(pims_Acesso.Password);
                cboProtocolPims.Text = Cripto.Decrypt(pims_Acesso.Protocol);

                systemName = "SISMA";
                sisma_Acesso = contexto.OracleCon.Find(Cripto.Encrypt(systemName));
                edtServiceNameSisma.Text = Cripto.Decrypt(sisma_Acesso.ServiceName);
                edtHostSisma.Text = Cripto.Decrypt(sisma_Acesso.Host);
                edtPortSisma.Text = Cripto.Decrypt(sisma_Acesso.Port);
                edtUserSisma.Text = Cripto.Decrypt(sisma_Acesso.User);
                edtPasswordSisma.Text = Cripto.Decrypt(sisma_Acesso.Password);
                cboProtocolSisma.Text = Cripto.Decrypt(sisma_Acesso.Protocol);

                systemName = "MEGA";
                mega_Acesso = contexto.OracleCon.Find(Cripto.Encrypt(systemName));
                edtServiceNameMega.Text = Cripto.Decrypt(mega_Acesso.ServiceName);
                edtHostMega.Text = Cripto.Decrypt(mega_Acesso.Host);
                edtPortMega.Text = Cripto.Decrypt(mega_Acesso.Port);
                edtUserMega.Text = Cripto.Decrypt(mega_Acesso.User);
                edtPasswordMega.Text = Cripto.Decrypt(mega_Acesso.Password);
                cboProtocolMega.Text = Cripto.Decrypt(mega_Acesso.Protocol);

                systemName = "SENIOR";
                senior_Acesso = contexto.OracleCon.Find(Cripto.Encrypt(systemName));
                edtServiceNameSenior.Text = Cripto.Decrypt(senior_Acesso.ServiceName);
                edtHostSenior.Text = Cripto.Decrypt(senior_Acesso.Host);
                edtPortSenior.Text = Cripto.Decrypt(senior_Acesso.Port);
                edtUserSenior.Text = Cripto.Decrypt(senior_Acesso.User);
                edtPasswordSenior.Text = Cripto.Decrypt(senior_Acesso.Password);
                cboProtocolSenior.Text = Cripto.Decrypt(senior_Acesso.Protocol);


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetDados(string systemName)
        {

            switch (systemName)
            {
                case "PIMS":
                    {
                        pims_Acesso.Host = Cripto.Encrypt(edtHostPims.Text);
                        pims_Acesso.User = Cripto.Encrypt(edtUserPims.Text);
                        pims_Acesso.Password = Cripto.Encrypt(edtPasswordPims.Text);
                        pims_Acesso.Port = Cripto.Encrypt(edtPortPims.Text);
                        pims_Acesso.Protocol = Cripto.Encrypt(cboProtocolPims.Text);
                        pims_Acesso.ServiceName = Cripto.Encrypt(edtServiceNamePims.Text);
                        break;
                    }
                case "MEGA":
                    {
                        mega_Acesso.Host = Cripto.Encrypt(edtHostMega.Text);
                        mega_Acesso.User = Cripto.Encrypt(edtUserMega.Text);
                        mega_Acesso.Password = Cripto.Encrypt(edtPasswordMega.Text);
                        mega_Acesso.Port = Cripto.Encrypt(edtPortMega.Text);
                        mega_Acesso.Protocol = Cripto.Encrypt(cboProtocolMega.Text);
                        mega_Acesso.ServiceName = Cripto.Encrypt(edtServiceNameMega.Text);
                        break;
                    }
                case "SISMA":
                    {
                        sisma_Acesso.Host = Cripto.Encrypt(edtHostSisma.Text);
                        sisma_Acesso.User = Cripto.Encrypt(edtUserSisma.Text);
                        sisma_Acesso.Password = Cripto.Encrypt(edtPasswordSisma.Text);
                        sisma_Acesso.Port = Cripto.Encrypt(edtPortSisma.Text);
                        sisma_Acesso.Protocol = Cripto.Encrypt(cboProtocolSisma.Text);
                        sisma_Acesso.ServiceName = Cripto.Encrypt(edtServiceNameSisma.Text);
                        break;
                    }
                case "SENIOR":
                    {
                        senior_Acesso.Host = Cripto.Encrypt(edtHostSenior.Text);
                        senior_Acesso.User = Cripto.Encrypt(edtUserSenior.Text);
                        senior_Acesso.Password = Cripto.Encrypt(edtPasswordSenior.Text);
                        senior_Acesso.Port = Cripto.Encrypt(edtPortSenior.Text);
                        senior_Acesso.Protocol = Cripto.Encrypt(cboProtocolSenior.Text);
                        senior_Acesso.ServiceName = Cripto.Encrypt(edtServiceNameSenior.Text);
                        break;
                    }
            }

        }

        private void btnTestSenior_Click(object sender, EventArgs e)
        {
            SetDados("SENIOR");
            conn = Conexao.ConexaoOracle.RetornaConexao(senior_Acesso, true);
        }

        private void btnTestPims_Click(object sender, EventArgs e)
        {
            SetDados("PIMS");
            conn = Conexao.ConexaoOracle.RetornaConexao(pims_Acesso, true);
        }

        private void btnTestMega_Click(object sender, EventArgs e)
        {
            SetDados("MEGA");
            conn = Conexao.ConexaoOracle.RetornaConexao(mega_Acesso, true);
        }

        private void btnTestSisma_Click(object sender, EventArgs e)
        {
            SetDados("SISMA");
            conn = Conexao.ConexaoOracle.RetornaConexao(sisma_Acesso, true);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            using (var contexto = new ContextSqlite())
            {
                contexto.OracleCon.Attach(senior_Acesso);
                contexto.OracleCon.Attach(pims_Acesso);
                contexto.OracleCon.Attach(mega_Acesso);
                contexto.OracleCon.Attach(sisma_Acesso);

                SetDados("SENIOR");
                SetDados("PIMS");
                SetDados("MEGA");
                SetDados("SISMA");
                contexto.SaveChanges();
            }
        }
    }
}