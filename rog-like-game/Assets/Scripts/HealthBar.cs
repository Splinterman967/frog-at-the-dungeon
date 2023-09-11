using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using UnityEngine;
using UnityEngine.UI;
    
public class HealthBar : MonoBehaviour
{
    public static float currentHp=100f, canBolum;
    float animasyonYavasligi=50f;
    private float canOlcek;

    void Start()
    {
       
        canBolum = currentHp;        
    }

    // Update is called once per frame
    void Update()
    {

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



}
