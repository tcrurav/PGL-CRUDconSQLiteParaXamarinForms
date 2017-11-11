using SQLite.Net;

namespace SQLiteEjemplo
{
    public interface IMiSQLite
    {
        SQLiteConnection GetConnection();
    }
}
