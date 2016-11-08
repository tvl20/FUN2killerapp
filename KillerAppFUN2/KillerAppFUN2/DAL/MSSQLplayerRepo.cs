using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2.DAL
{
    class MSSQLplayerRepo : IPlayerRepo
    {
        private readonly string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teun\Source\Repos\FUN2killerapp\KillerAppFUN2\KillerAppFUN2\RPGdata.mdf;Integrated Security=True";

        public void addPlayer(Player p)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "INSERT INTO Players (PlayerName, CurrentRoomID, CurrentWeapon, X, Y, Lvl, MaxHP, HP, Defence) VALUES ('" +
                    p.Name + "', " + Convert.ToString(p.RoomID) + ", " + Convert.ToString(p.Weapon.WeaponID) + ", " + Convert.ToString(p.Location.X) + ", " + Convert.ToString(p.Location.Y) + ", " +
                    Convert.ToString(p.Level) + ", " + Convert.ToString(p.MaxHP) + ", " + Convert.ToString(p.HP) + ", " + Convert.ToString(p.Defence) + ");";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }

        public void deletePlayer(string name)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "DELETE FROM Players WHERE PlayerName='" + name + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Player> getAllPlayers()
        {
            List<Player> playerList = new List<Player>();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT CurrentRoomID, X, Y, Lvl, MaxHP, HP, Defence, WeaponID, WeaponDMG, WeaponCRT, WeaponType, WeaponName FROM Players INNER JOIN Weapons ON Players.CurrentWeapon = Weapons.WeaponID;";
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
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
                        string weaponType = reader.GetString(10);
                        string weaponName = reader.GetString(11);
                        Weapon w = new Weapon(weaponID, weaponDMG, weaponCRT, weaponType, weaponName);
                        Player p = new Player(new Point(x, y), playerName, lvl, defence, maxHP, hp, Entity.Direction.South, w, currentRoom);
                        playerList.Add(p);
                    }
                }
            }
            return playerList;
        }

        public Player getPlayer(string playerName)
        {
            Player p = null;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "SELECT CurrentRoomID, X, Y, Lvl, MaxHP, HP, Defence, WeaponID, WeaponDMG, WeaponCRT, WeaponType, WeaponName FROM Players INNER JOIN Weapons ON Players.CurrentWeapon = Weapons.WeaponID WHERE PlayerName = '" + playerName + "';";
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
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
                        string weaponType = reader.GetString(10);
                        string weaponName = reader.GetString(11);
                        Weapon w = new Weapon(weaponID, weaponDMG, weaponCRT, weaponType, weaponName);
                        p = new Player(new Point(x, y), playerName, lvl, defence, maxHP, hp, Entity.Direction.South, w, currentRoom);
                    }
                }
            }
            return p;
        }

        public void updatePlayer(Player p)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string query = "UPDATE Players SET CurrentWeapon=" + Convert.ToString(p.Weapon.WeaponID) + ", Lvl=" + Convert.ToString(p.Level) + ", MaxHP=" + Convert.ToString(p.MaxHP) + ", HP=" +
                    Convert.ToString(p.HP) + ", Defence=" + Convert.ToString(p.Defence) + " WHERE PlayerName='" + p.ToString() + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
