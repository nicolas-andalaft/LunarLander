using System.Collections;
using UnityEngine;

public class AppDelegate : MonoBehaviour
{
    [SerializeField] private SceneWireframe _wireframe;
    [SerializeField] private ViewControllerFactory _factory;

    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        Init();
    }

    private void Init()
    {
        new GameInitializer(_wireframe, _factory).Init();
    }
}
