using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public static float Exp=10; 
    float animasyonYavasligi = 50;
    private float maxExp, GercekScale;
    private float Experience_Level = 1;

    [SerializeField] UpgradePanelMenu upgradePanel;  

    void Start()
    {
        Exp = 90;
        maxExp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        GercekScale = Exp / maxExp;

        if (transform.localScale.x > GercekScale)
        {
            transform.localScale = new Vector3(transform.localScale.x , transform.localScale.y + (GercekScale - transform.localScale.y) / animasyonYavasligi, transform.localScale.z);
        }

        if (Input.GetKeyDown("c"))
        {
            Exp += 50;
        }

        if (Exp >= maxExp)
        {
            Exp = 90;
            maxExp += 200;
            Experience_Level += 1;
            LevelUP();
        }
    }

    private void LevelUP()
    {
        AudioManager.Instance.PlaySFX("levelUp");
        upgradePanel.openPanel();
    }
}
