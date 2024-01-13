using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class СolorСhanger : MonoBehaviour
{

    [SerializeField] private Color _color;
    [SerializeField] private float _duration;    

    private MeshRenderer _meshRenderer;

    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.material.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }   
}
