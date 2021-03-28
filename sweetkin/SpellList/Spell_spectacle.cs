using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Spell_spectacle
    {
        public static void BuildSpell_Spectacle()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Spectacle",
                Name = "Diner Spectacle",
                Description = "  Apply 1 Lifesteal, 3 Rage and 10 Armor to all friendly units",
                NameKey = "Card_XV",
                OverrideDescriptionKey = "Spell_XV",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XV" },
                Cost = 2,
                Rarity = CollectableRarity.Rare,
                TargetsRoom = true,
                Targetless = true,
                ClanID = Clan.ID,

                AssetPath = "sweet/Card Assets/card_XV.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Monsters,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Lifesteal,
                                count = 1
                            },
                            

                        }
                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Monsters,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Rage,
                                count = 3
                            }

                        }
                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Monsters,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Armor,
                                count = 10
                            }

                        }
                    }


                },                

            }.BuildAndRegister();
        }
    }
}
