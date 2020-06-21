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
        string firstLevel = ((Enums.Scenes) 1).ToString();
        SceneManager.LoadScene(firstLevel);
    }

    private void ShowSettingsMenu()
    {
        var viewController = _factory.CreateSettingsMenuViewController();
        viewController.Setup(() => viewController.Dismiss());

        viewController.View.transform.SetParent(View.transform, false);
    }
}
