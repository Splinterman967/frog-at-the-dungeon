using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public float Exp, animasyonYavasligi;
    private float maxExp, GercekScale;

    void Start()
    {
        Exp = 1;
        maxExp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        GercekScale = Exp / maxExp;

        if (transform.localScale.x > GercekScale)
        {
            transform.localScale = new Vector3(transform.localScale.x , transform.localScale.y + (GercekScale - transform.localScale.y) / animasyonYavasligi, transform.localScale.z);
        }

        if (Input.GetKeyDown("c"))
        {
            Exp += 10;
        }

        if (Exp >= maxExp)
        {
            Exp = 0;
            maxExp *= 2;
        }
    }
}
