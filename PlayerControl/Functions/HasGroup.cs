using Rocket.Core;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class hasGroup
{
    public bool HasGroup(UnturnedPlayer Player, string GroupID) => R.Permissions.GetGroups(Player, true).Any(group=> group.Id == GroupID);
}

