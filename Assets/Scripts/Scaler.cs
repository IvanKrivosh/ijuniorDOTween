using DG.Tweening;
using UnityEngine;

public class Scaler : AnimationSetting
{
    [SerializeField] private Vector3 _scale;

    private void Start()
    {
        transform.DOScale(_scale, _duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
}
