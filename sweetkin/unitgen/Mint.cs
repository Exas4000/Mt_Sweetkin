using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class Mint
    {
        public static void BuildMintCharacter()
        {
            CharacterData Mintcharacter = new CharacterDataBuilder
            {
                CharacterID = "Sweetkin_Unit_Mint",
                Name = "Mint",
                NameKey = "Card_XXII",
                Size = 5,
                Health = 340,
                AttackDamage = 0,
                AssetPath = "sweet/Unit Assets/mint.png",                
                PriorityDraw = true,
                StartingStatusEffects = new StatusEffectStackData[]
                {
                     new StatusEffectStackData
                     {
                        statusId = VanillaStatusEffectIDs.Emberdrain,
                        count = 2
                     }
                },
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnHit,
                        Description = "Apply Frostbite [effect0.status0.power] to all enemies",
                        DescriptionKey = "Mon_II",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                                    TargetMode = TargetMode.Room,
                                    TargetTeamType = Team.Type.Heroes,
                                    ParamStatusEffects = new StatusEffectStackData[]
                                    {
                                        new StatusEffectStackData
                                        {
                                            statusId = VanillaStatusEffectIDs.Frostbite,
                                            count = 5
                                        }
                                    }
                                }
                        },
                    }
                }
            }.BuildAndRegister();

            CardData Mint = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Mint",
                Name = "Mint",
                NameKey = "Card_XXII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXII" },
                Cost = 4,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Rare,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_14.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = typeof(CardEffectSpawnMonster),
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = Mintcharacter,
                            EffectStateName = "CardEffectSpawnMonster"
                        }
                }
            }.BuildAndRegister();

            new CardUpgradeDataBuilder()
            {
                upgradeTitle = "Sweetkin_Essence_XXII",
                UpgradeTitleKey = "Sweetkin_Essence_XXII",
                SourceSynthesisUnit = Mintcharacter,
                UpgradeDescription = "Essence_Card_XXII",
                UpgradeDescriptionKey = "Essence_Card_XXII",

                BonusHP = 100,
                BonusSize = 2,

            }.Build();
        }
        
    }
}
