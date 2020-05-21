using Rocket.API;
using Rocket.Unturned.Player;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facilitator.Player
{ 
    public class FPlayer
    {
        static CSteamID PlayerSteam64ID { get; set; }
        public Functions Funcs = new Functions();
        //static hasGroup PlayerHasGroup = new hasGroup();
        //static addGroup PlayerAddGroup = new addGroup();
        //static removeGroup PlayerRemoveGroup = new removeGroup();
        //static maxSkills PlayerMaxSkills = new maxSkills();

        public FPlayer(UnturnedPlayer player) => PlayerSteam64ID = player.CSteamID;
        public FPlayer(IRocketPlayer RocketPlayer) => PlayerSteam64ID = ((UnturnedPlayer)RocketPlayer).CSteamID;
        
        #region Functions
        public void Message(string Text) => Funcs.sMessage.Message(UnturnedPlayer.FromCSteamID(PlayerSteam64ID), Text);
        public void Message(string Text, ChatColor Color) => Funcs.sMessage.Message(UnturnedPlayer.FromCSteamID(PlayerSteam64ID), Text, Color);
        public void Message(string Text, ChatColor Color, string ImageUrl) => Funcs.sMessage.Message(UnturnedPlayer.FromCSteamID(PlayerSteam64ID), Text, Color, ImageUrl);
        public bool HasGroup(string GroupId) => Funcs.PlayerHasGroup.HasGroup(UnturnedPlayer.FromCSteamID(PlayerSteam64ID), GroupId);
        public void AddGroup(string GroupId) => Funcs.PlayerAddGroup.AddGroup(UnturnedPlayer.FromCSteamID(PlayerSteam64ID), GroupId);
        public void RemoveGroup(string GroupId) => Funcs.PlayerRemoveGroup.RemoveGroup(UnturnedPlayer.FromCSteamID(PlayerSteam64ID), GroupId);
        public void MaxSkills() => Funcs.PlayerMaxSkills.MaxSkills(UnturnedPlayer.FromCSteamID(PlayerSteam64ID));
        #endregion

        #region DataManager
        public void setData(string DataName, string Text) => Funcs.dataManager.SetData(ulong.Parse(PlayerSteam64ID.ToString()), DataName, Text);
        public void setData(string DataName, long Number) => Funcs.dataManager.SetData(ulong.Parse(PlayerSteam64ID.ToString()), DataName, Number);
        public void setData(string DataName, bool Boolean) => Funcs.dataManager.SetData(ulong.Parse(PlayerSteam64ID.ToString()), DataName, Boolean);
        public string getDataText(string DataName) => Funcs.dataManager.getDataText(ulong.Parse(PlayerSteam64ID.ToString()), DataName);
        public long getDataNumber(string DataName) => Funcs.dataManager.getDataNumber(ulong.Parse(PlayerSteam64ID.ToString()), DataName);
        public bool getDataBool(string DataName) => Funcs.dataManager.getDataBool(ulong.Parse(PlayerSteam64ID.ToString()), DataName);
        #endregion
    }
}