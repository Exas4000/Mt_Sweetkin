using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Managers;
using static Trainworks.Constants.VanillaRelicPoolIDs;

namespace sweetkin.Relic
{
    class Relic_SilverPlater
    {
        public static string ID = "Relic_SilverPlater";

        public static void Make_relic_silver()
        {
            var relic = new CollectableRelicDataBuilder
            {
                CollectableRelicID = "Relic_SilverPlater",
                Name = "Silver Plate",
                NameKey = "Relic_I",
                Description = "Apply Buffet 2 to morsels",
                DescriptionKey = "Power_RI",
                RelicLoreTooltipKeys = new List<string> { "Lore_RI" },
                IconPath = "sweet/Relic/SilverPlate.png",
                RelicPoolIDs = new List<string> { MegaRelicPool },
                ClanID = Clan.ID,
                IsBossGivenRelic = false,
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                         RelicEffectClassName = "RelicEffectAddStatusEffectOnSpawn",
                         ParamStatusEffects = new StatusEffectStackData[] 
                         { 
                             new StatusEffectStackData 
                             { 
                                statusId = "eatmany", 
                                count = 2 
                             } 
                         },
                         ParamSourceTeam = Team.Type.Monsters,
                         ParamBool = false,
                         ParamTargetMode = TargetMode.Room,
                         ParamCardType = CardType.Monster,
                         ParamCharacterSubtype = "SubtypesData_Snack",
                    }
                },
                Rarity = CollectableRarity.Common
            }.BuildAndRegister();
        }
    }
}
