﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeaZone : MonoBehaviour
{
    public Text scorePlayerText;
    public Text scoreEnemyText;

    int scorePlayerQuantity;
    int scoreEnemyQuantity;

    SCENECHANGER1 sceneChanger;
    public AudioSource deadAudio;

    private void Awake()
    {
        sceneChanger = FindObjectOfType<SCENECHANGER1>();
    }

    private void OnTriggerEnter(Collider ball)
    {
        if(gameObject.CompareTag("Izquierdo"))
        {
            scoreEnemyQuantity++; // suma 1
            //deadAudio.Play();
            UpdateScoreLabel(scoreEnemyText, scoreEnemyQuantity);
        }
        else if (gameObject.CompareTag("Derecho"))
        {
            scorePlayerQuantity++;
            //deadAudio.Play();
            UpdateScoreLabel(scorePlayerText, scorePlayerQuantity);
        }
        ball.GetComponent<BowlBehaviour>().gameStarted = false;
        CheckScore();
    }

    void CheckScore()
    {
        if (scorePlayerQuantity >= 3)
        {
            sceneChanger.ChangeSceneTo("SceneWin");
        }
        else if (scoreEnemyQuantity >= 3)
        {
            sceneChanger.ChangeSceneTo("SceneLose");
        }
    }

    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }
}
