using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    [SerializeField] private Sprite Sandýk_kapalý;
    [SerializeField] private Sprite Sandýk_Acýk;
    public static float sandik_puani = 0;
    bool isChestAvaliable = false;
    scor scor;
    // Update is called once per frame
    void  Update()
    {

        Debug.Log("sandýk puaný : " + +sandik_puani);

        //eðer score umuzu 1000 olursa haritanýn ortasýnda chest belirecek
        if (sandik_puani >= 1000)
        {
            isChestAvaliable = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sandýk_Acýk;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("player") && isChestAvaliable)
        {         
            sandik_puani = 0;
            isChestAvaliable = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sandýk_kapalý;
        }
    
    }
}


