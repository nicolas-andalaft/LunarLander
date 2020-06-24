using UnityEngine;

public class HudLevelViewController : ViewController<HudLevelView>
{
    private ViewControllerFactory _factory;
    GameState gameState;

    public HudLevelViewController(HudLevelView view, ViewControllerFactory factory) : base(view)
    {
        _factory = factory;
    }

    public void Setup()
    {
        //View.AddButton(ShowGameOver, "Test GameOver");
        //View.AddButton(ShowNextLevelMenu, "Test NextLevel");
        //View.AddButton(ShowEndGame, "Test EndGame");
        gameState = Object.FindObjectOfType<GameState>();
        gameState.Setup(ShowGameOver, ShowNextLevelMenu, ShowEndGame);
    }

    private void ShowGameOver()
    {
        var viewController = _factory.CreateGameOverViewController();
        viewController.Setup("Game Over");
        viewController.View.transform.SetParent(View.transform, false);
    }

    private void ShowNextLevelMenu()
    {
        var viewController = _factory.CreateNextLevelViewController();
        viewController.Setup("Fase Concluida");
        viewController.View.transform.SetParent(View.transform, false);
    }

    public void ShowEndGame()
    {
        var viewController = _factory.CreateEndGameViewController();
        viewController.Setup("Fim de Jogo");

        viewController.View.transform.SetParent(View.transform, false);
    }
}
