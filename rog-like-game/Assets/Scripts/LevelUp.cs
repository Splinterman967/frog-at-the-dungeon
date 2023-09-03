using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
   
    [SerializeField] GameObject samurai_sword;
    [SerializeField] GameObject aura_shield;
    [SerializeField] GameObject wand;

    public bool is_first_augment = true;
    public bool is_first_samurai = false;
    public bool is_first_shield = false;
    public bool is_first_electro = false;

    public void samuraiSword()
    {
        samurai_sword.SetActive(true);
        sword.sword_damage += 10;
        sword.sword_speed -= 10;
        closePanel();

    }

    public void auroShield()
    {
        aura_shield.SetActive(true);
        shield.shield_damage += 10;
        closePanel();
    }

    public void electroBall()
    {
        wand.SetActive(true);
        projectile.electroball_damage += 15f;
        projectile.electroball_frequency -= 0.3f;
        closePanel();
    }

    public void giantHeart()
    {
        playerAttrabiutes.player_hp += 10;
        closePanel();
    }

    public void longSword()
    {
        playerAttrabiutes.damage_scale += 0.1f;
        closePanel();
    }

    public void boostUp()
    {
        playerAttrabiutes.player_movespeed += 0.2f;
        closePanel();
    }

    void closePanel()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

}

