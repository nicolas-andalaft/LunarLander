using UnityEngine;

public class MainMenuViewController : ViewController<MainMenuView>
{
    public MainMenuViewController(MainMenuView view) : base(view) { }

    public void Setup()
    {
        View.Setup(Application.productName);
    }
}
