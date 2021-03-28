using System.Collections.Generic;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin
{
    class Unit_Butler
    {
        public static void BuildButlerCharacter()
        {
            CharacterData Butlercharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_Butler",
                Name = "Ice Cream Butler",
                NameKey = "Card_XXXIII",
                Size = 2,
                Health = 15,
                AttackDamage = 5,
                AssetPath = "sweet/Unit Assets/sweetkin_tall_ice_cream.png", //change later
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = false,
                StartingStatusEffects = new StatusEffectStackData[]
                {
                     new StatusEffectStackData
                     {
                        statusId = "eatmany",
                        count = 3
                     }
                },
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                     
                        
                        new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.OnEaten,
                            Description = "Apply frostbite [effect0.status0.power] on enemy",
                            DescriptionKey = "Mon_XIII",
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
                                            count = 4
                                        }
                                    }
                                }
                            },
                        }
                }
            }.BuildAndRegister();

            CardData Butler = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Butler",
                Name = "Ice Cream Butler",
                NameKey = "Card_XXXIII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXXIII" },
                Cost = 1,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_8.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = Butlercharacter
                        }
                }
            }.BuildAndRegister();
        }

    }
}
