using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Managers;
using sweetkin.upgrades;
using BepInEx.Logging;

namespace sweetkin
{
    class Rosette
    {
        public static void BuildHero()
        {
            var championCharacterBuilder = new CharacterDataBuilder
            {
                CharacterID = "Sweetkin_champion",
                Name = "Rosette",
                Size = 2,
                Health = 10,
                AttackDamage = 0,
                AssetPath = "sweet/Unit Assets/RosetteV2.png", //
            };

            new ChampionCardDataBuilder()
            {
                
                Champion = championCharacterBuilder,
                ChampionIconPath = "sweet/Clan Assets/Icon_rosette.png",
                ChampionSelectedCue = "",
                StarterCardData = CustomCardManager.GetCardDataByID("Sweetkin_Card_Hospi"),
                UpgradeTree = new CardUpgradeTreeDataBuilder
                {
                    UpgradeTrees = new List<List<CardUpgradeDataBuilder>>
                    {
                        new List<CardUpgradeDataBuilder>
                        {
                            Nurturer.Builder(),
                            Nurturer_II.Builder(),
                            Nurturer3.Builder(),
                        },
                        new List<CardUpgradeDataBuilder>
                        {
                            Host.Builder(),
                            Host_II.Builder(),
                            Host_III.Builder(),
                        },
                        new List<CardUpgradeDataBuilder>
                        {
                            Brute.Builder(),
                            Brute_II.Builder(),
                            Brute_III.Builder(),

                        }
                    },
                },
                CardID = "Sweetkin_champion_card",
                Name = "Rosette",
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/Unit_11.png",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XXXV" },


            }.BuildAndRegister();

        }
    }
}

