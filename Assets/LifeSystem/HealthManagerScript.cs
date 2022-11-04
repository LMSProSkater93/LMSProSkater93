using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManagerScript : MonoBehaviour
{
    public static int Health = 3;

    //create an array of img
    public Image[] life;
    //empty life

    //full life
    public Sprite FullLife;
    public Sprite EmptyLife;

    // Update is called once per frame
    void Update()
    {
        foreach (Image img in life)
        {
            img.sprite = EmptyLife;
        }
        for (int i = 0; i < Health; i++)
        {
            life[i].sprite = FullLife;
        }
    }

    private void OnTriggerEnter2D(Collider2D collisionItem)
    {
        if (collisionItem.tag == "Fire" || collisionItem.tag == "MagicEss")
        {

            Health--;
            //Destroy(collisionWater.gameObject);
            //MyScoreText.text = "Score " + scoreNum;
        }
    }


}
