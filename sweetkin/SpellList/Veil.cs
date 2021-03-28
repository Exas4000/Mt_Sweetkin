using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Veil
    {
        public static void BuildSpell_Veil()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Veil",
                Name = "Veil of Reality",
                Description = "Discard 2 cards, then draw 2",
                NameKey = "Card_XVII",
                OverrideDescriptionKey = "Spell_XVII",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_XVII" },
                Cost = 2,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = true,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_XVII.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
               
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectRandomDiscard,
                        ParamInt = 2,
                        TargetMode = TargetMode.Room

                    },
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectDraw,
                        ParamInt = 2,
                        TargetMode = TargetMode.Room


                    }
                }

            }.BuildAndRegister();
        }
    }
}
