using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;

namespace sweetkin.SpellList
{
    class Portal_Master
    {
        public static void BuildSpell_Portal()
        {
            new CardDataBuilder
            {
                CardID = "Sweetkin_Card_Portal",
                Name = "Portal Master",
                Description = "Send a unit to the bottom floor",
                NameKey = "Card_II",
                OverrideDescriptionKey = "Spell_II",
                CardLoreTooltipKeys = new List<string> { "Lore_Card_II" },
                Cost = 1,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = false,
                ClanID = Clan.ID,
                AssetPath = "sweet/Card Assets/card_II.png", // change later
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {

                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectBump,
                        ParamInt = -5,
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Heroes | Team.Type.Monsters,

                    }
                }

            }.BuildAndRegister();
        }
    }
}
