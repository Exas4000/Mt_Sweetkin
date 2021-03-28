using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Spell_DineAndDash
    {
        public static void BuildSpell_DineDash()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_DineDash",
                Name = "Dine And Dash",
                Description = "Deal [effect0.power] damage",
                NameKey = "Card_IX",
                OverrideDescriptionKey = "Spell_IX",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_IX" },
                Cost = 2,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = true,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_IX.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {


                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectDamage",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,
                        ParamInt = 30
                    }

                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateType = VanillaCardTraitTypes.CardTraitMagneticState //maybe holdhover
                    }
                }

            }.BuildAndRegister();
        }
    }
}
