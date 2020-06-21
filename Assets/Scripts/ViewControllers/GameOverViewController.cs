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
        GameSceneManager.ReloadScene();
    }

    public void GoToMainMenu()
    {
        GameSceneManager.GoToScene(GameSceneManager.Scenes.MainMenu);
    }
}
