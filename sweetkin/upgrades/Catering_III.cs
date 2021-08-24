using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.upgrades
{
    class Catering_III
    {
        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder upgrade = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = "Catering_III",
                UpgradeDescriptionKey = "3e",
                UseUpgradeHighlightTextTags = true,
                BonusHP = 0,
                BonusDamage = 0,


                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnEaten,
                        DescriptionKey = "3e",
                        HideTriggerTooltip = false,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectAddTempCardUpgradeToUnits,

                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters ,

                                ParamCardUpgradeData = new CardUpgradeDataBuilder
                                {
                                BonusHP = 70,
                                BonusDamage = 30,
                                BonusSize = 2,
                                HideUpgradeIconOnCard = false,
                                }.Build(),
                            }
                        }
                    }
                }
            };
            return upgrade;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
