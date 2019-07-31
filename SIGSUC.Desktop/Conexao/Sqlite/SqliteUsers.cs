using System.ComponentModel.DataAnnotations;

namespace SIGSUC.Desktop.Conexao.Sqlite
{
    public class SqliteUsers
    {
        [Key]
        public string Login { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Permissions { get; set; }
        /* As permissões serão dadas com S após o caracter [
         * A primeira permissão é se o usuário é administrador
         * A segunda permissão é se o usuário tem acesso às informações de Almoxaridado
         * 
         */
        public string LastBase { get; set; }
        public string Active { get; set; }
    }
}
