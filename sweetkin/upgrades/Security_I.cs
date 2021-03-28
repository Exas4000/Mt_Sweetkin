using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.upgrades
{
    class Security_I
    {
        public static CardUpgradeDataBuilder Builder()
        {
            CardUpgradeDataBuilder upgrade = new CardUpgradeDataBuilder
            {
                UpgradeTitleKey = "Security_I",
                UpgradeDescriptionKey = "1g",
                UseUpgradeHighlightTextTags = true,
                BonusHP = 0,
                BonusDamage = 20,


                TriggerUpgradeBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnEaten,
                        DescriptionKey = "1g",
                        HideTriggerTooltip = false,
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                                TargetMode = TargetMode.Room,
                                TargetTeamType = Team.Type.Heroes,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.Sap,
                                        count = 2
                                    },
                                }

                            },
                        }
                    }
                }
            };
            return upgrade;
        }
        public static CardUpgradeData Make() { return Builder().Build(); }
    }
}
