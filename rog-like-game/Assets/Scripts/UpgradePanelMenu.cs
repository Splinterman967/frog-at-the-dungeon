using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanelMenu : MonoBehaviour
{
    [SerializeField] GameObject LevelUpPanel;
    [SerializeField] Transform[] augment_positions;
    [SerializeField] GameObject[] Augments;
    PauseManager pauseManager;
    private void Start()
    {
        pauseManager = GetComponent<PauseManager>();
    }

    public void openPanel()
    {
       pauseManager.PauseGame();
       LevelUpPanel.SetActive(true);      
        idenitfyAugments();
    }
    public void ClosePanel()
    {
    pauseManager.UnPauseGame();
    LevelUpPanel.SetActive(false);
    }
    void idenitfyAugments()
    {
        int a0 = Random.Range(0, Augments.Length);
        int a1 = Random.Range(0, Augments.Length);
        int a2 = Random.Range(0, Augments.Length);
        GameObject augment0 = Instantiate(Augments[a0], augment_positions[0]);     
        GameObject augment1 = Instantiate(Augments[a1], augment_positions[1]);
        GameObject augment2 = Instantiate(Augments[a2], augment_positions[2]);
    }
}
