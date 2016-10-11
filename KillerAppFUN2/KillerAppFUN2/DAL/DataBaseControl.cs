using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2.DAL
{
    //this class is temporary until I get the repository pattern working
    public class DataBaseControl
    {
        private static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teun\Source\Repos\FUN2killerapp\KillerAppFUN2\KillerAppFUN2\RPGdata.mdf;Integrated Security=True";
        private string query;
        private SqlConnection connection = new SqlConnection(conn);
        public List<Weapon> getAllWeapons()
        {
            List<Weapon> weaponsList = new List<Weapon>();
            query = "SELECT * FROM Weapons";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                int DMG = reader.GetInt32(1);
                int CRT = reader.GetInt32(2);
                weaponsList.Add(new Weapon(ID, DMG, CRT));
            }
            reader.Close();
            connection.Close();
            return weaponsList;
        }
    }
}
