using System;
using UnityEngine;

public class SettingsMenuViewController : ViewController<SettingsMenuView>
{
    public SettingsMenuViewController(SettingsMenuView view) : base(view) { }

    public void Setup(Action backAction)
    {
        View.Setup(backAction, "Voltar");
    }
}
