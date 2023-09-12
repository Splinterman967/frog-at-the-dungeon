using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprint : MonoBehaviour
{
    private bool isBoosted = false;

    void Update()
    {
        StartCoroutine(BoostSpeed());
        Debug.Log(gameObject.GetComponent<enemy>().enemy_movespeed);

    }

    IEnumerator BoostSpeed()
    {
        isBoosted = true;

        gameObject.GetComponent<enemy>().enemy_movespeed = 10;
        // 2 saniye boyunca bekler
        yield return new WaitForSeconds(0.2f);

        // Hýzý orijinaline döndürür
        gameObject.GetComponent<enemy>().enemy_movespeed = 3;

        // 5 saniye cooldown süresi ekler
        yield return new WaitForSeconds(5f);

        isBoosted = false;
    }
}
