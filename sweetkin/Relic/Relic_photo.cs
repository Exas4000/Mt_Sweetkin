using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Managers;
using static Trainworks.Constants.VanillaRelicPoolIDs;
using Trainworks.Constants;

namespace sweetkin.Relic
{
    class Relic_photo
    {
        public static string ID = "Relic_photo";

        public static void Make_relic_photo()
        {
            var relic = new CollectableRelicDataBuilder
            {
                CollectableRelicID = "Relic_photo",
                Name = "Old Drawing",
                NameKey = "Relic_III",
                Description = "sap +1 de reduc",
                DescriptionKey = "Power_RIII",
                RelicLoreTooltipKeys = new List<string> { "Lore_RIII" },
                IconPath = "sweet/Relic/SilverPlate.png",
                RelicPoolIDs = new List<string> { MegaRelicPool },
                ClanID = Clan.ID,
                IsBossGivenRelic = false,
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                         RelicEffectClassName = "RelicEffectModifyStatusMagnitude",
                         ParamFloat = 0, 
                         ParamInt = 1,
                         ParamSourceTeam = Team.Type.Monsters & Team.Type.Heroes, //compared to targetteam type, you say WHO is affected by the effect
                         ParamBool = false,
                         ParamTargetMode = TargetMode.FrontInRoom,
                         ParamCharacterSubtype = "SubtypesData_None",
                         ParamStatusEffects = new StatusEffectStackData[]
                         {
                             new StatusEffectStackData
                             {
                                statusId = "debuff",
                                count = 0
                             }
                         },
                    },
                    //new RelicEffectDataBuilder
                    //{
                    //     RelicEffectClassName = "RelicEffectModifyStatusMagnitude",
                    //     ParamFloat = 0,
                    //     ParamInt = 1,
                    //     ParamSourceTeam = Team.Type.Heroes,
                    //     ParamBool = false,
                    //     ParamTargetMode = TargetMode.FrontInRoom,
                    //     ParamCharacterSubtype = "SubtypesData_None",
                    //     ParamStatusEffects = new StatusEffectStackData[]
                    //     {
                    //         new StatusEffectStackData
                     //        {
                    //            statusId = "debuff",
                    //            count = 0
                     //        }
                     //    },
                    //}
                },
                Rarity = CollectableRarity.Common
            }.BuildAndRegister();
        }
    }
}
