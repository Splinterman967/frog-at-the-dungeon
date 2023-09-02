using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanelMenu : MonoBehaviour
{
    [SerializeField] GameObject UpgradePanel;
    PauseManager pauseManager;

    private void Awake()
    {
       
    }

    private void Start()
    {
        pauseManager = GetComponent<PauseManager>();
    }

    public void openPanel()
    {
    pauseManager.PauseGame();
    UpgradePanel.SetActive(true); 
    }

    public void ClosePanel()
    {
    pauseManager.UnPauseGame();
    UpgradePanel.SetActive(false);
    }
}
