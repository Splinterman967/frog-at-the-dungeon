using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings_GraphicSettings : MonoBehaviour
{
    public Text qualityLevelText; // UI metni

    private void Start()
    {
        // Baþlangýçta kaydedilen kalite seviyesini yükle
        string savedQualityLevel = PlayerPrefs.GetString("QualityLevel", "medium"); // Varsayýlan olarak "medium" kullanýlacak
        SetQualityLevel(savedQualityLevel);
    }

    public void SetQualityLow()
    {
        SetQualityLevel("low");
    }

    public void SetQualityMedium()
    {
        SetQualityLevel("medium");
    }

    public void SetQualityHigh()
    {
        SetQualityLevel("high");
    }

    private void SetQualityLevel(string level)
    {
        switch (level)
        {
            case "low":
                QualitySettings.SetQualityLevel(1);
                PlayerPrefs.SetString("QualityLevel", "low");
                break;
            case "medium":
                QualitySettings.SetQualityLevel(3);
                PlayerPrefs.SetString("QualityLevel", "medium");
                break;
            case "high":
                QualitySettings.SetQualityLevel(6);
                PlayerPrefs.SetString("QualityLevel", "high");
                break;
        }

        PlayerPrefs.Save();
        UpdateQualityLevelText(level);
    }

    private void UpdateQualityLevelText(string qualityLevel)
    {
        if (qualityLevelText != null)
        {
            qualityLevelText.text = "Quality Level: " + qualityLevel;
        }
    }
}
