using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerAttrabiutes : MonoBehaviour
{
    public static float player_movespeed=4f;
    public static float player_damage=10f;
    public static float player_hp = 100f;
    public static float damage_scale=1f;
    private float damage = 10f;
    public static float HealthRegen;
    void Update()
    {                 
        isPlayerDead();
        updateDamage();
        if (player_hp < 4)
        {
               AudioManager.Instance.PlaySFX("death");
        }           
        if (player_hp >= HealthBar.canBolum)
        {
            player_hp = HealthBar.canBolum;
        }
    }
    private void FixedUpdate()
    {
        destroyPlayer();
    }
    public static bool  isPlayerDead()
    {
        if (player_hp <= 0)
        {                 
            return true;         
        }                                     
        return false;
    }
    void updateDamage()
    {
        damage = player_damage * damage_scale;
    }
    void destroyPlayer()
    {
        if (isPlayerDead())
        {                              
            Destroy(gameObject);            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
           collision.gameObject.GetComponent<enemy>().enemy_hp -= damage;
        }
    }     
} 
