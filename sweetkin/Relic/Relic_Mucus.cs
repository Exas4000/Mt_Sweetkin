using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Managers;
using static Trainworks.Constants.VanillaRelicPoolIDs;


namespace sweetkin.Relic
{
    class Relic_Mucus
    {
        public static string ID = "Relic_SW_Mucus";

        public static void Make_relic_Mucus()
        {
            var relic = new CollectableRelicDataBuilder
            {
                CollectableRelicID = "Relic_SW_Mucus",
                Name = "Preserved Mucus",
                NameKey = "Relic_VI",
                Description = "Eaten triggers an additionnal time",
                DescriptionKey = "Power_RVI",
                RelicLoreTooltipKeys = new List<string> { "Lore_RVI" },
                IconPath = "sweet/Relic/Jam.png",
                RelicPoolIDs = new List<string> { MegaRelicPool },
                ClanID = Clan.ID,
                IsBossGivenRelic = false,
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                         relicEffectClassName = "RelicEffectModifyTriggerCount",
                         ParamSourceTeam = Team.Type.Monsters,
                         ParamBool = false,
                         ParamInt = 1,
                         ParamTrigger = CharacterTriggerData.Trigger.OnEaten,
                         ParamTargetMode = TargetMode.FrontInRoom,
                         ParamCardType = CardType.Monster,
                         

                    },
                    
                },
                Rarity = CollectableRarity.Uncommon
            }.BuildAndRegister();
        }
    }
}
