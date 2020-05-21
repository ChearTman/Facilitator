using Rocket.Core;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class removeGroup
{
    public void RemoveGroup(UnturnedPlayer Player, string GroupId) => R.Permissions.RemovePlayerFromGroup(GroupId, Player);
}

