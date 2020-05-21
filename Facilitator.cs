using Rocket.Core;
using Rocket.Unturned.Player;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facilitator
{
    public enum ChatColor
    {
        White,
        Yellow,
        Red,
        Magenta,
        Grey,
        Green,
        Cyan,
        Blue,
        Black
    }

    public class Functions
    {
        public hasGroup PlayerHasGroup = new hasGroup();
        public addGroup PlayerAddGroup = new addGroup();
        public removeGroup PlayerRemoveGroup = new removeGroup();
        public maxSkills PlayerMaxSkills = new maxSkills();
        public sendMessage sMessage = new sendMessage();
        public Data dataManager = new Data();
    }
    
}

