using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.unitgen
{
    class Sherbetrus
    {
        public static void BuildSherbetrusCharacter()
        {
            CharacterData cerberuscharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_Sherbetrus",
                Name = "Sherbet-rus",
                NameKey = "Card_XXIII",
                Size = 3,
                Health = 80,
                AttackDamage = 15,
                AssetPath = "sweet/Unit Assets/cerberus.png", //change later
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = true,
                StartingStatusEffects = new StatusEffectStackData[]
                {
                     new StatusEffectStackData
                     {
                        statusId = "eatmany",
                        count = 8
                     }
                },
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {


                        new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.OnEaten,
                            Description = "Apply root [effect0.status0.power] on all enemies",
                            DescriptionKey = "Mon_III",
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
                                            statusId = VanillaStatusEffectIDs.Rooted,
                                            count = 1
                                        }
                                    }
                                }
                            },
                        }
                }
            }.BuildAndRegister();

            CardData Butler = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Sherbetrus",
                Name = "Sherbet-rus",
                NameKey = "Card_XXIII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXIII" },              
                Cost = 3,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_16.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = cerberuscharacter
                        }
                }
            }.BuildAndRegister();
        }
    }
}
