using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Managers;
using sweetkin.upgrades;
using BepInEx.Logging;

namespace sweetkin
{
    class HeroSweet
    {
        public static void BuildHeroV2()
        {
            var championCharacterBuilder = new CharacterDataBuilder
            {
                CharacterID = "Sweetkin_Exile",
                Name = "Sally",
                NameKey = "Sweetkin_Exile_Name",
                Size = 3,
                Health = 50,
                AttackDamage = 10,
                StartingStatusEffects = new StatusEffectStackData[]
                {
                     new StatusEffectStackData
                     {
                        statusId = "eatmany",
                        count = 6
                     }
                },
                AssetPath = "sweet/Unit Assets/sally_cherry.png", //
            };

            new ChampionCardDataBuilder()
            {

                Champion = championCharacterBuilder,
                ChampionIconPath = "sweet/Clan Assets/icon_sally.png",
                ChampionSelectedCue = "",
                StarterCardData = CustomCardManager.GetCardDataByID("Sweetkin_Card_Dove"),
                UpgradeTree = new CardUpgradeTreeDataBuilder
                {
                    UpgradeTrees = new List<List<CardUpgradeDataBuilder>>
                    {
                        new List<CardUpgradeDataBuilder>
                        {
                            Security_I.Builder(),
                            Security_II.Builder(),
                            Security_III.Builder(),
                        },
                        new List<CardUpgradeDataBuilder>
                        {                           
                            Catering_I.Builder(),
                            Catering_II.Builder(),
                            Catering_III.Builder(),
                        },
                        new List<CardUpgradeDataBuilder>
                        {
                            Janitor_I.Builder(),
                            Janitor_II.Builder(),
                            Janitor_III.Builder(),

                        }
                    },
                },
                CardID = "Sweetkin_Exile_card",
                Name = "Sweet Sally",
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/Unit_17.png",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXXVI" },


            }.BuildAndRegister(1);

        }
    }
}
