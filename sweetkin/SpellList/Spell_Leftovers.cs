using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Spell_Leftovers
    {
        public static void BuildSpell_Leftovers()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Leftovers",
                Name = "Leftovers",
                Description = "  Apply Buffet [effect0.status0.power]",
                NameKey = "Card_XII",
                OverrideDescriptionKey = "Spell_XII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XII" },
                Cost = 1,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,

                AssetPath = "sweet/Card Assets/card_XII.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = "eatmany",
                                count = 1
                            },

                        }
                    },


                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateType = VanillaCardTraitTypes.CardTraitPermafrost
                    }
                }

            }.BuildAndRegister();
        }
    }
}
