using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpRadius : MonoBehaviour
{
    //Radiusa dokundugunda playera dogru ýlerleyecek

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ExpPoint"))
        {
            collision.gameObject.GetComponent<ExpPoint>().player_transform =  GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}
