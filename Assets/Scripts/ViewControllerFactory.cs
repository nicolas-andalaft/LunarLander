using UnityEngine;

public class ViewControllerFactory : MonoBehaviour
{
    [SerializeField] private SceneWireframe _wireframe;

    [Header("Prefabs")]

    [SerializeField] private MainMenuView _mainMenuViewPrefab;

    public MainMenuViewController CreateMainMenuViewController()
    {
        var mainMenuView = Instantiate(_mainMenuViewPrefab);
        return new MainMenuViewController(mainMenuView);
    }
}
