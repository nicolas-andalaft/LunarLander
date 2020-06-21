public class GameInitializer
{
    private SceneWireframe _wireframe;
    private ViewControllerFactory _factory;

    public GameInitializer(SceneWireframe wireframe, ViewControllerFactory factory)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Init()
    {
        var viewController = _factory.CreateMainMenuViewController();
        viewController.Setup();

        _wireframe.PresentViewController(viewController);
    }
}
