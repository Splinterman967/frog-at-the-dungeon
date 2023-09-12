using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public static float Exp=0;
    public static float maxExp;
    float animasyonYavasligi = 20;
    private float  GercekScale;
    private float Experience_Level = 1;

    [SerializeField] UpgradePanelMenu upgradePanel;  

    void Start()
    {
        Exp = 100;
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

        if (Exp >= maxExp)
        {
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
