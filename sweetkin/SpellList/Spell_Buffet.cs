using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Spell_Buffet
    {
        public static void BuildBuffetSpell()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Buffet",
                Name = "Seconds",
                Description = "  Apply [effect0.status0.power] sap to everyone and enhance 10 Hp",
                NameKey = "Card_VII",
                OverrideDescriptionKey = "Spell_VII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_VII" },
                Cost = 2,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = true,
                ClanID = Clan.ID,

                AssetPath = "sweet/Card Assets/card_VII.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Sap,
                                count = 2
                            },

                        }
                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAddTempCardUpgradeToUnits,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                        ParamCardUpgradeData = new CardUpgradeDataBuilder
                        {
                            BonusHP = 10,
                            HideUpgradeIconOnCard = true,
                        }.Build(),
                    }



                },
                

            }.BuildAndRegister();
        }
    }
}
