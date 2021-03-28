using System;
using System.Collections.Generic;
using System.Text;
using Trainworks;
using Trainworks.Builders;
using Trainworks.Managers;
using UnityEngine;
using Malee;
using HarmonyLib;
using Trainworks.Constants;
using static sweetkin.Unit_Butler;
using static sweetkin.Unit_FastFood;


namespace sweetkin
{
    class Clan
    {
        public static readonly string ID = "Sweetkin_Clan";

        

        public static void Buildclan()
        {
            new ClassDataBuilder
            {
                ClassID = ID,
                DraftIconPath = "sweet/Clan Assets/Icon_CardBack_Sweetkin.png",
                Name = "Sweet Kin",
                Description = "A hospitable force from another world, unknowingly taking part in something greater than they should be. The Sweet kin are often more than what people can chew.",
                DescriptionLoc = "Clan_desc",
                SubclassDescription = "Ally yourself with the outerwordly and enticingly sugary SweetKin",
                SubclassDescriptionLoc = "Clan_subdesc",
                //CardStyle = ClassCardStyle.Stygian, //modify later for own
                IconAssetPaths = new List<string>
                {
                "sweet/Clan Assets/ClanLogo_32.png",
                "sweet/Clan Assets/ClanLogo_92_Stroke1.png",
                "sweet/Clan Assets/ClanLogo_92_Stroke1.png",
                "sweet/Clan Assets/ClanLogo_Silhouette.png"
                },

                CardFrameUnitPath = "sweet/Clan Assets/unit-cardframe-Sweetkin.png",
                CardFrameSpellPath = "sweet/Clan Assets/spell-cardframe-Sweetkin.png",
                

                UiColor = new Color(0.9f, 0.18f, 0.81f, 0.5f),
                UiColorDark = new Color(0.48f, 0.03f, 0.42f, 0.26f),

            }.BuildAndRegister();
        }

        


        ///make banner custom clan
        
        public static void buildbanner()
        {

            //previous code
            //CardPool cardPool = UnityEngine.ScriptableObject.CreateInstance<CardPool>();
            //var cardDataList = (Malee.ReorderableArray<CardData>)AccessTools.Field(typeof(CardPool), "cardDataList").GetValue(cardPool);
            //cardDataList.Add(CustomCardManager.GetCardDataByID("Sweetkin_Card_FastFood"));
            //cardDataList.Add(CustomCardManager.GetCardDataByID("Sweetkin_Card_Butler"));
            CardPool cardpool = new CardPoolBuilder
            {
                CardPoolID = "Sweekin_BannerPool",
                CardIDs = new List<string>
                {
                    "Sweetkin_Card_FastFood",
                    "Sweetkin_Card_Butler",
                    "Sweetkin_Card_Maid",                    
                    "Sweetkin_Card_Mint",
                    "Sweetkin_Card_Cayenne",
                    "Sweetkin_Card_SourGuard",
                    "Sweetkin_Card_Lime",
                    "Sweetkin_Card_Viimp",
                    "Sweetkin_Card_Sherbetrus",
                    "Sweetkin_Card_Hot",
                }               
            }.BuildAndRegister();
                      

            new RewardNodeDataBuilder()
            {
                RewardNodeID = "Sweet_Banner",
                MapNodePoolIDs = new List<string>
                {
                    VanillaMapNodePoolIDs.RandomChosenMainClassUnit,
                    VanillaMapNodePoolIDs.RandomChosenSubClassUnit
                },
                //Name = "Sweetkin Banner",
                //Description = "Offers assitants from the Sweetkin",
                TooltipTitleKey = "name_sweet_banner",
                TooltipBodyKey = "desc_sweet_banner",
                RequiredClass = CustomClassManager.GetClassDataByID(Clan.ID),
                FrozenSpritePath = "sweet/Clan Assets/Sweetkin_Frozen.png",
                EnabledSpritePath = "sweet/Clan Assets/Sweetkin_Enabled.png",
                DisabledSpritePath = "sweet/Clan Assets/Sweetkin_Disabled.png",
                DisabledVisitedSpritePath = "sweet/Clan Assets/Sweetkin_Visited_Disabled.png",
                GlowSpritePath = "sweet/Clan Assets/MSK_Map_Clan_CSweetkin_01.png",
                MapIconPath = "sweet/Clan Assets/Sweetkin_Enabled.png",
                MinimapIconPath = "sweet/Clan Assets/ClanLogo_Silhouette.png",
                ControllerSelectedOutline = "sweet/Clan Assets/selection_outlines.png", // might be needed to fix everything
                SkipCheckInBattleMode = true,
                OverrideTooltipTitleBody = false,
                NodeSelectedSfxCue = "Node_Banner",
                RewardBuilders = new List<IRewardDataBuilder>
                {
                    new DraftRewardDataBuilder()
                    {
                        DraftRewardID = "Sweetkin_reward",
                        _RewardSpritePath = "sweet/Clan Assets/Icon_CardBack_Sweetkin.png",
                        _RewardTitleKey = "Sweet_Banner",
                        _RewardDescriptionKey = "Choose a card!",
                        Costs = new int[] { 100 },
                        _IsServiceMerchantReward = false,
                        DraftPool =  cardpool,
                        ClassType = (RunState.ClassType)7,
                        DraftOptionsCount = 2,
                        RarityFloorOverride = CollectableRarity.Uncommon
                    }
                }


            }.BuildAndRegister();
        }
    }
}
