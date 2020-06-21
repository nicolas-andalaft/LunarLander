using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public enum Scenes
    {
        MainMenu = 0, TestLevel,
    }

    public static void GoToScene(Scenes scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public static void GoToNextScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        int sceneIndex = (int)Enum.Parse(typeof(Scenes), currentSceneName);
        Array scenesArray = Enum.GetValues(typeof(Scenes));

        sceneIndex++;
        string nextScene = 
            sceneIndex < scenesArray.Length ? 
                ((Scenes)sceneIndex).ToString() : 
                Scenes.MainMenu.ToString();

        SceneManager.LoadScene(nextScene);
    }

    public static void ReloadScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
