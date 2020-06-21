using System;
using UnityEngine;

public class View : MonoBehaviour
{
    public Action OnDestroyCallBack { get; set; }

    private void OnDestroy()
    {
        OnDestroyCallBack?.Invoke();        
    }
}
