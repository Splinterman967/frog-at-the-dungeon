using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outerSpace : MonoBehaviour
{
    private void Update()
    {
        Info();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }

    void Info()
    {
        Debug.Log(" Sword Info :" + sword.sword_damage +"  "+ sword.sword_speed + " Shield Info :" +
            shield.shield_damage + " Wand Info :" + projectile.electroball_damage + "  " + projectile.electroball_frequency);
    }
}
