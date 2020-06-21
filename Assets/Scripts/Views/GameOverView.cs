using System;
using UnityEngine;
using UnityEngine.UI;

public class GameOverView : View
{
    [Header("Title")]
    [SerializeField] private Text _titleText;

    [Header("Buttons")]
    [SerializeField] private Transform _buttonHolder;
    [SerializeField] private ButtonView _buttonViewPrefab;

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
