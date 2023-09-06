using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sword : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI damage_text;
    public static float sword_damage= 20;
    public static float sword_speed=-100;
    private float damage;
   
    
    void Update()
    {
        updateDamage();
        spinSword();
    }

    void spinSword()
    {
        transform.Rotate(0, 0, sword_speed * Time.deltaTime, Space.Self);
       
        transform.localPosition = new Vector3(0, 0, 0);
    }

    void updateDamage()
    {
        damage = sword_damage * playerAttrabiutes.damage_scale;
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().enemy_hp -= damage;
           

           // Instantiate(damage_text, collision.gameObject.transform.position, collision.gameObject.transform.rotation);

            //damage_text.text = sword_damage.ToString();
        }
    }
}
