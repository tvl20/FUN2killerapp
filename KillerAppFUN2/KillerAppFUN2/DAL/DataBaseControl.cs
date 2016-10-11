using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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

        public Player getPlayer(string playerName)
        {
            query = "SELECT CurrentRoomID, X, Y, Lvl, MaxHP, HP, Defence, WeaponID, WeaponDMG, WeaponCRT FROM Players INNER JOIN Weapons ON Players.CurrentWeapon = Weapons.WeaponID WHERE PlayerName = '" + playerName + "';";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            Player p = null;
            while (reader.Read())
            {
                int currentRoom = reader.GetInt32(0);
                int x = reader.GetInt32(1);
                int y = reader.GetInt32(2);
                int lvl = reader.GetInt32(3);
                int maxHP = reader.GetInt32(4);
                int hp = reader.GetInt32(5);
                int defence = reader.GetInt32(6);
                int weaponID = reader.GetInt32(7);
                int weaponDMG = reader.GetInt32(8);
                int weaponCRT = reader.GetInt32(9);
                Weapon w = new Weapon(weaponID, weaponDMG, weaponCRT);
                p = new Player(new Point(x,y), playerName, lvl, defence, maxHP, hp, Entity.Direction.South, w);
            }
            reader.Close();
            connection.Close();
            return p;
        }
    }
}
