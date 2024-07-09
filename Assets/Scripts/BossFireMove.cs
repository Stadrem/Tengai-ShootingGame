using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BossFireMove : MonoBehaviour
{
    GameObject player;
    Vector3 dir;

    bool wallDestroy = false;

    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        dir = player.transform.position;

        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {

        if(player != null)
        {
            transform.position += dir * speed * Time.deltaTime;
        }
        else
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
