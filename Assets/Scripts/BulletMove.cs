using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    float bulletMoveSpeed = 25.0f;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * bulletMoveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy") || other.CompareTag("Wall"))
        {
            if (other.CompareTag("Enemy"))
            {
                other.GetComponent<Base>().Damaged(1);
            }
            gameObject.SetActive(false);
        }
    }
}
