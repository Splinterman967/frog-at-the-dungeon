using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FpsScale : MonoBehaviour
{
    public float refreshRate = 1.0f; // Ortalama hesaplanacak saniye say�s�
    private float timer = 0.0f;
    private int frameCount = 0;
    private float totalFrameTime = 0.0f;
    [SerializeField] Text m_Text;

    void Start()
    {
        //m_Text = GetComponent<Text>();
    }

    void Update()
    {
        frameCount++;
        totalFrameTime += Time.unscaledDeltaTime;
        timer += Time.unscaledDeltaTime;

        if (timer >= refreshRate)
        {
            float averageFrameTime = totalFrameTime / frameCount;
            float averageFPS = 1.0f / averageFrameTime;

            //m_Text.text = "FPS (Last " + refreshRate + "second): " + Mathf.Round(averageFPS);
            m_Text.text = "FPS : " + Mathf.Round(averageFPS);

            // S�f�rla
            frameCount = 0;
            totalFrameTime = 0.0f;
            timer = 0.0f;
        }
    }
}
