using System;
using System.IO;
using SQLite.Net;
using SQLiteEjemplo.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(ServicioSQLite))]
namespace SQLiteEjemplo.Droid
{
    class ServicioSQLite : IMiSQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "SQLiteMio.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            Console.WriteLine(path);
            if (!File.Exists(path)) File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            // Return the database connection 
            return conn;
        }
    }
}