using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    int num = 10;

    public GameObject bullet;

    public GameObject firePosition;

    public GameObject slashCollision;

    public Image readyUI;

    List<GameObject> magazine = new List<GameObject>();

    Animator anim;


    float currentTime = 0.0f;
    float fireTime = 0.1f;

    float readyTime = 0;
    float slashTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        for(int i = 0; i < num; i++)
        {
            magazine.Add(Instantiate(bullet));

            magazine[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (Input.GetButton("Fire1") && !Input.GetButton("Fire2"))
        {
            //anim.SetTrigger("Attack");

            if(currentTime > fireTime)
            {
                for (int i = 0; i < num; i++)
                {
                    if (magazine[i].activeSelf == false)
                    {
                        magazine[i].SetActive(true);

                        magazine[i].transform.position = firePosition.transform.position;

                        currentTime = 0;

                        break;
                    }
                }
            }
        }

        if (Input.GetButton("Fire2") && !Input.GetButton("Fire1"))
        {
            readyTime += Time.deltaTime;

            readyUI.fillAmount += 2 * Time.deltaTime;

            anim.SetTrigger("Ready");
        }
        if (Input.GetButtonUp("Fire2") && readyTime > slashTime)
        {

            slashCollision.SetActive(true);

            anim.SetTrigger("Slash");

            anim.ResetTrigger("Ready");

            readyTime = 0;
            readyUI.fillAmount = 0;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            anim.SetTrigger("Cancle");

            anim.ResetTrigger("Ready");

            readyTime = 0;
            readyUI.fillAmount = 0;
        }
    }
}
