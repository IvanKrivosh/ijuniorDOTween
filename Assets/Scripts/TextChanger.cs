using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private TextSetting _stringToChange;
    [SerializeField] private TextSetting _stringToAdd;
    [SerializeField] private TextSetting _stringToEnumeration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_stringToChange.Text, _stringToChange.Duration).SetEase(Ease.Linear));
        sequence.Append(_text.DOText(_stringToAdd.Text, _stringToAdd.Duration).SetRelative().SetEase(Ease.Linear));
        sequence.Append(_text.DOText(_stringToEnumeration.Text, _stringToEnumeration.Duration, true, ScrambleMode.All).SetEase(Ease.Linear));        
    }
}

[Serializable]
public class TextSetting
{
    [SerializeField] private string _text;
    [SerializeField] private float _duration;

    public string Text => _text;
    public float Duration => _duration;
}