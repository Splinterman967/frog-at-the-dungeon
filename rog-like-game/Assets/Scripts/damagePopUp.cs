using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class damagePopUp : MonoBehaviour
{
    private TextMeshPro damage_Text;
    private float ySpeed = 2f;
    private float xSpeed = 2f;


    private void Update()
    {
        gameObject.transform.position += new Vector3(xSpeed, ySpeed)* Time.deltaTime;
    }

    public void damage_popUp(float damage, Collider2D collision)
    {
        
        damage_Text = gameObject.GetComponent<TextMeshPro>();

        damage_Text.text = damage.ToString();

        GameObject dmg_popUp = Instantiate(this.gameObject, collision.transform.position, Quaternion.identity);

        damage_Text.sortingOrder++;

        Destroy(dmg_popUp, 0.6f);
    }
}
