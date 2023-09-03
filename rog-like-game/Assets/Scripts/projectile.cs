using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public static float electroball_damage;
    public static float electroball_frequency;
    private float damage;

    Rigidbody2D projectile_rigidbody;
  
    // Start is called before the first frame update
    void Start()
    {      
        castElectroBall();
    }

    // Update is called once per frame
    void Update()
    {
        updateDamage();
    }
    void updateDamage()
    {
        damage = electroball_damage * playerAttrabiutes.damage_scale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().enemy_hp -= damage;
        }
    }

    void castElectroBall()
    {
    
        Vector2 force = new Vector2(Random.Range(-360, 360), Random.Range(-360, 360));

        projectile_rigidbody = GetComponent<Rigidbody2D>();

        projectile_rigidbody.AddForce(force);
    }
}
