﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppFUN2.DAL
{
    interface IPlayerRepo
    {
        Player getPlayer(string playerName);
        List<Player> getAllPlayers();
        void addPlayer(Player p);
        void updatePlayer(Player p);
        void deletePlayer(string name);
    }
}
