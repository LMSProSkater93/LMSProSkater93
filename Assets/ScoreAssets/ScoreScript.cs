using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text MyScoreText;
    private int scoreNum;
    // Start is called before the first frame update
    //game start
    void Start()
    {
        scoreNum = 0;
        MyScoreText.text = "Score: " + scoreNum;
    }
    //coliision coin
    private void OnTriggerEnter2D(Collider2D pizzaCollision)
    {
        if (pizzaCollision.tag == "MyPizza")
        {
            scoreNum++;
            Destroy(pizzaCollision.gameObject);
            MyScoreText.text = "Score " + scoreNum;
        }
    }


}
