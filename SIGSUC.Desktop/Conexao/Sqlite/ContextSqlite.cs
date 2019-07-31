using SIGSUC.Desktop.Conexao.Oracle;
using System.Data.Entity;
using System.Data.SQLite;

namespace SIGSUC.Desktop.Conexao.Sqlite
{
    public class ContextSqlite : DbContext
    {
        /* não esquecer de colocar no App.config
         <provider invariantName="System.Data.SQLite" type="System.Data.SQLite.EF6.SQLiteProviderServices, System.Data.SQLite.EF6"/>
         */


        public ContextSqlite() : base(new SQLiteConnection( @"Data Source=./sqlite.dll;Version=3;"), true)
        { }



        public DbSet<OracleCon> OracleCon { get; set; }
        public DbSet<SqliteUsers> SqliteUsers { get; set; }
        //public DbSet<SqlServerCon> SqlServerCon { get; set; }
        //public object ObjectStateManager { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            var sqliteConnectionInitializer = new InitializerSqlite(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
    }
}