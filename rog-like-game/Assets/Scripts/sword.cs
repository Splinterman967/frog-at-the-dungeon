using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using BarthaSzabolcs.Tutorial_SpriteFlash;

public class sword : MonoBehaviour
{
    [SerializeField] damagePopUp dmg_popUp;
    public static float sword_damage= 20;
    public static float sword_speed=-100;
    private float damage;
    public static bool SwordThrowBack = false;
    float origSpeed;
    void Update()
    {
        updateDamage();
        spinSword();
    }
    void spinSword()
    {
        transform.Rotate(0, 0, sword_speed * Time.deltaTime, Space.Self);            
        transform.localPosition = new Vector3(0, 0, 0);
    }
    void updateDamage()
    {
        damage = sword_damage * playerAttrabiutes.damage_scale;        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().enemy_hp -= damage;
            AudioManager.Instance.PlaySFX("Sword");
            //SimpleFlash.Flash();
            dmg_popUp.damage_popUp(damage, collision);
            SwordThrowBack = true;
            StartCoroutine(ThrowBack());
        }
        IEnumerator ThrowBack()
        {            
            if (SwordThrowBack == true && collision.gameObject.GetComponent<enemy>().enemy_orig_hp <= 500)
            {
                origSpeed = collision.gameObject.GetComponent<enemy>().enemy_movespeed;
                collision.gameObject.GetComponent<enemy>().enemy_movespeed = -15;
                yield return new WaitForSeconds(0.3f);
                collision.gameObject.GetComponent<enemy>().enemy_movespeed = origSpeed;
                SwordThrowBack = false;
            }
        }
    }
}
