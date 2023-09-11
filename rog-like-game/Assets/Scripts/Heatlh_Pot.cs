using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Heatlh_Pot : MonoBehaviour
{


    void Update()
    {
       if (transform.position.y <= 1)
       {
            transform.Translate(0f, 0.02f, 0f);
       }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
         playerAttrabiutes.player_hp += 10f;

         
         Destroy(gameObject);

        }
    }
}
