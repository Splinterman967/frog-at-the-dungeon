using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scor : MonoBehaviour
{
    [SerializeField] static TextMeshProUGUI scor_text;
    public  static float scor_point;
    void Start()
    {
        scor_point =0;
        scor_text = GetComponent<TextMeshProUGUI>();
    }
    public static void  changeScor(float point)
    {
        scor_point += point;
        TreasureChest.sandik_puani += point;
        scor_text.text = "Scor : " + scor_point.ToString();
    }
}
