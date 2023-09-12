using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodThrower : MonoBehaviour
{
    [SerializeField] GameObject wood;

    void Start()
    {
        StartCoroutine(Fire());
    }

    IEnumerator Fire()
    {

        while (true)
        {

            yield return new WaitForSeconds(10f);
            Instantiate(wood, transform.position, transform.rotation);

        }

    }
}
