using UnityEngine;

public class ViewControllerFactory : MonoBehaviour
{
    [SerializeField] private SceneWireframe _wireframe;

    [Header("Prefabs")]

    [SerializeField] private MainMenuView _mainMenuViewPrefab;
    [SerializeField] private SettingsMenuView _settingsMenuViewPrefab;

    public MainMenuViewController CreateMainMenuViewController()
    {
        var mainMenuView = Instantiate(_mainMenuViewPrefab);
        return new MainMenuViewController(mainMenuView, this);
    }

    public SettingsMenuViewController CreateSettingsMenuViewController()
    {
        var settingsMenuView = Instantiate(_settingsMenuViewPrefab);
        return new SettingsMenuViewController(settingsMenuView);
    }
}
