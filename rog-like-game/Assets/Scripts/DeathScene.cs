using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour
{
   
    [SerializeField] GameObject player;
    [SerializeField] GameObject deathPanel;
    [SerializeField] GameObject Restartbutton;


    void Update()
    {
        playerDeath();
    }

    void playerDeath()
    {

        if (player.IsDestroyed())
        {
            deathPanel.SetActive(true);

          
        }
       
       // Debug.Log(Time.timeScale + "   " + playerAttrabiutes.player_hp+ "  "+  player.IsDestroyed());


    }
    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        deathPanel.SetActive(false);

        playerAttrabiutes.player_hp = 100;
        playerAttrabiutes.damage_scale = 1f;
        playerAttrabiutes.player_movespeed = 4f;
        HealthBar.canBolum = 100;
        HealthBar.currentHp = 100;
        ExpBar.Exp = 0;
        ExpBar.maxExp = 100;
        TreasureChest.sandik_puani = 0;
        sword.sword_damage = 20;
        sword.sword_speed = -100;
        shield.shield_damage = 5;
        projectile.electroball_damage = 20;
        projectile.electroball_frequency = 1f;
    }
}
