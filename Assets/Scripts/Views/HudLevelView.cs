using System;
using UnityEngine;

public class HudLevelView : View
{
    [Header("Buttons")]
    [SerializeField] private Transform _buttonHolder = null;
    [SerializeField] private ButtonView _buttonViewPrefab = null;

    public void Setup()
    {
        
    }

    public void AddButton(Action buttonCallback, string labelText)
    {
        var buttonView = Instantiate(_buttonViewPrefab, _buttonHolder);
        buttonView.Setup(buttonCallback, labelText);
    }
}
