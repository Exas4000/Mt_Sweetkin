using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Spell_AllYouCan
    {
        public static void BuildSpell_allyoucan()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_AllYouCan",
                Name = "All You Can Eat",
                Description = "  Apply Buffet [effect0.status0.power]",
                NameKey = "Card_VI",
                OverrideDescriptionKey = "Spell_VI",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_VI" },
                Cost = 1,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,

                AssetPath = "sweet/Card Assets/card_VI.png", // change later
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
                                count = 3
                            },
                            
                        }
                    },


                }
                

            }.BuildAndRegister();
        }
    }
}
