using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;


namespace sweetkin
{
    class Unit_FastFood
    {
        public static void BuildFastFoodCharacter()
        {
            CharacterData fastfoodcharacter = new CharacterDataBuilder
            {

                CharacterID = "Sweetkin_Unit_FastFood",
                Name = "Fast Food",
                NameKey = "Card_XXXIV",
                Size = 1,
                Health = 1,
                AttackDamage = 0,
                AssetPath = "sweet/Unit Assets/FastFood.png",
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = false,
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                    {
                        new CharacterTriggerDataBuilder
                        {
                            Trigger = CharacterTriggerData.Trigger.OnEaten,
                            Description = "Eater gains Quick",
                            DescriptionKey = "Mon_XIV",
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
                                            statusId = VanillaStatusEffectIDs.Quick,
                                            count = 1
                                        }
                                    }
                                }
                            }
                        }
                    }
            }.BuildAndRegister();

            CardData FastFood = new CardDataBuilder
            {
                CardID = "Sweetkin_Card_FastFood",
                Name = "Fast Food",
                NameKey = "Card_XXXIV",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXXIV" },
                Cost = 1,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Rare,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "sweet/Card Assets/Unit_5.png", // change later
                ClanID = Clan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.UnitsAllBanner, VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                    {
                        new CardEffectDataBuilder
                        {
                            EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                            TargetMode = TargetMode.DropTargetCharacter,
                            ParamCharacterData = fastfoodcharacter
                        }
                    }
            }.BuildAndRegister();
        }


        
    }
}
