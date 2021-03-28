using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Dove
    {
        public static void BuildSpell_Dove()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Dove",
                Name = "Dove-livery",                
                Description = "Draw 1 card",
                NameKey = "Card_I",
                OverrideDescriptionKey = "Spell_I",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_I" },
                Cost = 1,
                Rarity = CollectableRarity.Starter,
                TargetsRoom = true,
                Targetless = true,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_I.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {

                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectDraw,
                        ParamInt = 1,
                        TargetMode = TargetMode.Room
                        

                    }
                }

            }.BuildAndRegister();
        }
    }
}
