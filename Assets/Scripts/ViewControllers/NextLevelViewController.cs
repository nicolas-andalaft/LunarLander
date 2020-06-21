public class NextLevelViewController : ViewController<NextLevelView>
{
    public NextLevelViewController(NextLevelView view) : base(view) { }

    public void Setup(string title)
    {
        View.Setup(title);
        View.AddButton(RestartLevel, "Refazer Fase");
        View.AddButton(GoToMainMenu, "Menu");
        View.AddButton(GoToNextLevel, "Proxima Fase");
    }

    public void RestartLevel()
    {
        GameSceneManager.ReloadScene();
    }

    public void GoToMainMenu()
    {
        GameSceneManager.GoToScene(GameSceneManager.Scenes.MainMenu);
    }

    public void GoToNextLevel()
    {
        GameSceneManager.GoToNextScene();
    }
}
