using DevExpress.XtraEditors;
using Oracle.ManagedDataAccess.Client;
using SIGSUC.Desktop.Conexao.Oracle;
using SIGSUC.Desktop.Utils;
using System;
using System.Windows.Forms;

namespace SIGSUC.Desktop.Conexao
{
    public static class ConexaoOracle
    {
        public static OracleConnection RetornaConexao(OracleCon acesso, bool mensagem)
        {
            OracleConnection conexao = new OracleConnection();
            try
            {
                var conString = "Data Source=" +
                    "(DESCRIPTION=(ADDRESS=(PROTOCOL=" + Cripto.Decrypt(acesso.Protocol) + ")" +
                    "(HOST=" + Cripto.Decrypt(acesso.Host) + ")(PORT=" + Cripto.Decrypt(acesso.Port) + "))" +
                    "(CONNECT_DATA=(SERVICE_NAME=" + Cripto.Decrypt(acesso.ServiceName) + ")));" +
                    "User Id = " + Cripto.Decrypt(acesso.User) + "; Password = " + Cripto.Decrypt(acesso.Password) + "; ";

                conexao.ConnectionString = conString;
                conexao.Open();
                //var retorno = conexao.State.ToString() == "Open" ? conexao : null;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Não foi possível abrir a conexão com o Banco de Dados " + Cripto.Decrypt(acesso.SystemName) + "! \n" + e.Message, "Sem conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (mensagem && conexao.State.ToString() == "Open")
            {
                XtraMessageBox.Show("Conexão com o Banco de Dados " + Cripto.Decrypt(acesso.SystemName) + " efetuada com sucesso! \n", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return conexao;
        }

        public static bool TestaConexao(OracleConnection conexao, bool mensagem)
        {
            bool retorno = false;
            try
            {
                retorno = conexao.State.ToString() == "Open" ? true : false;
            }
            catch (Exception e)
            {
                if (mensagem)
                {
                    XtraMessageBox.Show("Não foi possível fazer a conexão com o Banco de Dados! \n" + e.Message, "Sem conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return retorno;
        }
    }
}
