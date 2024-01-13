using DG.Tweening;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform[] _checkPoints;
    [SerializeField] private float _duration;

    void Start()
    {        
        transform.DOPath(_checkPoints.Select(checkPoint => checkPoint.transform.position).ToArray(), _duration)
            .SetLoops(-1)
            .SetEase(Ease.Linear);
    }    
}
