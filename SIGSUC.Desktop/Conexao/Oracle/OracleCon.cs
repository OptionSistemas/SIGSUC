using System.ComponentModel.DataAnnotations;

namespace SIGSUC.Desktop.Conexao.Oracle
{
    public class OracleCon
    {
        [Key]
        public string SystemName { get; set; }
        public string ServiceName { get; set; }
        public string Protocol { get; set; }
        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
    }
}