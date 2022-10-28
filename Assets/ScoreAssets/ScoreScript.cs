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
    //coliision on pizza
    private void OnTriggerEnter2D(Collider2D collisionOnItems)
    {
        if (collisionOnItems.tag == "MyPizza" || collisionOnItems.tag == "MyDia"
            || collisionOnItems.tag == "MyEgg" || collisionOnItems.tag == "Aubergine"
            || collisionOnItems.tag == "Coin" || collisionOnItems.tag == "Meat")
        {
            scoreNum++;
            Destroy(collisionOnItems.gameObject);
            MyScoreText.text = "Score " + scoreNum;
        }
        //if (collisionOnItems.tag == "MyDia")
        //{
        //    scoreNum++;
        //    Destroy(collisionOnItems.gameObject);
        //    MyScoreText.text = "Score " + scoreNum;
        //}
    }
}
