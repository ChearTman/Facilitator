using Rocket.Unturned.Player;
using Rocket.Unturned.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class maxSkills
{
    public void MaxSkills(UnturnedPlayer Player)
    {
        Player.SetSkillLevel(UnturnedSkill.Overkill, 7);
        Player.SetSkillLevel(UnturnedSkill.Sharpshooter, 7);
        Player.SetSkillLevel(UnturnedSkill.Dexerity, 5);
        Player.SetSkillLevel(UnturnedSkill.Cardio, 5);
        Player.SetSkillLevel(UnturnedSkill.Exercise, 5);
        Player.SetSkillLevel(UnturnedSkill.Diving, 5);
        Player.SetSkillLevel(UnturnedSkill.Parkour, 5);

        Player.SetSkillLevel(UnturnedSkill.Sneakybeaky, 7);
        Player.SetSkillLevel(UnturnedSkill.Vitality, 5);
        Player.SetSkillLevel(UnturnedSkill.Immunity, 5);
        Player.SetSkillLevel(UnturnedSkill.Toughness, 5);
        Player.SetSkillLevel(UnturnedSkill.Strength, 5);
        Player.SetSkillLevel(UnturnedSkill.Warmblooded, 5);
        Player.SetSkillLevel(UnturnedSkill.Survival, 5);

        Player.SetSkillLevel(UnturnedSkill.Healing, 7);
        Player.SetSkillLevel(UnturnedSkill.Crafting, 3);
        Player.SetSkillLevel(UnturnedSkill.Outdoors, 5);
        Player.SetSkillLevel(UnturnedSkill.Cooking, 3);
        Player.SetSkillLevel(UnturnedSkill.Fishing, 5);
        Player.SetSkillLevel(UnturnedSkill.Agriculture, 7);
        Player.SetSkillLevel(UnturnedSkill.Mechanic, 5);
        Player.SetSkillLevel(UnturnedSkill.Engineer, 3);
    }

}

