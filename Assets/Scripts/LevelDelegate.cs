using System.Collections;
using UnityEngine;

public class LevelDelegate : MonoBehaviour
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
        new LevelInitializer(_wireframe, _factory).Init();
    }
}
