public class LevelInitializer
{
    private SceneWireframe _wireframe;
    private ViewControllerFactory _factory;

    public LevelInitializer(SceneWireframe wireframe, ViewControllerFactory factory)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Init()
    {
        var viewController = _factory.CreateHudLevelViewController();
        viewController.Setup();

        _wireframe.PresentViewController(viewController);
    }
}
