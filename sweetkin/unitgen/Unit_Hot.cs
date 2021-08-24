using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class Unit_Hot
    {
        public static void BuildHOTCharacter()
        {
            CharacterData Hotcharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_Hot",
                Name = "Pyre-Tatoe",
                NameKey = "Card_XXX",
                Size = 2,
                Health = 30,
                AttackDamage = 30,
                AssetPath = "sweet/Unit Assets/patate.png", //change later
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = true,
                StartingStatusEffects = new StatusEffectStackData[]
                {
                     new StatusEffectStackData
                     {
                        statusId = "eatmany",
                        count = 4
                     }
                },
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {


                        new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.OnEaten,
                            Description = "Deal 5 damage to everyone",
                            DescriptionKey = "Mon_X",
                            EffectBuilders = new List<CardEffectDataBuilder>
                            {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
                                    TargetMode = TargetMode.Room,
                                    TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                                    ParamInt = 5

                                }
                            },
                        }
                }
            }.BuildAndRegister();

            CardData hotpotato = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Hot",
                Name = "Pyre-Tatoe",
                NameKey = "Card_XXX",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXX" },
                Cost = 2,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_12.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = typeof(CardEffectSpawnMonster),
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = Hotcharacter,
                            EffectStateName = "CardEffectSpawnMonster"
                        }
                }
            }.BuildAndRegister();

            new CardUpgradeDataBuilder()
            {
                upgradeTitle = "Sweetkin_Essence_XXX",
                UpgradeTitleKey = "Sweetkin_Essence_XXX",
                SourceSynthesisUnit = Hotcharacter,
                UpgradeDescription = "Essence_Card_XXX",
                UpgradeDescriptionKey = "Essence_Card_XXX",
                BonusDamage = 15,
                BonusHP = 15,

                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.PostCombat,
                            Description = "Deal 5 damage to everyone",
                            DescriptionKey = "Mon_X",
                            EffectBuilders = new List<CardEffectDataBuilder>
                            {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
                                    TargetMode = TargetMode.Room,
                                    TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                                    ParamInt = 5

                                }
                            },
                        }
                },

            }.Build();
        }
    }
}
