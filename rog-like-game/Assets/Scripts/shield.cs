using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shield : MonoBehaviour
{ 
    [SerializeField] damagePopUp dmg_popUp;

    public static float shield_damage=5;
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

            dmg_popUp.damage_popUp(damage, collision);
            AudioManager.Instance.PlaySFX("ShieldDamage");


        }
    }

  

}
