using UnityEditor;
using UnityEditor.SceneManagement;

public static class EditorSceneSwticher
{
    [MenuItem("SceneSwitcher/0_Initialization")]
    static void LoadInit()
    {
        LoadSceneByName("Assets/Scenes/0_Initialization.unity");
    }
    
    [MenuItem("SceneSwitcher/1_MainMenu")]
    static void LoadMainMenu()
    {
        LoadSceneByName("Assets/Scenes/1_MainMenu.unity");
    }
    
    [MenuItem("SceneSwitcher/2_Battle")]
    static void LoadBattle()
    {
        LoadSceneByName("Assets/Scenes/2_Battle.unity");
    }
    
    static void LoadSceneByName(string scenePath)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene(scenePath);   
        }
    }
}
