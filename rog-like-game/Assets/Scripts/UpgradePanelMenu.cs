using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanelMenu : MonoBehaviour
{
    [SerializeField] GameObject panel;
    PauseManager pauseManager;

    private void Awake()
    {
        pauseManager = GetComponent<PauseManager>();
    }

    public void openPanel()
    {
    pauseManager.PauseGame();
    panel.SetActive(true); 
    }

    public void ClosePanel()
    {
    pauseManager.UnPauseGame();
    panel.SetActive(false);
    }
}
