using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Spell_Snakification
    {
        public static void BuildsnakificationSpell()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Snakification",
                Name = "Snakification",
                Description = " Kill a non-boss enemy unit, give all the other [effect1.status0.power] armor",
                NameKey = "Card_XIV",
                OverrideDescriptionKey = "Spell_XIV",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XIV" },
                Cost = 1,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,
                
                AssetPath = "sweet/Card Assets/card_XIV.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectKill,
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes,
                        TargetIgnoreBosses = true,

                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Heroes,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Armor,
                                count = 20
                            }
                        }
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
