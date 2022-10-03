using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPBController : MonoBehaviour
{
    [SerializeField] private Color mainColor = Color.black;
    [SerializeField][Range(0, 1)] private float metallic = 0.0f;

    private Renderer _renderer;
    private MaterialPropertyBlock _materialPropertyBlock = null;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _materialPropertyBlock = new MaterialPropertyBlock();
    }

    void Update()
    {
        _materialPropertyBlock.SetColor("_Color", mainColor);
        _materialPropertyBlock.SetFloat("_Metallic", metallic);
        _renderer.SetPropertyBlock(_materialPropertyBlock);
    }
}
