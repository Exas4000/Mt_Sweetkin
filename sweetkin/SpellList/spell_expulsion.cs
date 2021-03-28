using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class spell_expulsion
    {
        public static void BuildSpell_Expulsion()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Expulsion",
                Name = "Back of the line!",
                Description = "Deal [effect0.power] damage to the front enemy and push them to the back",
                NameKey = "Card_X",
                OverrideDescriptionKey = "Spell_X",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_X" },
                Cost = 4,
                Rarity = CollectableRarity.Rare,
                TargetsRoom = true,
                Targetless = true,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_X.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {

                    
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectDamage",
                        TargetMode = TargetMode.FrontInRoom,
                        TargetTeamType = Team.Type.Heroes,
                        ParamInt = 150
                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectFloorRearrange,
                        TargetMode = TargetMode.FrontInRoom,
                        TargetTeamType = Team.Type.Heroes,
                        ParamInt = 1


                    }
                }

            }.BuildAndRegister();
        }
    }
}
