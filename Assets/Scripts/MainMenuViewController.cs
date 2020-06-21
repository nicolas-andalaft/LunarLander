using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

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
        Debug.Log("Bora Jogar");
    }

    private void ShowSettingsMenu()
    {
        var viewController = _factory.CreateSettingsMenuViewController();
        viewController.Setup(() => viewController.Dismiss());

        viewController.View.transform.SetParent(View.transform, false);
    }
}
