using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Punish
    {
        public static void BuildSpell_Punish()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_punish",
                Name = "Punish",
                Description = "Deal [effect0.power] damage to an enemy",
                NameKey = "Card_III",
                OverrideDescriptionKey = "Spell_III",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_III" },
                Cost = 2,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_III.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {


                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectDamage",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes,
                        ParamInt = 15
                    }
                    
                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateType = VanillaCardTraitTypes.CardTraitIgnoreArmor
                    }
                }

            }.BuildAndRegister();
        }
    }
}
