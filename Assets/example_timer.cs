using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class example_timer : MonoBehaviour
{
    float countdown = 1;
    public TMP_Text tex;

    private void Update()
    {
        if(countdown > 0)
        {
            countdown+=Time.deltaTime;
        }
        double b = System.Math.Round(countdown, 2);
        tex.text = b.ToString();
    }
}
