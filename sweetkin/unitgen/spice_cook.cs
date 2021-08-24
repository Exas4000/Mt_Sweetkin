using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class spice_cook
    {
        public static void BuildCookCharacter()
        {
            CharacterData Cayennecharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_Cayenne",
                Name = "Cayenne",
                NameKey = "Card_XXVII",
                Size = 1,
                Health = 1,
                AttackDamage = 0,
                AssetPath = "sweet/Unit Assets/noodle.png",
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = false,
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                    {
                        new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.OnEaten,
                            Description = "Eater gains 8 Rage",
                            DescriptionKey = "Mon_VII",
                            EffectBuilders = new List<CardEffectDataBuilder>
                            {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                                    TargetMode = TargetMode.LastFeederCharacter,
                                    TargetTeamType = Team.Type.Monsters,
                                    ParamStatusEffects = new StatusEffectStackData[]
                                    {
                                        new StatusEffectStackData
                                        {
                                            statusId = VanillaStatusEffectIDs.Rage,
                                            count = 8
                                        }
                                    }
                                }
                            }
                        }
                    }
            }.BuildAndRegister();

            CardData CayenneChar = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Cayenne",
                Name = "Cayenne",
                NameKey = "Card_XXVII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXVII" },
                Cost = 2,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_13.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                    {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = typeof(CardEffectSpawnMonster),
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = Cayennecharacter,
                            EffectStateName = "CardEffectSpawnMonster"
                        }
                    }
            }.BuildAndRegister();

            new CardUpgradeDataBuilder()
            {
                upgradeTitle = "Sweetkin_Essence_XXVII",
                UpgradeTitleKey = "Sweetkin_Essence_XXVII",
                SourceSynthesisUnit = Cayennecharacter,
                UpgradeDescription = "Essence_Card_XXVII",
                UpgradeDescriptionKey = "Essence_Card_XXVII",

                StatusEffectUpgrades = new List<StatusEffectStackData>
                {
                     new StatusEffectStackData
                     {
                        statusId = VanillaStatusEffectIDs.Rage,
                        count = 8
                     },
                },

            }.Build();

            CharacterData Cookcharacter = new CharacterDataBuilder
            {
                CharacterID = "Sweetkin_Unit_SpiceCook",
                Name = "Spice Cook",
                NameKey = "Card_XXVIII",
                Size = 2,
                Health = 10,
                AttackDamage = 30,
                AssetPath = "sweet/Unit Assets/sweetkin_tall_orange.png",
                PriorityDraw = false,
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnKill,
                        Description = "Spawn a Cayenne",
                        DescriptionKey = "Mon_VIII",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                                    TargetMode = TargetMode.Room,
                                    ParamCharacterData = Cayennecharacter,
                                    ParamInt = 1
                                }
                        },
                    }
                }
            }.BuildAndRegister();

            CardData cook = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_SpiceCook",
                Name = "Spice Cook",
                NameKey = "Card_XXVIII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXVIII" },
                Cost = 2,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Rare,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_7.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = typeof(CardEffectSpawnMonster),
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = Cookcharacter,
                            EffectStateName = "CardEffectSpawnMonster"
                        }
                }
            }.BuildAndRegister();

            new CardUpgradeDataBuilder()
            {
                upgradeTitle = "Sweetkin_Essence_XXVIII",
                UpgradeTitleKey = "Sweetkin_Essence_XXVIII",
                SourceSynthesisUnit = Cookcharacter,
                UpgradeDescription = "Essence_Card_XXVIII",
                UpgradeDescriptionKey = "Essence_Card_XXVIII",
                BonusDamage = 15,

                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnKill,
                        Description = "Spawn a Cayenne",
                        DescriptionKey = "Mon_VIII",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                                    TargetMode = TargetMode.Room,
                                    ParamCharacterData = Cayennecharacter,
                                    ParamInt = 1
                                }
                        },
                    }
                },

            }.Build();
        }
    }
}
