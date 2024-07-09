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
        // Score.instance 초기화
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
            Debug.LogError("Text 컴포넌트를 찾을 수 없습니다. scoreText를 할당하세요.");
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
