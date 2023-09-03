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

        if (playerAttrabiutes.isPlayerDead())
        {
            
            deathPanel.SetActive(true);
            player.SetActive(false);
            Time.timeScale = 0;
        }
    }
    public void RestartButton()
    {
        Time.timeScale = 1f;
        deathPanel.SetActive(false);
        player.SetActive(true);
        print("olduk");
        //Scene scene;
        //scene = SceneManager.GetActiveScene();
        //SceneManager.LoadScene(scene.name);
        SceneManager.LoadScene("SampleScene");
       

    }
}
