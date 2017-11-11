using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteEjemplo
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get<IMiSQLite>().GetConnection();
            // create the table(s)
            dbConn.CreateTable<Ciclo>();
        }
        public List<Ciclo> GetAllCiclos()
        {
            return dbConn.Query<Ciclo>("Select * From [Ciclo]");
        }
        public int SaveCiclo(Ciclo ciclo)
        {
            return dbConn.Insert(ciclo);
        }
        public int DeleteCiclo(Ciclo ciclo)
        {
            return dbConn.Delete(ciclo);
        }
        public int EditCiclo(Ciclo ciclo)
        {
            return dbConn.Update(ciclo);
        }
    }
}
