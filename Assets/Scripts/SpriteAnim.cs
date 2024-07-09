using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnim : MonoBehaviour
{
    public float scrollSpeed = 0.5f;

    Material mat;

    private Renderer rend;
    private Vector2 savedOffset;

    void Start()
    {
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();

        mat = mr.material;
    }

    void Update()
    {
        mat.mainTextureOffset += Vector2.right * scrollSpeed * Time.deltaTime;
    }
}
