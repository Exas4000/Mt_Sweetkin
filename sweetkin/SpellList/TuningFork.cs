using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class TuningFork
    {
        public static void BuildSpell_tuning()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_TuningFork",
                Name = "Tuning Fork",
                Description = "Deal [effect0.power] damage",
                NameKey = "Card_XVI",
                OverrideDescriptionKey = "Spell_XVI",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XVI" },
                Cost = 0,
                Rarity = CollectableRarity.Rare,
                TargetsRoom = true,
                Targetless = true,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_XVI.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {


                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectDamage",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                        ParamInt = 0
                    }
                    
                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateType = VanillaCardTraitTypes.CardTraitStrongerMagicPower,
                        ParamInt = 5

                    }
                }

            }.BuildAndRegister();
        }
    }
}
