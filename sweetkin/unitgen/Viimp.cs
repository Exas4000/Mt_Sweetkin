using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class Viimp
    {
        public static void BuildViimpCharacter()
        {
            CharacterData Viimpcharacter = new CharacterDataBuilder
            {
                CharacterID = "Sweetkin_Unit_Viimp",
                Name = "V.I.Imp",
                NameKey = "Card_XXXII",
                Size = 1,
                Health = 1,
                AttackDamage = 1,
                AssetPath = "sweet/Unit Assets/vip.png",
                SubtypeKeys = new List<string> { "SubtypesData_Imp_0f9b989f-15b5-4b16-8378-5d8ed8691e7c" },
                PriorityDraw = false,
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnSpawn,
                        Description = "Gain 20 gold",
                        DescriptionKey = "Mon_XII",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectRewardGold,
                                    TargetMode = TargetMode.Room,
                                    TargetTeamType = Team.Type.Monsters,
                                    ParamInt = 20
                                }
                        },
                    }
                },
                
                //sound section and chatter section. Both unuseable in the current trainwork 
                

            }.BuildAndRegister();

            CardData Viimp = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Viimp",
                Name = "V.I.Imp",
                NameKey = "Card_XXXII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXXII" },
                Cost = 1,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_6.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = typeof(CardEffectSpawnMonster),
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = Viimpcharacter,
                            EffectStateName = "CardEffectSpawnMonster"
                        }
                }
            }.BuildAndRegister();

            new CardUpgradeDataBuilder()
            {
                upgradeTitle = "Sweetkin_Essence_XXXII",
                UpgradeTitleKey = "Sweetkin_Essence_XXXII",
                SourceSynthesisUnit = Viimpcharacter,
                UpgradeDescription = "Essence_Card_XXXII",
                UpgradeDescriptionKey = "Essence_Card_XXXII",
                

                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnSpawn,
                        Description = "Gain 20 gold",
                        DescriptionKey = "Mon_XII",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                                new CardEffectDataBuilder
                                {
                                    EffectStateType = VanillaCardEffectTypes.CardEffectRewardGold,
                                    TargetMode = TargetMode.Room,
                                    TargetTeamType = Team.Type.Monsters,
                                    ParamInt = 20
                                }
                        },
                    }
                },

            }.Build();
        }
    }
}
