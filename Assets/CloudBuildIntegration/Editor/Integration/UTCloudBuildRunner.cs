namespace AncientLightStudios.UTomate.CloudBuild
{
    using System;
    using System.Collections;
    using UnityEngine;
 
    public class UTCloudBuildRunner
    {
        public static void OnPreExport()
        {
            Debug.LogWarning("Testing 1234");
        }

        public static void OnPostExport(string currentlyIgnored)
        {
            Debug.LogWarning("No plan for post-export. Skipping.");
        }
    }
}
