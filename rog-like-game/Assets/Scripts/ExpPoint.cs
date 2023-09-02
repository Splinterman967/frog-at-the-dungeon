using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPoint : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            ExpBar.Exp += 10;
            //exp point yok olacak ve experience hanemize 10 puan eklencek
            
        }
    }
}
