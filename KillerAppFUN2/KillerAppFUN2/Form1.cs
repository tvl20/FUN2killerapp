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
        private int editingPlayerRoom;
        private DataBaseControl DC = new DataBaseControl();

        private void updateList()
        {
            lb_Players.Items.Clear();
            List<string> names = DC.getPlayerNames();
            foreach (string name in names)
            {
                lb_Players.Items.Add(name);
            }
            lb_Players.SelectedIndex = 0;
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
                else if (tb_PlayerName.Text.Length < 3)
                {
                    MessageBox.Show("Name must be at least 4 characters long");
                }
                else if (DC.playerNameTaken(tb_PlayerName.Text) == true)
                {
                    MessageBox.Show("Name is already taken.");
                }
                else
                {
                    //seperated so its easier to read
                    DC.addPlayer(new Player(new Point(0, 0), tb_PlayerName.Text, Convert.ToInt32(nm_Lvl.Value), Convert.ToInt32(nm_Defence.Value), 
                        Convert.ToInt32(nm_MaxHP.Value), Convert.ToInt32(nm_HP.Value), Entity.Direction.South, DC.getWeapon("Broken Blade"), 2));
                    
                    makingNewPlayer = false;

                    tb_PlayerName.ReadOnly = true;
                    nm_HP.ReadOnly = true;
                    nm_Defence.ReadOnly = true;
                    nm_Lvl.ReadOnly = true;
                    nm_MaxHP.ReadOnly = true;

                    lb_WeaponName.Visible = true;
                    lb_WeaponDMG.Visible = true;
                    lb_WeaponCRT.Visible = true;
                    tb_WeaponName.Visible = true;
                    nm_WeaponDMG.Visible = true;
                    nm_WeaponCrit.Visible = true;

                    bt_AddNewPlayer.Text = "New player";
                    bt_Continue.Visible = true;
                    bt_EditPlayer.Visible = true;
                    bt_Cancel.Visible = false;
                    bt_DeletePlayer.Visible = true;
                    updateList();
                    updateStats(DC.getPlayer(lb_Players.SelectedItem.ToString()));
                }
            }
            else
            {
                makingNewPlayer = true;

                bt_AddNewPlayer.Text = "Confirm";
                bt_Continue.Visible = false;
                bt_EditPlayer.Visible = false;
                bt_Cancel.Visible = true;
                bt_DeletePlayer.Visible = false;

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

        private void bt_EditPlayer_Click(object sender, EventArgs e)
        {
            if (editingPlayer)
            {
                if (nm_HP.Value > nm_MaxHP.Value)
                {
                    MessageBox.Show("Current HP can't be higher then max HP.");
                }
                else
                {
                    DC.updatePlayer(new Player(new Point(0, 0), tb_PlayerName.Text, Convert.ToInt32(nm_Lvl.Value), Convert.ToInt32(nm_Defence.Value),
                        Convert.ToInt32(nm_MaxHP.Value), Convert.ToInt32(nm_HP.Value), Entity.Direction.South, DC.getWeapon(lb_Weapons.SelectedItem.ToString().Remove(lb_Weapons.SelectedItem.ToString().IndexOf(':'))), editingPlayerRoom));
                    
                    editingPlayer = false;

                    tb_PlayerName.ReadOnly = true;
                    nm_HP.ReadOnly = true;
                    nm_Defence.ReadOnly = true;
                    nm_Lvl.ReadOnly = true;
                    nm_MaxHP.ReadOnly = true;
                    
                    lb_WeaponName.Visible = true;
                    lb_WeaponDMG.Visible = true;
                    lb_WeaponCRT.Visible = true;
                    tb_WeaponName.Visible = true;
                    nm_WeaponDMG.Visible = true;
                    nm_WeaponCrit.Visible = true;

                    lb_ChooseWeapon.Visible = false;
                    lb_Weapons.Visible = false;

                    bt_EditPlayer.Text = "Edit selected player";
                    bt_Continue.Visible = true;
                    bt_AddNewPlayer.Visible = true;
                    bt_Cancel.Visible = false;
                    bt_DeletePlayer.Visible = true;
                    updateList();
                    updateStats(DC.getPlayer(lb_Players.SelectedItem.ToString()));
                }
            }
            else
            {
                editingPlayer = true;
                Player p = DC.getPlayer(lb_Players.SelectedItem.ToString());
                editingPlayerRoom = p.RoomID;

                bt_EditPlayer.Text = "Confirm";
                bt_AddNewPlayer.Visible = false;
                bt_Continue.Visible = false;
                bt_Cancel.Visible = true;
                bt_DeletePlayer.Visible = false;

                tb_PlayerName.Text = p.Name;
                tb_PlayerName.ReadOnly = true;
                nm_HP.Value = p.HP;
                nm_HP.ReadOnly = false;
                nm_MaxHP.Value = p.MaxHP;
                nm_MaxHP.ReadOnly = false;
                nm_Lvl.Value = p.Level;
                nm_Lvl.ReadOnly = false;
                nm_Defence.Value = p.Defence;
                nm_Defence.ReadOnly = false;

                lb_WeaponName.Visible = false;
                lb_WeaponDMG.Visible = false;
                lb_WeaponCRT.Visible = false;
                tb_WeaponName.Visible = false;
                nm_WeaponDMG.Visible = false;
                nm_WeaponCrit.Visible = false;

                lb_ChooseWeapon.Visible = true;
                lb_Weapons.Visible = true;
                lb_Weapons.Items.Clear();
                List<Weapon> weaponList = DC.getAllWeapons();
                foreach (Weapon w in weaponList)
                {
                    lb_Weapons.Items.Add(w.WeaponName+": "+w.WeaponType+": "+ Convert.ToString(w.WeaponDMG)+" ~ "+Convert.ToString(w.WeaponCrt+"%"));
                }
            }
        }

        private void lb_Players_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateStats(DC.getPlayer(lb_Players.SelectedItem.ToString()));
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            bt_AddNewPlayer.Text = "New player";
            bt_EditPlayer.Text = "Edit selected player";

            bt_Cancel.Visible = false;
            bt_Continue.Visible = true;
            bt_EditPlayer.Visible = true;
            bt_AddNewPlayer.Visible = true;
            bt_DeletePlayer.Visible = true;

            if (makingNewPlayer)
            {
                makingNewPlayer = false;

                tb_PlayerName.ReadOnly = true;
                nm_HP.ReadOnly = true;
                nm_Defence.ReadOnly = true;
                nm_Lvl.ReadOnly = true;
                nm_MaxHP.ReadOnly = true;


                lb_WeaponName.Visible = true;
                lb_WeaponDMG.Visible = true;
                lb_WeaponCRT.Visible = true;
                tb_WeaponName.Visible = true;
                nm_WeaponDMG.Visible = true;
                nm_WeaponCrit.Visible = true;
                
                updateList();
                updateStats(DC.getPlayer(lb_Players.SelectedItem.ToString()));
            }

            if (editingPlayer)
            {
                editingPlayer = false;

                tb_PlayerName.ReadOnly = true;
                nm_HP.ReadOnly = true;
                nm_Defence.ReadOnly = true;
                nm_Lvl.ReadOnly = true;
                nm_MaxHP.ReadOnly = true;

                lb_WeaponName.Visible = true;
                lb_WeaponDMG.Visible = true;
                lb_WeaponCRT.Visible = true;
                tb_WeaponName.Visible = true;
                nm_WeaponDMG.Visible = true;
                nm_WeaponCrit.Visible = true;

                lb_ChooseWeapon.Visible = false;
                lb_Weapons.Visible = false;
                
                updateList();
                updateStats(DC.getPlayer(lb_Players.SelectedItem.ToString()));
            }
        }

        private void bt_DeletePlayer_Click(object sender, EventArgs e)
        {
            DC.deletePlayer(lb_Players.SelectedItem.ToString());
            updateList();
        }
    }
}
