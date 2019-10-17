using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace TemperatureFix
{
    [HarmonyPatch(typeof(Substance), "SpawnResource")]
    internal class SpawnResource_TempFix
    {
        private static void Postfix(ref GameObject __result)
        {
            PrimaryElement primeElement = __result.GetComponent<PrimaryElement>();
            primeElement.SetMassTemperature(primeElement.Mass, primeElement.InternalTemperature);
        }
    }
}
