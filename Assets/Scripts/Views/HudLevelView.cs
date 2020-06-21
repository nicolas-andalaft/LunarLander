using System;
using UnityEngine;

public class HudLevelView : View
{
    [Header("Buttons")]
    [SerializeField] private Transform _buttonHolder;
    [SerializeField] private ButtonView _buttonViewPrefab;

    public void Setup()
    {
        
    }

    public void AddButton(Action buttonCallback, string labelText)
    {
        var buttonView = Instantiate(_buttonViewPrefab, _buttonHolder);
        buttonView.Setup(buttonCallback, labelText);
    }
}
