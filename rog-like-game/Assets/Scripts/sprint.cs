using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprint : MonoBehaviour
{
    private bool isBoosted = false;
    private void Update()
    {
        Debug.Log(gameObject.GetComponent<enemy>().enemy_movespeed);
        if (!isBoosted)
        {
            StartCoroutine(BoostSpeed());
        }
    }

    IEnumerator BoostSpeed()
    {
        isBoosted = true;


       

    gameObject.GetComponent<enemy>().enemy_movespeed = 15;
    //2 saniye boyunca bekler
    yield return new WaitForSeconds(1f);

    // H�z� orijinaline d�nd�r�r
    gameObject.GetComponent<enemy>().enemy_movespeed = 3;
    // 5 saniye cooldown s�resi ekler
    yield return new WaitForSeconds(5f);

    isBoosted = false;
    }
}
