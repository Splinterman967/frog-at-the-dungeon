using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    [SerializeField] private Sprite Sandýk_kapalý;
    [SerializeField] private Sprite Sandýk_Acýk;
    [SerializeField] private GameObject Health_Pot;
    public static float sandik_puani = 0;
    bool isChestAvaliable = false;
    static bool hasInstantiatedHealthPot = false;
    scor scor;
    void  Update()
    {
        //eðer score umuzu 1000 olursa haritanýn ortasýnda chest belirecek
        if (sandik_puani >= 1000 && !hasInstantiatedHealthPot)
        {
            isChestAvaliable = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sandýk_Acýk;
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
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sandýk_kapalý;
            hasInstantiatedHealthPot = false;
        }    
    }
}


