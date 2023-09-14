using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outerSpace : MonoBehaviour
{
    private void Update()
    {
       // Info();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().enemy_hp -= 1000;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            playerAttrabiutes.player_hp -= 1000;
        }
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);           
    }

    //void Info()
    //{
    //Debug.Log(" Sword dmg :  "+ + sword.sword_damage + "  Sword speed  " + sword.sword_speed + "  Shield dmg :  " +
    //shield.shield_damage + "   electro dmg :  " + projectile.electroball_damage + "  electro frequency  " + projectile.electroball_frequency+
    //" \n player speed: " + playerAttrabiutes.player_movespeed+"  player dmg scale: "
    //+playerAttrabiutes.damage_scale+"  player max health: " + playerAttrabiutes.player_hp  );
    //}
}
