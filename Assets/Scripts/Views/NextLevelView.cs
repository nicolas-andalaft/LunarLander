using System;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelView : View
{
    [Header("Title")]
    [SerializeField] private Text _titleText = null;

    [Header("Buttons")]
    [SerializeField] private Transform _buttonHolder = null;
    [SerializeField] private ButtonView _buttonViewPrefab = null;

    public void Setup(string title)
    {
        _titleText.text = title;
    }

    public void AddButton(Action buttonCallback, string labelText)
    {
        var buttonView = Instantiate(_buttonViewPrefab, _buttonHolder);
        buttonView.Setup(buttonCallback, labelText);
    }
}
