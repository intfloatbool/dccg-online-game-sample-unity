using UnityEditor;
using UnityEngine;

public static class EditorUtils
{
    [MenuItem("EditorUtils/Clear Player Prefs")]
    static void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}