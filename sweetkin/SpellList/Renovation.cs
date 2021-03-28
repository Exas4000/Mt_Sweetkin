using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Renovation
    {
        public static void BuildSpell_Renovation()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Renovation",
                Name = "Spacial Renovation",
                Description = "Give a Room 3 capacity, heal the Pyre for 10.",
                NameKey = "Card_V",
                OverrideDescriptionKey = "Spell_V",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_V" },
                Cost = 3,
                Rarity = CollectableRarity.Rare, ///rare, switch to common for testing
                TargetsRoom = true,
                Targetless = true,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_V.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {

                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAdjustRoomCapacity,
                        ParamInt = 3,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Monsters

                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectHealTrain,
                        ParamInt = 10,
                        TargetMode = TargetMode.Tower, //should target the pyre for a heal
                        TargetTeamType = Team.Type.Monsters

                    }
                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateName = "CardTraitExhaustState"
                    }
                }

            }.BuildAndRegister();
        }
    }
}
