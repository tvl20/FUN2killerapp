using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KillerAppFUN2.DAL;

namespace KillerAppFUN2
{
    public partial class Form1 : Form
    {
        private bool makingNewPlayer = false;
        private bool editingPlayer = false;
        private DataBaseControl DC = new DataBaseControl();

        private void updateList()
        {
            lb_Players.Items.Clear();
            List<string> names = DC.getPlayerNames();
            foreach (string name in names)
            {
                lb_Players.Items.Add(name);
            }
        }

        private void updateStats(Player p)
        {
            tb_PlayerName.Text = p.Name;
            nm_HP.Value = p.HP;
            nm_MaxHP.Value = p.MaxHP;
            nm_Lvl.Value = p.Level;
            nm_Defence.Value = p.Defence;
            tb_WeaponName.Text = p.Weapon.WeaponName;
            nm_WeaponDMG.Value = p.Weapon.WeaponDMG;
            nm_WeaponCrit.Value = p.Weapon.WeaponCrt;
        }
        public Form1()
        {
            InitializeComponent();
            updateList();
            updateStats(DC.getPlayer(lb_Players.SelectedItem.ToString()));
        }

        private void bt_AddNewPlayer_Click(object sender, EventArgs e)
        {
            if (makingNewPlayer)
            {
                if (nm_HP.Value > nm_MaxHP.Value)
                {
                    MessageBox.Show("Current HP can't be higher then max HP.");
                }
                else if(DC.playerNameTaken(tb_PlayerName.Text) == true)
                {
                    MessageBox.Show("Name is already taken.");
                }
                else
                {
                    //seperated so its easier to read
                    DC.addPlayer(new Player(new Point(0, 0), tb_PlayerName.Text, Convert.ToInt32(nm_Lvl.Value), Convert.ToInt32(nm_Defence.Value), 
                        Convert.ToInt32(nm_MaxHP.Value), Convert.ToInt32(nm_HP.Value), Entity.Direction.South, new Weapon(7, 1, 1), 0));
                    updateList();
                }
            }
            else
            {
                makingNewPlayer = true;

                bt_AddNewPlayer.Text = "Confirm";
                tb_PlayerName.Text = "";
                tb_PlayerName.ReadOnly = false;
                nm_HP.Value = 1;
                nm_HP.ReadOnly = false;
                nm_MaxHP.Value = 1;
                nm_MaxHP.ReadOnly = false;
                nm_Lvl.Value = 1;
                nm_Lvl.ReadOnly = false;
                nm_Defence.Value = 1;
                nm_Defence.ReadOnly = false;

                lb_WeaponName.Visible = false;
                lb_WeaponDMG.Visible = false;
                lb_WeaponCRT.Visible = false;
                tb_WeaponName.Visible = false;
                nm_WeaponDMG.Visible = false;
                nm_WeaponCrit.Visible = false;
            }
        }
    }
}
