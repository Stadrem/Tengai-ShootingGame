using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFire : MonoBehaviour
{
    public GameObject bullet;
    GameObject bulletFire;

    float currentTime = 0;
    public float fireTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > fireTime)
        {
            bulletFire = Instantiate(bullet);

            bulletFire.transform.position = transform.position;

            currentTime = 0;
        }
    }
}
