using UnityEngine;

public class ViewControllerFactory : MonoBehaviour
{
    [SerializeField] private SceneWireframe _wireframe;

    [Header("Prefabs")]

    [SerializeField] private MainMenuView _mainMenuViewPrefab;
    [SerializeField] private SettingsMenuView _settingsMenuViewPrefab;
    [SerializeField] private HudLevelView _hudLevelViewPrefab;
    [SerializeField] private GameOverView _gameOverViewPrefab;

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

    public HudLevelViewController CreateHudLevelViewController()
    {
        var hudLevelView = Instantiate(_hudLevelViewPrefab);
        return new HudLevelViewController(hudLevelView, this);
    }

    public GameOverViewController CreateGameOverViewController()
    {
        var gameOverView = Instantiate(_gameOverViewPrefab);
        return new GameOverViewController(gameOverView);
    }
}
