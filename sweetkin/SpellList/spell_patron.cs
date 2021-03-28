using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class spell_patron
    {
        public static void BuildpatronSpell()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_patron",
                Name = "Begrudging Patron",
                Description = " Apply [effect0.status0.power] Sap",
                NameKey = "Card_XIII",
                OverrideDescriptionKey = "Spell_XIII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XIII" },
                Cost = 2,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_XIII.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {                  
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectAddStatusEffect",
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters | Team.Type.Heroes,

                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Sap,
                                count =3
                            }
                        }
                    }
                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateName = "CardTraitExhaustState"
                    }
                }

            }.BuildAndRegister();
        }
    }
}
