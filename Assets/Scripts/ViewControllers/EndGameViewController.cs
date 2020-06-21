public class EndGameViewController : ViewController<EndGameView>
{
    public EndGameViewController(EndGameView view) : base(view)
    {
    }

    public void Setup(string title)
    {
        View.Setup(title);
        View.AddButton(RestartLevel, "Refazer Fase");
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
