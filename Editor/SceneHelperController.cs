using UnityEditor;
using UnityEngine;
using Loc = PixelWizards.PhysicalMaterialManager.SceneHelperLoc;                                 // string localization table

namespace PixelWizards.PhysicalMaterialManager
{

    public static class SceneHelperController
    {
        public static bool initialized = false;

        public static void Init()
        {
            if (initialized)
                return;

            
            initialized = true;
        }
        
    }
}