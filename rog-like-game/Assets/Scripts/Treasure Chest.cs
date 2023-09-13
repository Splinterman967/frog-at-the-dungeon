using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    [SerializeField] private Sprite Sand�k_kapal�;
    [SerializeField] private Sprite Sand�k_Ac�k;
    [SerializeField] private GameObject Health_Pot;
    public static float sandik_puani = 0;
    bool isChestAvaliable = false;
    static bool hasInstantiatedHealthPot = false;
    scor scor;
    void  Update()
    {
        //e�er score umuzu 1000 olursa haritan�n ortas�nda chest belirecek
        if (sandik_puani >= 1000 && !hasInstantiatedHealthPot)
        {
            isChestAvaliable = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sand�k_Ac�k;
            Instantiate(Health_Pot);
            hasInstantiatedHealthPot = true;
        }         
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("Player") && isChestAvaliable)
        {                                  
            sandik_puani = 0;
            isChestAvaliable = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sand�k_kapal�;
            hasInstantiatedHealthPot = false;
        }    
    }
}


