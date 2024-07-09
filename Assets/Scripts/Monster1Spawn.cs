using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1Spawn : MonoBehaviour
{
    public GameObject setEnemy;
    GameObject spawnEnemy;

    float currentTime = 0;
    public float spawnTime = 2.0f;
    float rand = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > spawnTime)
        {
            rand = Random.Range(spawnTime/4, spawnTime);
            spawnEnemy = Instantiate(setEnemy);
            spawnEnemy.transform.position = transform.position;
            currentTime -= rand;
        }
    }
}
