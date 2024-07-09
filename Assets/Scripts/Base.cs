using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public int hp = 10;
    public int score = 1;
    public GameObject destroyEffect;
    GameObject dieEffect;
    public GameObject hitEffect;
    GameObject hitEffectIns;
    ParticleSystem onEffect;

    bool wallDestroy = false;

    private void Start()
    {
        hitEffectIns = Instantiate(hitEffect);
        onEffect = hitEffectIns.GetComponent<ParticleSystem>();
    }

    public void Damaged(int damage)
    {
        hp -= damage;

        hitEffectIns.transform.position = transform.position;

        onEffect.Play();

        if(hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(hitEffectIns);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            wallDestroy = true;

            Destroy(other.gameObject);
        }
        else if(other.CompareTag("Wall"))
        {
            wallDestroy = true;

            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if(wallDestroy == false)
        {
            dieEffect = Instantiate(destroyEffect);

            dieEffect.transform.position = transform.position;

            Destroy(dieEffect, 1f);

            Score.instance.ScoreNum = score;
        }
    }
}
