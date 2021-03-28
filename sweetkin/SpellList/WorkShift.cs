using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class WorkShift
    {
        public static void BuildSpell_WorkShift()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_WorkShift",
                Name = "Work Shift",
                Description = "Heal [effect0.power] and push the target to the back",
                NameKey = "Card_XVIII",
                OverrideDescriptionKey = "Spell_XVIII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XVIII" },
                Cost = 2,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_XVIII.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {


                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectHeal",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                        ParamInt = 20
                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectFloorRearrange,
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                        ParamInt = 1


                    }
                }

            }.BuildAndRegister();
        }
    }
}
