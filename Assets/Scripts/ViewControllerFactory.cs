using UnityEngine;

public class ViewControllerFactory : MonoBehaviour
{
    [SerializeField] private SceneWireframe _wireframe;

    [Header("Prefabs")]

    [SerializeField] private MainMenuView _mainMenuViewPrefab;
    [SerializeField] private SettingsMenuView _settingsMenuViewPrefab;
    [SerializeField] private HudLevelView _hudLevelViewPrefab;
    [SerializeField] private GameOverView _gameOverViewPrefab;
    [SerializeField] private NextLevelView _nextLevelViewPrefab;
    [SerializeField] private EndGameView _endGameViewPrefab;

    [HideInInspector]
    public enum Prefabs
    {
        MainMenuView, SettingsMenuView, HudLevelView, GameOverView
    }

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

    public NextLevelViewController CreateNextLevelViewController()
    {
        var nextLevelView = Instantiate(_nextLevelViewPrefab);
        return new NextLevelViewController(nextLevelView);
    }
    
    public EndGameViewController CreateEndGameViewController()
    {
        var endGameView = Instantiate(_endGameViewPrefab);
        return new EndGameViewController(endGameView);
    }

}
