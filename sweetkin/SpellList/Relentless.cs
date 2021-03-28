using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Relentless
    {
        public static void BuildRelentlessSpell()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Relentless",
                Name = "Fight Till The Last One Drops",
                Description = "  Apply Relentless to an enemy",
                NameKey = "Card_IV",
                OverrideDescriptionKey = "Spell_IV",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_IV" },
                Cost = 2,
                Rarity = CollectableRarity.Rare, //switch to rare if this works, document the results
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,

                AssetPath = "sweet/Card Assets/card_IV.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes,
                        TargetIgnoreBosses = true,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Relentless,
                                count = 1
                            }
                            
                        }
                    },


                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateName = "CardTraitExhaustState"
                    },
                    
                }

            }.BuildAndRegister();
        }
    }
}
