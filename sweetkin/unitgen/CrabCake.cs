using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class CrabCake
    {
        public static void BuildCrabcakeCharacter()
        {

            CharacterData CrabCakecharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_CrabCake",
                Name = "Crab Cake",
                NameKey = "Card_XX",
                Size = 1,
                Health = 1,
                AttackDamage = 2,
                AssetPath = "sweet/Unit Assets/crabcake.png",
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = false,
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                    {
                        new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.OnEaten,
                            Description = "Eater gains [effect0.status0.power] Armor",
                            DescriptionKey = "Mon_I",
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
                                            statusId = VanillaStatusEffectIDs.Armor,
                                            count = 20
                                        }
                                    }
                                }
                            }
                        }
                    }
            }.BuildAndRegister();

            CardData CrabChar = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_CrabCake",
                Name = "Crab Cake",
                NameKey = "Card_XX",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XX" },
                Cost = 1,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_15.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = typeof(CardEffectSpawnMonster),
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = CrabCakecharacter,
                            EffectStateName = "CardEffectSpawnMonster"
                        }
                }
            }.BuildAndRegister();

            new CardUpgradeDataBuilder()
            {
                upgradeTitle = "Sweetkin_Essence_XX",
                UpgradeTitleKey = "Sweetkin_Essence_XX",
                SourceSynthesisUnit = CrabCakecharacter,
                UpgradeDescription = "Essence_Card_XX",
                UpgradeDescriptionKey = "Essence_Card_XX",

                StatusEffectUpgrades = new List<StatusEffectStackData>
                {
                     new StatusEffectStackData
                     {
                        statusId = VanillaStatusEffectIDs.Armor,
                        count = 20
                     },
                },

            }.Build();
        }
    }
}
