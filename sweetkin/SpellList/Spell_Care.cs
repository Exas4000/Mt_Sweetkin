using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Spell_Care
    {
        public static void BuildCare()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Care",
                Name = "Empowering Care",
                Description = "Increase a friendly unit's health by 10 and Heal it by [effect0.power]",
                NameKey = "Card_VIII",
                OverrideDescriptionKey = "Spell_VIII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_VIII" },
                Cost = 2,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_VIII.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectHeal",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters,
                        ParamInt = 10,
                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAddTempCardUpgradeToUnits,

                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters,
                        ParamCardUpgradeData = new CardUpgradeDataBuilder
                        {
                            BonusHP = 10,
                            HideUpgradeIconOnCard = true,
                        }.Build(),
                    }
                    
                
                }

            }.BuildAndRegister();
        }
    }
}
