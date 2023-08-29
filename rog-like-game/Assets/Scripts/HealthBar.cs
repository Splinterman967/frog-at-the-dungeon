using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public static float  can, animasyonYavasligi;
    private float maxCan, GercekScale;

    void Start()
    {
        maxCan = can;        
    }

    // Update is called once per frame
    void Update()
    {
        GercekScale = can / maxCan;

        if (transform.localScale.x > GercekScale)
        {
            transform.localScale = new Vector3(transform.localScale.x - (transform.localScale.x - GercekScale) / animasyonYavasligi, transform.localScale.y, transform.localScale.z);
        }

        if (transform.localScale.x < GercekScale)
        {
            transform.localScale = new Vector3(transform.localScale.x + (GercekScale - transform.localScale.x) / animasyonYavasligi, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown("z") && can>0)
        {
            can -= 10;
        }

        if (Input.GetKeyDown("x") && can < maxCan)
        {
            can += 10;
        }

        if (can > maxCan)
        {
            can = maxCan;
        }

        
    }
}
