using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Monster1Move : MonoBehaviour
{
    float rand = 0;
    Vector2 dir;
    public float speed = 10;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        rand = Random.Range(-5, 5);

        dir = new Vector2(-10, rand);
        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = dir * speed;
    }
}
