using System;
using UnityEngine;

public class SettingsMenuView : View
{
    [SerializeField] private ButtonView _backButtonView = null;

    public void Setup(Action backAction, string labelText)
    {
        _backButtonView.Setup(backAction, labelText);
    }
}
