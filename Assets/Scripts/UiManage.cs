using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManage : MonoBehaviour
{
    public Text pointsPlayerText, pointsEnemyText;
    int pointsPlayer = 0, pointsEnemy = 0;

    private void Start()
    {
        pointsPlayerText.text = pointsPlayer.ToString();
        pointsEnemyText.text = pointsEnemy.ToString();

    }

    public void AddPoints(Text campText, int campPlayers)
    {

    }

}
