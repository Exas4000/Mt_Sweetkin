using HarmonyLib;
using I2.Loc;
using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Managers;

namespace sweetkin
{
    class localization
    {



        [HarmonyPatch(typeof(LocalizationManager), "UpdateSources")]
        class RegisterLocalizationStrings
        {
        //    // The path passed here is relative to BepInEx/plugins/
            static void Postfix()
            {
                CustomLocalizationManager.ImportCSV("Sweet_local.csv");
            }
        }
    }
}
