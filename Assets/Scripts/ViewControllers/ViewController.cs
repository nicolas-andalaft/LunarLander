using UnityEngine;

public abstract class ViewController<T> where T : View
{
    public T View { get; }

    protected ViewController(T view)
    {
        View = view;
        View.OnDestroyCallBack = Dismiss;
    }

    public virtual void Dismiss()
    {
        GameObject.Destroy(View.gameObject);
    }
}
