using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseFEffect : MonoBehaviour
{
    [SerializeField] fEffect flash_effect;

    private void Start()
    {
        flash_effect = GetComponent<fEffect>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        flash_effect.flash_effect();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        flash_effect.flash_effect();
    }
}
