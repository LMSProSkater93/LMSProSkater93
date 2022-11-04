using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "WaterCollision")
        {
            HealthManagerScript.Health--;
            if (HealthManagerScript.Health <= 0)
            {
                
            }
        }
    }
}
