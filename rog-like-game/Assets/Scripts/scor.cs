using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scor : MonoBehaviour
{

    [SerializeField] static TextMeshProUGUI scor_text;
    public  static float scor_point;
    // Start is called before the first frame update
    void Start()
    {
        scor_point =0;

        scor_text = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void  changeScor(float point)
    {
        scor_point += point;

        scor_text.text = "Scor : " + scor_point.ToString();
    }
}
