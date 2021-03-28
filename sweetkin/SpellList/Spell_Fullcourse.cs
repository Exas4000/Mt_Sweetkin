using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Spell_Fullcourse
    {
        public static void BuildFullcoursenSpell()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_FullCourse",
                Name = "Full Course",
                Description = "  Apply [effect0.status0.power] armor, [effect0.status1.power] Rage and Quick",
                NameKey = "Card_XI",
                OverrideDescriptionKey = "Spell_XI",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XI" },
                Cost = 5,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,

                AssetPath = "sweet/Card Assets/card_XI.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {                    
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Armor,
                                count = 20
                            },
                            
                            
                        }
                    },
                    new CardEffectDataBuilder
                    {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                                    TargetMode = TargetMode.DropTargetCharacter,
                                    TargetTeamType = Team.Type.Monsters,
                                    ParamStatusEffects = new StatusEffectStackData[]
                                    {
                                        new StatusEffectStackData
                                        {
                                            statusId = VanillaStatusEffectIDs.Quick,
                                            count = 1
                                        }
                                    }
                    },
                    new CardEffectDataBuilder
                    {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                                    TargetMode = TargetMode.DropTargetCharacter,
                                    TargetTeamType = Team.Type.Monsters,
                                    ParamStatusEffects = new StatusEffectStackData[]
                                    {
                                        new StatusEffectStackData
                                        {
                                            statusId = VanillaStatusEffectIDs.Rage,
                                            count = 8
                                        },
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
