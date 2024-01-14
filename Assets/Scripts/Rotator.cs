using DG.Tweening;
using UnityEngine;

public class Rotator : AnimationSetting
{
    [SerializeField] private Vector3 _rotate;    

    private void Start()
    {
        transform.DORotate(_rotate, _duration, RotateMode.WorldAxisAdd)
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }
}
