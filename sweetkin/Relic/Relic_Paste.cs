using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Managers;
using static Trainworks.Constants.VanillaRelicPoolIDs;

namespace sweetkin.Relic
{
    class Relic_Paste
    {
        public static string ID = "Relic_SW_Paste";

        public static void Make_relic_Paste()
        {
            var relic = new CollectableRelicDataBuilder
            {
                CollectableRelicID = "Relic_SW_Paste",
                Name = "Master's Paste",
                NameKey = "Relic_V",
                Description = "Apply 10 hp to morsels",
                DescriptionKey = "Power_RV",
                RelicLoreTooltipKeys = new List<string> { "Lore_RV" },
                IconPath = "sweet/Relic/Frosting.png",
                RelicPoolIDs = new List<string> { MegaRelicPool },
                ClanID = Clan.ID,
                IsBossGivenRelic = false,
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                         relicEffectClassName = "RelicEffectModifyCardHealth",
                         ParamSourceTeam = Team.Type.Monsters,
                         ParamBool = false,
                         ParamInt = 25,
                         ParamTrigger = CharacterTriggerData.Trigger.OnSpawn,
                         ParamTargetMode = TargetMode.FrontInRoom,
                         ParamCardType = CardType.Monster,
                         ParamCharacterSubtype = "SubtypesData_Snack",

                    },
                    new RelicEffectDataBuilder
                    {
                         relicEffectClassName = "RelicEffectModifyCharacterMaxHealth",
                         ParamSourceTeam = Team.Type.Monsters,
                         ParamBool = false,
                         ParamInt = 25,
                         ParamTrigger = CharacterTriggerData.Trigger.OnSpawnNotFromCard,                        
                         ParamTargetMode = TargetMode.FrontInRoom,
                         ParamCardType = CardType.Monster,
                         ParamCharacterSubtype = "SubtypesData_Snack",

                    },
                },
                Rarity = CollectableRarity.Common
            }.BuildAndRegister();
        }

    }
}
