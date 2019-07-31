using SIGSUC.Desktop.Conexao.Oracle;
using SIGSUC.Desktop.Utils;
using SQLite.CodeFirst;
using System.Data.Entity;

namespace SIGSUC.Desktop.Conexao.Sqlite
{
    public class InitializerSqlite : SqliteDropCreateDatabaseWhenModelChanges<ContextSqlite>
    {
        public InitializerSqlite(DbModelBuilder modelBuilder)
        : base(modelBuilder) { }

        protected override void Seed(ContextSqlite context)
        {
            context.OracleCon.Add(new OracleCon
            {
                SystemName = Cripto.Encrypt("PIMS"),
                ServiceName = Cripto.Encrypt("PROD.LOCAL"),
                Protocol = Cripto.Encrypt("TCP"),
                Host = Cripto.Encrypt("192.168.0.71"),
                User = Cripto.Encrypt("PIMSCS"),
                Password = Cripto.Encrypt("deployuipj"),
                Port = Cripto.Encrypt("1521")
            });
            context.OracleCon.Add(new OracleCon
            {
                SystemName = Cripto.Encrypt("SISMA"),
                ServiceName = Cripto.Encrypt("SISMA.LOCAL"),
                Protocol = Cripto.Encrypt("TCP"),
                Host = Cripto.Encrypt("192.168.0.5"),
                User = Cripto.Encrypt("system"),
                Password = Cripto.Encrypt("l7xCNiKbty"),
                Port = Cripto.Encrypt("1521")
            });
            context.OracleCon.Add(new OracleCon
            {
                SystemName = Cripto.Encrypt("MEGA"),
                ServiceName = Cripto.Encrypt("SERRA.LOCAL"),
                Protocol = Cripto.Encrypt("TCP"),
                Host = Cripto.Encrypt("192.168.0.71"),
                User = Cripto.Encrypt("system"),
                Password = Cripto.Encrypt("l7xCNiKbty"),
                Port = Cripto.Encrypt("1521")
            });
            context.OracleCon.Add(new OracleCon
            {
                SystemName = Cripto.Encrypt("SENIOR"),
                ServiceName = Cripto.Encrypt("FSENIOR.LOCAL"),
                Protocol = Cripto.Encrypt("TCP"),
                Host = Cripto.Encrypt("192.168.0.6"),
                User = Cripto.Encrypt("rhvetorh"),
                Password = Cripto.Encrypt("rhvetorh"),
                Port = Cripto.Encrypt("1521")
            });
            context.SqliteUsers.Add(new SqliteUsers
            {
                Login = Cripto.Encrypt("Reuber"),
                User = Cripto.Encrypt("Reuber Abdias de Moura Junior"),
                Password = Cripto.Encrypt("@Admin123$"),
                Permissions = Cripto.Encrypt("Reuber[SSSSS]"),
                LastBase = Cripto.Encrypt("P"),
                Active = Cripto.Encrypt("S")
            });
            context.SqliteUsers.Add(new SqliteUsers
            {
                Login = Cripto.Encrypt("Admin"),
                User = Cripto.Encrypt("Administrador"),
                Password = Cripto.Encrypt("@Ipojuca2"),
                Permissions = Cripto.Encrypt("Admin[SSSSS]"),
                LastBase = Cripto.Encrypt("P"),
                Active = Cripto.Encrypt("S")
            });
            /*context.SqlServerCon.Add(new SqlServerCon
            {
                Id = 1,
                ServerNameProduction = Cripto.Encrypt("TI-CPU-03\\SQLSERVER17"),
                UserProduction = Cripto.Encrypt("sa"),
                PasswordProduction = Cripto.Encrypt("@Admin123$"),
                ServerNameTest = Cripto.Encrypt("(localdb)\\mssqllocaldb"),
                UserTest = Cripto.Encrypt("sa"),
                PasswordTest = Cripto.Encrypt("@Admin123$")
            });*/

            base.Seed(context);
        }
    }
}