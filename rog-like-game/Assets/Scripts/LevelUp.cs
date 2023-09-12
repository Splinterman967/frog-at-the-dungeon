using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
   
    [SerializeField] GameObject samurai_sword;
    [SerializeField] GameObject aura_shield;
    [SerializeField] GameObject wand;

    public bool is_first_augment = true;
   // public bool is_first_samurai = false;
    //public bool is_first_shield = false;
    //public bool is_first_electro = false;

    public void samuraiSword()
    {
        samurai_sword.SetActive(true);
        sword.sword_damage += 10;
        sword.sword_speed -= 50;

        closePanel();

    }

    public void auroShield()
    {
        aura_shield.SetActive(true);
        shield.shield_damage += 5;
        closePanel();
    }

    public void electroBall()
    {
        wand.SetActive(true);
        projectile.electroball_damage += 10f;

     
        projectile.electroball_frequency -= 0.1f;

        if (projectile.electroball_frequency <= 0.3f)
                    projectile.electroball_frequency = 0.3f;
        
      
            closePanel();
    }

    public void giantHeart()
    {
        playerAttrabiutes.player_hp += 20;
        playerAttrabiutes.HealthRegen += 5;
        HealthBar.canBolum += 20;
        closePanel();
    }

    public void longSword()
    {
        playerAttrabiutes.damage_scale += 0.5f;
        closePanel();
    }

    public void speedUp()
    {
        playerAttrabiutes.player_movespeed += 1f;
        closePanel();
    }

    void closePanel()
    {
      
        Time.timeScale = 1f;
        AudioManager.Instance.PlaySFX("selectAugment");
        gameObject.SetActive(false);
    }

}

