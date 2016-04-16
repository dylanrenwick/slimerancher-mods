using SR_PluginLoader;
using System.Collections.Generic;
using UnityEngine;

namespace ExtendedVacpac
{

    // Please note that this project references assemblies located in the SlimeRancher game folder, specifically the default location for the steam version on windows.
    // If you are getting missing assembly reference errors then you need to correct the locations for those files.
    public static class SR_Plugin
    {
        public static Plugin_Data PLUGIN_INFO = new Plugin_Data()
        {
            NAME = "Extended Vacpac",
            AUTHOR = "GunnerWolf",
            DESCRIPTION = @"",
            VERSION = new Plugin_Version(0, 1),
            UPDATE_METHOD = new Update_Method("", UPDATER_TYPE.NONE),
            DEPENDENCIES = new List<Plugin_Dependency>() { },
        };

        public static void Load(GameObject go)
        {
            go.AddComponent<ExtendedVacpac>();
        }

        public static void Unload(GameObject go)
        {
        }
    }
}
