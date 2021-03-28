using BepInEx;
using HarmonyLib;
using TrainworksModdingTools;
using Trainworks;
using Trainworks.Interfaces;
using Trainworks.Managers;
using Trainworks.Utilities;

using static sweetkin.Unit_FastFood;
using static sweetkin.Spell_sweets;
using static sweetkin.Clan;
using static sweetkin.Rosette;
using static sweetkin.Unit_Butler;
using static sweetkin.unitgen.teamaid;
using static sweetkin.unitgen.Unit_Sweetling;
using static sweetkin.unitgen.Mint;
using static sweetkin.unitgen.Delivery;
using static sweetkin.unitgen.spice_cook;
using static sweetkin.unitgen.Sourling;
using static sweetkin.unitgen.SourGuards;
using static sweetkin.unitgen.CrabCake;
using static sweetkin.unitgen.Viimp;
using static sweetkin.unitgen.Sherbetrus;
using static sweetkin.unitgen.Unit_Hot;
using static sweetkin.HeroSweet;

using static sweetkin.SpellList.Dove;
using static sweetkin.SpellList.spell_expulsion;
using static sweetkin.SpellList.Portal_Master;
using static sweetkin.SpellList.Spell_Care;
using static sweetkin.SpellList.spell_patron;
using static sweetkin.SpellList.Spell_Snakification;
using static sweetkin.SpellList.Spell_Fullcourse;
using static sweetkin.SpellList.Spell_Buffet;
using static sweetkin.SpellList.Relentless;
using static sweetkin.SpellList.TuningFork;
using static sweetkin.SpellList.Veil;
using static sweetkin.SpellList.Renovation;
using static sweetkin.SpellList.WorkShift;
using static sweetkin.SpellList.Spell_AllYouCan;
using static sweetkin.SpellList.Spell_DineAndDash;
using static sweetkin.SpellList.Spell_Leftovers;
using static sweetkin.SpellList.Spell_spectacle;
using static sweetkin.SpellList.Punish;

using static sweetkin.Relic.Relic_SilverPlater;
using static sweetkin.Relic.Relic_Pamphlet;
using static sweetkin.Relic.Relic_photo;
using static sweetkin.Relic.Relic_Golden_kernel;
using System;
using System.Collections.Generic;

namespace sweetkin
{
    [BepInPlugin("Exas4000","Sweetkin","0.1")]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    [BepInDependency("tools.modding.trainworks")]
    
    public class sweet_A : BaseUnityPlugin, IInitializable
    {
        public static ClassData setup; /// maybe able to fix something/// 
        public const string GUID = "com.name.package.generic";

        public void Awake()
        {
            Harmony harmony = new Harmony(GUID);
            harmony.PatchAll();
        }

        public void Initialize()
        {
            

            Buildclan();
            

            //  34/37
            //unit build
            BuildFastFoodCharacter();
            BuildButlerCharacter();
            BuildMaidCharacter();
            BuildSweetlingCharacter();
            BuildMintCharacter();
            BuildDeliveryCharacter();
            BuildCookCharacter(); //cook + Cayenne
            BuildSourlingCharacter();
            BuildSourGuardsCharacter(); //sour guard + lime
            BuildCrabcakeCharacter();
            BuildViimpCharacter();
            BuildSherbetrusCharacter();
            BuildHOTCharacter();

            //spells build           
            BuildSpellHospitality();
            BuildSpell_Dove();
            BuildSpell_Expulsion();
            BuildSpell_Portal();
            BuildCare();
            BuildpatronSpell();
            BuildsnakificationSpell();
            BuildFullcoursenSpell();
            BuildBuffetSpell();
            BuildRelentlessSpell(); //relentless
            BuildSpell_tuning();
            BuildSpell_Veil();
            BuildSpell_Renovation();
            BuildSpell_WorkShift();
            BuildSpell_allyoucan();
            BuildSpell_DineDash();
            BuildSpell_Leftovers();
            BuildSpell_Spectacle();
            BuildSpell_Punish();

            //call the spell power enhancer list fix on individual cards
            fix_magic("Sweetkin_Card_punish");
            fix_magic("Sweetkin_Card_Care");
            fix_magic("Sweetkin_Card_DineDash");
            fix_magic("Sweetkin_Card_Expulsion");
            fix_magic("Sweetkin_Card_TuningFork");
            fix_magic("Sweetkin_Card_WorkShift");

            

            //late build
            BuildHero();//rosette
            BuildHeroV2();//sweet Sally
            buildbanner(); //it needs the cards to be already made

            //Relic build
            Make_relic_silver();
            Make_relic_pamphlet();
            Make_relic_photo();
            Make_relic_gold();
        }

        //code provided by dusk, Enter a cards "Id". They must have "EffectStateName = "CardEffectDamage"," in the CardEffectDataBuilder, same deal for the heal effect
        public void fix_magic(string id)
        {
            // (11593 SpellMagicPowerBigExtraCost -> +20/Consume)
            var enhancerData = ProviderManager.SaveManager.GetAllGameData().FindEnhancerData("07de18ca-a585-4200-b139-63c5d4661140");
            var filter = enhancerData.GetEffects()[0].GetParamCardUpgradeData().GetFilters()[0];
            var list = Traverse.Create(filter).Field("requiredCardEffects").GetValue<List<string>>();
            list.Add(id);

            // (11592 SpellMagicPower -> +10)
            enhancerData = ProviderManager.SaveManager.GetAllGameData().FindEnhancerData("015f4d9d-3a87-4053-8e30-45a80fdf78ee");
            filter = enhancerData.GetEffects()[0].GetParamCardUpgradeData().GetFilters()[0];
            list = Traverse.Create(filter).Field("requiredCardEffects").GetValue<List<string>>();
            list.Add(id);

            // (11791 UpgradeReplicatorSpellAnnhilate -> +20/Purge Event)
            // Nothing special is required here because there are no filters for this enhancer so long as a spell does damage
        }

        

    }
}
