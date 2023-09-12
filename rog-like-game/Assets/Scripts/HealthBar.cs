using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using UnityEngine;
using UnityEngine.UI;
    
public class HealthBar : MonoBehaviour
{
    public static float currentHp=100, canBolum;
    float animasyonYavasligi=20;
    private float canOlcek;
    public static bool Regen = true;

    void Start()
    {
        playerAttrabiutes.HealthRegen = 5;
        canBolum = currentHp; 
        StartCoroutine(HPRegen());

    }

    // Update is called once per frame
    void Update()
    {
        //Aðýr yara denemesi için yazýldý
        //if ( Regen )
        //{
        //    StartCoroutine(HPRegen());
        //}
        UpdateHP();


       // gameObject.GetComponentInParent<RectTransform>().position = new Vector3(-10, 19, 0);

    }


    void UpdateHP()
    {
        currentHp = playerAttrabiutes.player_hp;

        canOlcek = currentHp / canBolum; 

        //can olcegýný azalt
        if (transform.localScale.x > canOlcek)
        {
            transform.localScale = new Vector3(transform.localScale.x - (transform.localScale.x - canOlcek) / animasyonYavasligi, transform.localScale.y, transform.localScale.z);
        }

        
        //can olcegýný arttýr
        if (transform.localScale.x < canOlcek)
        {
            transform.localScale = new Vector3(transform.localScale.x + (canOlcek - transform.localScale.x) / animasyonYavasligi, transform.localScale.y, transform.localScale.z);
        }
        if (currentHp > canBolum)
        {
            currentHp = canBolum;
        }


    }

    IEnumerator HPRegen()
    {
        while (Regen == true)
        {
         yield return new WaitForSeconds(2);
         playerAttrabiutes.player_hp += playerAttrabiutes.HealthRegen;
        }
    }





}
