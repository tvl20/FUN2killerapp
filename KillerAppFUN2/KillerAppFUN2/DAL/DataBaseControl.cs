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

        public List<string> getPlayerNames()
        {
            List<string> names = new List<string>();
            query = "SELECT PlayerName FROM Players;";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                names.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return names;
        }

        public bool playerNameTaken(string playerName)
        {
            List<string> takenNames = getPlayerNames();
            foreach(string name in takenNames)
            {
                if (playerName == name)
                {
                    return true;
                }
            }
            return false;
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
                p = new Player(new Point(x,y), playerName, lvl, defence, maxHP, hp, Entity.Direction.South, w, currentRoom);
            }
            reader.Close();
            connection.Close();
            return p;
        }

        public void addPlayer(Player p)
        {
            //seperated so its easier to read
            query = "INSERT INTO Players (PlayerName, CurrentRoomID, CurrentWeapon, X, Y, Lvl, MaxHP, HP, Defence) VALUES ('" +
                p.Name + "', " + Convert.ToString(p.RoomID) + ", " + Convert.ToString(p.Weapon.WeaponID) + ". " + Convert.ToString(p.Location.X) + ", " + Convert.ToString(p.Location.Y) + ", " +
                Convert.ToString(p.Level) + ", " + Convert.ToString(p.MaxHP) + ", " + Convert.ToString(p.HP) + ", " + Convert.ToString(p.Defence) + ");";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
