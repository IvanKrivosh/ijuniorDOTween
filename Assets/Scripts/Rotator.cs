using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _duration;

    void Start()
    {
        transform.DORotate(_rotate, _duration, RotateMode.WorldAxisAdd)
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }
}
