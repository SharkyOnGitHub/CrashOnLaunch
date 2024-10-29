using System;
using UnityEngine;

namespace CrashOnLaunch
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class CrashMod : MonoBehaviour
    {
        void Start()
        {
            
            throw new Exception("Crashing client..");
        }
    }
}
