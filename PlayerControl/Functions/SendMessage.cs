using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facilitator;

public class sendMessage
{

    public void Message(UnturnedPlayer Player, string Text) => ChatManager.serverSendMessage(Text, UnityEngine.Color.white, null, Player.SteamPlayer(), EChatMode.SAY, null, true);

    public void Message(UnturnedPlayer Player, string Text, ChatColor color)
    {
        switch (color)
        {
            case ChatColor.White:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.white, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
            case ChatColor.Yellow:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.yellow, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
            case ChatColor.Red:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.red, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
            case ChatColor.Magenta:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.magenta, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
            case ChatColor.Grey:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.grey, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
            case ChatColor.Green:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.green, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
            case ChatColor.Cyan:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.cyan, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
            case ChatColor.Blue:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.blue, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
            case ChatColor.Black:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.black, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
        }
        
    }

    public void Message(UnturnedPlayer Player, string Text, ChatColor color, string ImageUrl)
    {
        switch (color)
        {
            case ChatColor.White:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.white, null, Player.SteamPlayer(), EChatMode.SAY, ImageUrl, true);
                break;
            case ChatColor.Yellow:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.yellow, null, Player.SteamPlayer(), EChatMode.SAY, ImageUrl, true);
                break;
            case ChatColor.Red:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.red, null, Player.SteamPlayer(), EChatMode.SAY, ImageUrl, true);
                break;
            case ChatColor.Magenta:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.magenta, null, Player.SteamPlayer(), EChatMode.SAY, ImageUrl, true);
                break;
            case ChatColor.Grey:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.grey, null, Player.SteamPlayer(), EChatMode.SAY, ImageUrl, true);
                break;
            case ChatColor.Green:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.green, null, Player.SteamPlayer(), EChatMode.SAY, ImageUrl, true);
                break;
            case ChatColor.Cyan:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.cyan, null, Player.SteamPlayer(), EChatMode.SAY, ImageUrl, true);
                break;
            case ChatColor.Blue:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.blue, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
            case ChatColor.Black:
                ChatManager.serverSendMessage(Text, UnityEngine.Color.black, null, Player.SteamPlayer(), EChatMode.SAY, null, true);
                break;
        }
    }
}

