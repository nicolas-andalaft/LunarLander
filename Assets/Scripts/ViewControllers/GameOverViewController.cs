using UnityEngine.SceneManagement;

public class GameOverViewController : ViewController<GameOverView>
{
    public GameOverViewController(GameOverView view) : base(view)
    {
    }

    public void Setup(string title)
    {
        View.Setup(title);
        View.AddButton(RestartLevel, "Recomeçar");
        View.AddButton(GoToMainMenu, "Menu");
    }

    public void RestartLevel()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    public void GoToMainMenu()
    {
        string mainMenuScene = ((Enums.Scenes) 0).ToString();
        SceneManager.LoadScene(mainMenuScene);
    }
}
