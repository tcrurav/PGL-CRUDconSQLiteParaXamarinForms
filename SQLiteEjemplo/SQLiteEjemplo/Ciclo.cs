using SQLite.Net.Attributes;

namespace SQLiteEjemplo
{
    public class Ciclo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Abreviatura { get; set; }

        public override string ToString()
        {
            return string.Format("[Ciclo: ID={0}, Nombre={1}, Abreviatura={2}]", ID, Nombre, Abreviatura);
        }
    }
}
