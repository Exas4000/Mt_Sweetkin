using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Managers;
using static Trainworks.Constants.VanillaRelicPoolIDs;
using Trainworks.Constants;

namespace sweetkin.Relic
{
    class Relic_Golden_kernel
    {
        public static string ID = "Relic_Gold_Kernels";

        public static void Make_relic_gold()
        {
            var relic = new CollectableRelicDataBuilder
            {
                CollectableRelicID = "Relic_Gold_Kernels",
                Name = "Golden Kernels",
                NameKey = "Relic_IV",
                Description = "5 gold per eaten",
                DescriptionKey = "Power_RIV",
                RelicLoreTooltipKeys = new List<string> { "Lore_RIV" },
                RelicActivatedKey = "Relic_Trigger_RIV",
                IconPath = "sweet/Relic/kernel.png",
                RelicPoolIDs = new List<string> { MegaRelicPool },
                ClanID = Clan.ID,
                IsBossGivenRelic = false,
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                         RelicEffectClassName = "RelicEffectGoldOnTrigger",                        
                         ParamFloat = 0,
                         ParamInt = 5,
                         ParamSourceTeam = Team.Type.Monsters, //compared to targetteam type, you say WHO is affected by the effect
                         ParamBool = false,
                         ParamTargetMode = TargetMode.FrontInRoom,
                         ParamCharacterSubtype = "SubtypesData_None",
                         ParamTrigger = CharacterTriggerData.Trigger.OnEaten, //should give 2 gold every eaten trigger
                    }
                    
                },
                Rarity = CollectableRarity.Uncommon
            }.BuildAndRegister();
        }
    }
}
