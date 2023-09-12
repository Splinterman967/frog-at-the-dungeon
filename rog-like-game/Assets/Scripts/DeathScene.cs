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
        HealthBar.currentHp = 100; 
    }
}
