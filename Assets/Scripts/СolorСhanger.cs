using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class СolorСhanger : AnimationSetting
{
    [SerializeField] private Color _color;       

    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.material.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }   
}
