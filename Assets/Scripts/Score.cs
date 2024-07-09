using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    public int scoreNum = 0;

    TMP_Text scoreText;

    void Awake()
    {
        // Score.instance �ʱ�ȭ
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public int ScoreNum
    {
        get
        {
            return scoreNum;
        }
        set
        {
            ScoreAdd(value);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();

        if (scoreText == null)
        {
            Debug.LogError("Text ������Ʈ�� ã�� �� �����ϴ�. scoreText�� �Ҵ��ϼ���.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ScoreAdd(int num)
    {
        scoreNum += num;

        scoreText.text = Convert.ToString(scoreNum);

        Debug.Log(scoreNum);

        //scoreText.text += num;
    }
}
