using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Managers;
using static Trainworks.Constants.VanillaRelicPoolIDs;
using Trainworks.Constants;

namespace sweetkin.Relic
{
    class Relic_Pamphlet
    {
        public static string ID = "Relic_pamphlet";

        public static void Make_relic_pamphlet()
        {
            var relic = new CollectableRelicDataBuilder
            {
                CollectableRelicID = "Relic_pamphlet",
                Name = "Mysterious Pamphlet",
                NameKey = "Relic_II",
                Description = "Reduce the cost of rerolls by 100%",
                DescriptionKey = "Power_RII",
                RelicLoreTooltipKeys = new List<string> { "Lore_RII" },
                IconPath = "sweet/Relic/pamphlet.png",
                RelicPoolIDs = new List<string> { MegaRelicPool },
                ClanID = Clan.ID,
                IsBossGivenRelic = false,
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                         RelicEffectClassName = "RelicEffectModifyMerchantRerollCosts",
                         ParamFloat = -1, // set to free (does not affect covenant cost increase)
                         ParamSourceTeam = Team.Type.Monsters,   
                         ParamBool = false,
                         ParamTargetMode = TargetMode.FrontInRoom,                         
                         ParamCharacterSubtype = "",
                    }
                },
                Rarity = CollectableRarity.Common
            }.BuildAndRegister();
        }
    }
}
