using BepInEx;
using HarmonyLib;
using Trainworks.Managers;
using System;

namespace sweetkin.harmony
{
    class LiLyPatch
    {
        //AccessUnitSynthesisMapping by lileypad13
        public static void FindUnitSynthesisMappingInstanceToStub()
        {
            // Possibly gets a reference to AllGameData
            AllGameData testData = ProviderManager.SaveManager.GetAllGameData();
            sweet_A.Log("Got reference to AllGameData: " + testData.name);

            // Use AllGameData to get access to BalanceData
            BalanceData balanceData = testData.GetBalanceData();
            sweet_A.Log("Got reference to BalanceData: " + balanceData.name);

            // Use BalanceData to get access to the current instance of the UnitSynthesisMapping
            UnitSynthesisMapping mappingInstance = balanceData.SynthesisMapping;
            if (mappingInstance == null)
            {
                sweet_A.Log("Failed to create a mapping instance.");
            }
            else
            {
                sweet_A.Log("Able to find mapping instance: " + mappingInstance.GetID()); // Test to see if this is a different instance
            }
            

            // Find a way to set the allGameData property of a created UnitSynthesisMapping instance
            RecallingCollectMappingData.MyTest(mappingInstance);
            sweet_A.Log("Ran through full test of mapping synths.");
        }
    }

    [HarmonyPatch(typeof(UnitSynthesisMapping), "CollectMappingData", new Type[] { })]
    public class RecallingCollectMappingData
    {
        [HarmonyReversePatch]
        public static void MyTest(object instance)
        {
            // It's a stub so it has no initial content
        }
    }
}
