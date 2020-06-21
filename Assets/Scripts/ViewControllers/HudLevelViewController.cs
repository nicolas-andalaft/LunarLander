using UnityEngine;

public class HudLevelViewController : ViewController<HudLevelView>
{
    private ViewControllerFactory _factory;

    public HudLevelViewController(HudLevelView view, ViewControllerFactory factory) : base(view)
    {
        _factory = factory;
    }

    public void Setup()
    {
        View.AddButton(ShowGameOver, "Test GameOver");
        View.AddButton(ShowNextLevelMenu, "Test NextLevel");
    }

    private void ShowGameOver()
    {
        var viewController = _factory.CreateGameOverViewController();
        viewController.Setup("Game Over");
        viewController.View.transform.SetParent(View.transform, false);
    }
    
    private void ShowNextLevelMenu()
    {
        Debug.Log("Next Level");
    }
}
