using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour
{
   
    [SerializeField] GameObject player;
    [SerializeField] GameObject deathPanel;

    void Update()
    {
        playerDeath();
    }

    void playerDeath()
    {

        if (playerAttrabiutes.isPlayerDead())
        {
            
            deathPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void RestartButton()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("olduk");
       // deathPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
