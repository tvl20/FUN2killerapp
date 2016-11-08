using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2.DAL
{
    class MSSQLweaponRepo : IWeaponRepo
    {
        private readonly string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teun\Source\Repos\FUN2killerapp\KillerAppFUN2\KillerAppFUN2\RPGdata.mdf;Integrated Security=True";

        public List<Weapon> getAllWeapons()
        {
            List<Weapon> weaponList = new List<Weapon>();
            using(SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT * FROM Weapons";
                SqlCommand cmd = new SqlCommand(query, connection);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32(0);
                        int DMG = reader.GetInt32(1);
                        int CRT = reader.GetInt32(2);
                        string TYPE = reader.GetString(3);
                        string NAME = reader.GetString(4);
                        weaponList.Add(new Weapon(ID, DMG, CRT, TYPE, NAME));
                    }
                }
            }
            return weaponList;
        }

        public Weapon getWeapon(string name)
        {
            Weapon weapon = null;
            using(SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT WeaponID, WeaponDMG, WeaponCRT, WeaponType FROM Weapons WHERE WeaponName='" + name + "';";
                SqlCommand cmd = new SqlCommand(query, connection);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32(0);
                        int DMG = reader.GetInt32(1);
                        int CRT = reader.GetInt32(2);
                        string TYPE = reader.GetString(3);
                        string NAME = reader.GetString(4);
                        weapon = new Weapon(ID, DMG, CRT, TYPE, NAME);
                    }
                }
            }
            return weapon;
        }
    }
}
