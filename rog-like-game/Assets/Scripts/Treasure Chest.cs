using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    [SerializeField] private Sprite Sand�k_kapal�;
    [SerializeField] private Sprite Sand�k_Ac�k;
    public static float sandik_puani = 0;
    bool isChestAvaliable = false;
    scor scor;
    // Update is called once per frame
    void  Update()
    {

        Debug.Log("sand�k puan� : " + +sandik_puani);

        //e�er score umuzu 1000 olursa haritan�n ortas�nda chest belirecek
        if (sandik_puani >= 1000)
        {
            isChestAvaliable = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sand�k_Ac�k;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("player") && isChestAvaliable)
        {         
            sandik_puani = 0;
            isChestAvaliable = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sand�k_kapal�;
        }
    
    }
}


