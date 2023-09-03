using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{

    public static float shield_damage=20;
    private float damage;
    private void Update()
    {
        updateDamage();
    }
    void updateDamage()
    {
        damage = shield_damage * playerAttrabiutes.damage_scale;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().enemy_hp -= damage;
        }
    }
}
