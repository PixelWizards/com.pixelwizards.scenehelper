using UnityEditor;
using UnityEngine;
using Control = PixelWizards.PhysicalMaterialManager.SceneHelperController;
using Loc = PixelWizards.PhysicalMaterialManager.SceneHelperLoc;                                 // string localization table

namespace PixelWizards.PhysicalMaterialManager
{
    public static class SceneHelperLoc
    {
        public const string MENUITEMPATH = "Window/General/Scene Group Helper";
        public const string WINDOWTITLE = "Scene Group Editor";
        
        public const string WINDOW_HEADER = "Manage Scene Groups";
        public const string HELP_HEADER = "Create and manage scene object groups and control their activation.";
        
    }

    public class SceneHelperEditor : EditorWindow
    {
        public static Vector2 curWindowSize = Vector2.zero;
        public static Vector2 minWindowSize = new Vector2(500, 50);
        public static Vector2 scrollPosition = Vector2.zero;

        [MenuItem(Loc.MENUITEMPATH)]
        public static void ShowWindow()
        {
            var thisWindow = GetWindow<SceneHelperEditor>(false, Loc.WINDOWTITLE, true);
            thisWindow.minSize = minWindowSize;
            thisWindow.Reset();
        }

        public void OnEnable()
        {
            Reset();
        }

        public void Reset()
        {
            Control.Init();
        }
        
        
        private void OnGUI()
        {
            GUILayout.Space(10f);
            GUILayout.BeginVertical();
            {
                GUILayout.Space(10f);

                GUILayout.Label(Loc.WINDOW_HEADER, EditorStyles.boldLabel);
                GUILayout.Label(Loc.HELP_HEADER, EditorStyles.helpBox);

                GUILayout.Space(10f);

                
            }
            GUILayout.EndVertical();
            GUILayout.Space(10f);
        }
    }
}