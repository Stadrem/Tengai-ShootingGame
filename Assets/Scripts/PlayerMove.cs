using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    float h;
    float v;

    Vector3 dir;

    Rigidbody rb;
    float speed = 10.0f;

    public GameObject uiCanvas;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        dir = new Vector3(h, v, 0);
        //dir.Normalize();

        if (h != 0 || v != 0)
        {
            rb.velocity = dir * speed;
        }
    }

    void OnDestroy()
    {
        if (uiCanvas != null)
        {
            uiCanvas.gameObject.SetActive(true);
        }
    }
}
