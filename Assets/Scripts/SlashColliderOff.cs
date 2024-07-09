using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashColliderOff : MonoBehaviour
{
    float currentTime = 0;
    float lifeTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > lifeTime)
        {
            currentTime = 0;
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<Base>().Damaged(10);
        }
    }
}
