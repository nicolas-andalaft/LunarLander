using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuViewController : ViewController<MainMenuView>
{
    private ViewControllerFactory _factory;

    public MainMenuViewController(MainMenuView view, ViewControllerFactory factory) : base(view) 
    {
        _factory = factory;
    }

    public void Setup()
    {
        View.Setup(Application.productName);
        View.AddButton(PlayGame, "Jogar");
        View.AddButton(ShowSettingsMenu, "Configurações");
    }

    private void PlayGame()
    {
        GameSceneManager.GoToNextScene();
    }

    private void ShowSettingsMenu()
    {
        var viewController = _factory.CreateSettingsMenuViewController();
        viewController.Setup(() => viewController.Dismiss());

        viewController.View.transform.SetParent(View.transform, false);
    }
}
